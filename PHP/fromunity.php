<?php
    $text1 = $_POST["score"];

    if($text1 != "")
    {
        echo("Message successfully sent!");
        echo("Field 1:" . $text1);
        $file = fopen("data.txt", "a");
        fwrite($file, $text1);
        fclose($file);
    } else
    {
        echo("Message delivery failed... ");
    }

?>