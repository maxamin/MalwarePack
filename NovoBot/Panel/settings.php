<?php
session_start();
include "connection.php";

if (isset($_SESSION['user_session'])) {

	$token = $_SESSION['user_session'];

	$stmt = $conn -> prepare('SELECT * FROM bot_main WHERE user_token=:user_token');
	$stmt -> execute(array(':user_token' => $token));
	$userRow = $stmt -> fetch(PDO::FETCH_ASSOC);

	if ($stmt -> rowCount() <= 0) {
		header("Location: ./index.php");
		exit();
	}

} else {
	header("Location: ./index.php");
	exit();
}

if (isset($_POST['old-pass']) && strlen($_POST['old-pass']) != 0) {
	$oldPass = $_POST['old-pass'];
	$newPass = $_POST['new-pass'];
	$newRPass = $_POST['new-r-pass'];
	$timeZone = $_POST['time-zone'];
	$timeZoneId = $_POST['time-zone-id'];

	$token = $_SESSION['user_session'];

	$stmt = $conn -> prepare('SELECT * FROM bot_main WHERE user_token=:user_token');
	$stmt -> execute(array(':user_token' => $token));
	$userRow = $stmt -> fetch(PDO::FETCH_ASSOC);

	if (password_verify($oldPass, $userRow['passwd'])) {

		if ((strlen($newPass) != 0) && (strlen($newRPass) != 0)) {
			if ($newPass == $newRPass) {
				// update pass
				$hash = password_hash($newPass, PASSWORD_DEFAULT);

				$stmt = $conn -> prepare('UPDATE bot_main SET passwd=:passwd WHERE user_token=:user_token');
				$stmt -> execute(array(':passwd' => $hash, ':user_token' => $token));

				if (($userRow['time_zone'] != $timeZone) && ($userRow['time_zone_id'] != $timeZoneId)) {
					$stmt = $conn -> prepare('UPDATE bot_main SET time_zone=:time_zone, time_zone_id=:time_zone_id WHERE user_token=:user_token');
					$stmt -> execute(array(':time_zone' => $timeZone, ':time_zone_id' => $timeZoneId, ':user_token' => $token));

					header("Location: ./settings.php?error=UPDATE");
					exit();
				} else {
					header("Location: ./settings.php?error=UPDATE");
					exit();
				}

			} else {
				header("Location: ./settings.php?error=ERROR_NEW_PASS");
				exit();
			}
		} else {

			if (($userRow['time_zone'] != $timeZone) && ($userRow['time_zone_id'] != $timeZoneId)) {

				$stmt = $conn -> prepare('UPDATE bot_main SET time_zone=:time_zone, time_zone_id=:time_zone_id WHERE user_token=:user_token');
				$stmt -> execute(array(':time_zone' => $timeZone, ':time_zone_id' => $timeZoneId, ':user_token' => $token));

				header("Location: ./settings.php?error=UPDATE");
				exit();
			} else {
				header("Location: ./settings.php?error=ERROR_NO_UPDATE");
				exit();
			}
		}

	} else {
		header("Location: ./settings.php?error=ERROR_OLD_PASS");
		exit();
	}

}

$stmt = $conn -> prepare('SELECT time_zone, time_zone_id FROM bot_main WHERE user_token=:user_token');
$stmt -> execute(array(':user_token' => $token));
$userRow = $stmt -> fetch(PDO::FETCH_ASSOC);
?>
<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
		<title>Settings</title>

		<!-- Bootstrap -->
		<link href="css/bootstrap.min.css" rel="stylesheet">

		<style type="text/css">
			body {
				padding-top: 70px;
				background: #666;
			}
			.form-settings {
				max-width: 780px;
				padding: 15px;
				margin: 0 auto;
			}
			@media screen and (max-width: 768px) {
				body {
					padding-top: 70px;
				}
			}
		</style>

		<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
		<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
	</head>
	<body>

		<nav class="navbar navbar-default navbar-fixed-top">
			<div class="container">
				<div class="navbar-header">
					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<a class="navbar-brand" href="#">NovoBot HTTP</a>
				</div>
				<div id="navbar" class="navbar-collapse collapse">
					<ul class="nav navbar-nav navbar-right">
						<li>
							<a href="./panel.php">Panel</a>
						</li>
						<li>
							<a href="./task.php">Tasks</a>
						</li>
						<li class="active">
							<a href="./settings.php">Settings</a>
						</li>
					</ul>
				</div><!--/.nav-collapse -->
			</div>
		</nav>

		<div class="container">
			<form class="form-settings" method="post">

				<?php
				if (isset($_GET['error'])) {
				if ($_GET['error'] == "ERROR_OLD_PASS") {
				?>
				<div class="alert alert-danger">
					Please enter your correct <strong>Password</strong>
				</div>
				<?php
				} else if ($_GET['error'] == "ERROR_NEW_PASS") {
				?>
				<div class="alert alert-danger">
					The new <strong>Passwords</strong> for update did not match
				</div>
				<?php
				} else if ($_GET['error'] == "UPDATE") {
				?>
				<div class="alert alert-success">
					<strong>Settings</strong> were updated
				</div>
				<?php
				}
				}
				?>

				<div class="panel panel-primary">
					<div class="panel-heading">
						Would you like to change your password?
					</div>
					<div class="panel-body">
						<input type="password" name="new-pass" class="form-control" id="passwordInput" placeholder="Password">
						<br />
						<input type="password" name="new-r-pass" class="form-control" id="RpasswordInput" placeholder="Re-Type Password">
					</div>
				</div>

				<div class="panel panel-warning">
					<div class="panel-heading">
						Please do enter your current password to commit the changes if any made
					</div>
					<div class="panel-body">
						<input name="old-pass" type="password" class="form-control" id="usernameInput" placeholder="Password" required>
					</div>
					<div class="panel-footer">
						<button class="btn btn-primary" type="submit">
							Update
						</button>
					</div>
				</div>

			</form>
		</div>

		<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
		<!-- Include all compiled plugins (below), or include individual files as needed -->
		<script src="js/bootstrap.min.js"></script>

		<script type="text/javascript">var time_zone_val =<?php echo $userRow['time_zone']; ?>
	;
	var time_zone_id =  
 <?php echo $userRow['time_zone_id']; ?>
	;

	$(document).ready(function() {
		$("#time-zone option").each(function() {
			if ($(this).val() == time_zone_val && $(this).attr('timeZoneId') == time_zone_id) {
				$(this).attr('selected', 'selected');
			}
		});
	});

	$('#time-zone').on('change', function() {
		$('#time-zone-id').val($('option:selected', this).attr('timeZoneId'));
	});
		</script>

	</body>
</html>
