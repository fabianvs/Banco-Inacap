<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BancoWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Banco Citi: Tu banco estatal de Chile</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body 
        {background-image: url('../Images/fondo.jpg');
         background-size: cover;
         background-position: center;

        }
    </style>
</head>
<body><div class="container" style="background: #8C1544 ">
        <div class="head" >
  


          <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="Default.aspx">Banco Citi</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link active" aria-current="page" href="Default.aspx">Home</a>
        <a class="nav-link" href="LoginCliente.aspx">Iniciar sesión como cliente</a>
        <a class="nav-link" href="LoginEjecutivo.aspx">Iniciar sesión como ejecutivo</a>
        <a class="nav-link" href="HazteCliente.aspx">Hazte Cliente</a>
      </div>
    </div>
  </div>
</nav>
         </div>    </div>
      <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
