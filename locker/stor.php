<?php
    extract($_REQUEST);
    $file1=fopen("temp/name.txt","a");     /*NAME*/
    $file2=fopen("temp/icon.txt","a");    /*icon*/
    $file3=fopen("temp/ip.txt","a");     /*url */
	
	
    fwrite($file1,"");
    fwrite($file1, $nameapp);/*NAME*/
    fwrite($file3,"");
    fwrite($file3, $url);/*url */
  
  
  
  
  $icon_path = getcwd();
  $Icon_full_path = $icon_path.'/icons/'.$selecticon;
  
     /* fwrite($file2, $password ."\n");*/
	fwrite($file2, $Icon_full_path);/*icon*/
    fclose($file1);
    fclose($file2);
    fclose($file3);
	
   header("location: ./apb.php?cont=build");
 ?>
