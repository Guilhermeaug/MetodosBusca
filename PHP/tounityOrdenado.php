<?php
	$file = fopen("dataOrdenado.txt", "r");
    echo fread($file, filesize("dataOrdenado.txt"));
    fclose($file);
?>