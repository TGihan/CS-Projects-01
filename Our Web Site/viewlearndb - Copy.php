<HTML>
<body>
<style>
body{
	background-image:url(bgtop.jpg);
	background-repeat: repeat-x;
	font-size:16px;
	}
</style>
<table width="200" border="0" align="right">
  <tr>
    <th scope="col"><a href="table.html" style="text-decoration:none" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">Sign in</a></th>
    <th scope="col"><a href="contact.html" style="text-decoration:none" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">Log in</a></th>
  </tr>
</table>
<br/>
<br />
<table width="499" border="0" align="center">
  <tr>
    <th scope="col"><a href="main.html" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">Home</a></th>
    <th scope="col"><a href="server.html" style="text-decoration:none" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">Services</a></th>
    <th scope="col"><a href="about.html" style="text-decoration:none" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">About</a></th>
    <th scope="col"><a href="contact.html" style="text-decoration:none" onMouseOver="this.style.color = '#06f'" onMouseOut="this.style.color = '#FFF'">Contacts</a></th>
  </tr>
</table>
<p>
  <style type="text/css">

a { text-decoration : none; color : #fff; font-family:segoe ui; font-size:15px; }

  </style>
  <style>
body{
	background-color: #666;
	padding: 0;
	margin: 0;
	width: 100%;
	height: 600px;
}

  </style>
</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>

<?php
$db = mysql_connect("localhost", "root", "");
mysql_select_db("sign",$db);
$result = mysql_query("SELECT * FROM Sign_Tb",$db);
echo "<TABLE>";
echo"<TR><TD><B>First Name</B>
<TD><B>Last Name</B>
<TD><B>User Name</B>
<TD><B>Passsword</B></TR>";
while ($myrow = mysql_fetch_array($result))
{
echo "<TR><TD>";
echo $myrow["firstname"];
echo " ";
echo $myrow["lastname"];
echo "<TD>";
echo $myrow["usernm"];
echo "<TD>";
echo $myrow["psw"];
}
echo "</TABLE>";
?>
</HTML>