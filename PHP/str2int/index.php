<?php
$filename = "input.txt";
$file = fopen($filename,"r");
$resultList = array();
while($txt = fgets($file))
{
	$result = 0;
	for($i = 0;$i < strlen($txt); $i++)
	{
		if($txt[$i] >= '0' && $txt[$i] <= '9')
		{
			$tmp = $txt[$i] - '0';
			$result = $result*10 + $tmp;
		}
		
	}
	array_push($resultList,$result);
}
echo "<pre>";
var_dump($resultList);
echo "</pre>";
?>