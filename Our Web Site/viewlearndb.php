<HTML>
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