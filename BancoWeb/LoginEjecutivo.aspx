<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="LoginEjecutivo.aspx.cs" Inherits="BancoWeb.LoginEjecutivo" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="/imgs/icon.jpg" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio sesión para ejecutivos </title>
       
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body 
        {background-image: url('../Images/fondo.jpg');
         background-size: cover;
         background-position: center;

        }
    </style>
</head>
<body>
    <div class="container mt-5">
        <form id="form1" runat="server">
            <div class="row">
                <div class="col-4 mx-auto mt-8 mb-8 rounded shadow-lg" style="background:#8D97AA">
                    <h1 class="text-center" style="color:#22417A  ">Iniciar Sesión Ejecutivos</h1>
                    <hr />

                    <div class="mb-3" style="background:##8D97AA">
                        <label for="exampleInputEmail1" class="form-label">Digite su rut</label>
                        <asp:TextBox ID="rutelog" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="mb-3" style="background:#8D97AA">
                        <label for="exampleInputPassword1" class="form-label">Ingrese su contraseña</label>
                        <asp:TextBox ID="passelog" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    

                    <button type="submit" class="btn btn-primary" style="background: #754F4B">Ingresar</button>

                    <hr />
                </div>
            </div>
            
        </form>
    </div>
    </body>
    </html>
