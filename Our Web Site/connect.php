<?php
if(isset($_POST['sub'])){
$msg='fnm'.$_POST['fnm']."\n"
.'em'.$_POST['em']."\n"
.'un'.$_POST['un']."\n"
.'ads'.$_POST['ads']."\n"
.'content'.$_POST['content'];
mail('gihanbridge@gmail.com','hello',$msg);
include("sent.html"); 
}else{
	echo 'hi';
	exit(0);
}
	
?>