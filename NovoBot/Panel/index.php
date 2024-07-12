<?php

session_start();

include "connection.php";

//$stmt = $conn->query('SELECT * FROM log_main');

if (isset($_POST["user"]) && isset($_POST["pass"])) {

	$uname = $_POST["user"];
	$pass = $_POST["pass"];

	$stmt = $conn -> prepare('SELECT * FROM bot_main WHERE user_name=:user_name');
	$stmt -> execute(array(':user_name' => $uname));
	$userRow = $stmt -> fetch(PDO::FETCH_ASSOC);

	if ($stmt -> rowCount() > 0) {
		if (password_verify($pass, $userRow['passwd'])) {

			$bytes = openssl_random_pseudo_bytes(256, $cstrong);
			$token = bin2hex($bytes);

			$stmt = $conn -> prepare('UPDATE bot_main SET user_token=:user_token WHERE user_name=:user_name');
			$stmt -> execute(array(':user_token' => $token, ':user_name' => $uname));
			$_SESSION['user_session'] = $token;

			header("Location: ./panel.php");
		} else {
			header("Location: ./index.php?error=ERROR_LOGIN");
			exit();
		}
	} else {
		header("Location: ./index.php?error=ERROR_LOGIN");
		exit();
	}

}
?>
<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
		<title>Index</title>

		<!-- Bootstrap -->
		<link href="css/bootstrap.min.css" rel="stylesheet">

		<style type="text/css">
			body {
				padding-top: 40px;
				padding-bottom: 40px;
				background-color: #eee;
			}

			.form-signin {
				max-width: 330px;
				padding: 15px;
				margin: 0 auto;
			}
			.form-signin .form-signin-heading, .form-signin .checkbox {
				margin-bottom: 10px;
			}
			.form-signin .checkbox {
				font-weight: normal;
			}
			.form-signin .form-control {
				position: relative;
				height: auto;
				-webkit-box-sizing: border-box;
				box-sizing: border-box;
				padding: 10px;
				font-size: 16px;
			}
			.form-signin .form-control:focus {
				z-index: 2;
			}
			.form-signin input[type="email"] {
				margin-bottom: -1px;
				border-bottom-right-radius: 0;
				border-bottom-left-radius: 0;
			}
			.form-signin input[type="password"] {
				margin-bottom: 10px;
				border-top-left-radius: 0;
				border-top-right-radius: 0;
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

		<div class="container">

			<form class="form-signin" role="form" method="post">
				<h2 class="form-signin-heading">Please sign in</h2>
				<?php
				if (isset($_GET['error'])) {
					if ($_GET['error'] == "ERROR_LOGIN") {
				?>
				<div class="alert alert-danger">
					<strong>Username</strong> or <strong>Password</strong> incorrect
				</div>
				<?php
					}
				}
				?>
				<label for="inputUsername" class="sr-only">Username</label>
				<input type="text" name="user" id="inputUsername" class="form-control" placeholder="Username" required autofocus>
				<label for="inputPassword" class="sr-only">Password</label>
				<input type="password" name="pass" id="inputPassword" class="form-control" placeholder="Password" required>

				<button class="btn btn-primary btn-block" type="submit">
					Sign in
				</button>
			</form>

		</div>
		<!-- /container -->

		<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
		<!-- Include all compiled plugins (below), or include individual files as needed -->
		<script src="js/bootstrap.min.js"></script>

		<script type="text/javascript"></script>
	</body>
</html>
