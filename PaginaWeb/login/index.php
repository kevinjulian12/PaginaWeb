<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Server Side Form validations Using PHP</title>
<link rel="stylesheet" href="style.css" type="text/css" />
<style type="text/css">

<?php
if(isset($error))
{
 ?>
 input:focus
 {
  border:solid red 1px;
 }
 <?php
}
?>
</style>
<?php

if(isset($_POST['btn-signup']))
{
 
 $email = trim($_POST['email']);
 $upass = trim($_POST['pass']);
 
 

 if(empty($email))
 {
  $error = "ingrese un email";
  $code = 2;
 }
 else if( $_POST['email'] !== "elelog@elelog.es")
 {
  $error = "email invalido";  
  $code = 2;
 }

 
 else if(empty($upass))
 {
  $error = "ingrese una contraseña";
  $code = 4;
 }
 else if(md5($upass) !== '81dc9bdb52d04dc20036dbd8313ed055' )
 {
  $error = "contraseña invalida";
  $code = 4;
 }
 else
 {
  ?>
        <script>
        alert('Bienvenido');
  document.location.href='index.php';
        </script>
        <?php
 }
}
?>
</head>
<body>
<center>
<div id="login-form">
<form method="post">
<table align="center" width="30%" border="0">
<?php
if(isset($error))
{
 ?>
    <tr>
    <td id="error"><?php echo $error; ?></td>
    </tr>
    <?php
}
?>

<tr>
<td><input type="text" name="email" placeholder="Usuario"  value="<?php if(isset($email)){echo $email;} ?>" <?php if(isset($code) && $code == 2){ echo "autofocus"; }  ?> /></td>
</tr>
<tr>
<td><input type="password" name="pass" placeholder="Password" <?php if(isset($code) && $code == 4){ echo "autofocus"; }  ?> /></td>
</tr>
<tr>
<td><button type="submit" name="btn-signup">aceptar</button></td>
</tr>
</table>
</form>
</div>
</center>
</body>

</html>