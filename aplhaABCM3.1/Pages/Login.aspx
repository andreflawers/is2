<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="aplhaABCM3._1.Pages.Login" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <div class="row">
               
                <div class="col-sm-6 col-md-4 col-md-offset-4">
                    <div class="text-center page-header">
                        <img src="../Images/Logo/logo-maritza.png"  height="90px" width="90px"/>                
                        </div>
                    <h1 class="text-center login-title">Bienvenidos a Maritza</h1>
                    <div class="account-wall">
                        <img class="profile-img" src="../Images/Logo/profile_empty.png"
                            alt="">
                        <form class="form-signin">
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"  TextMode="Email" required autofocus></asp:TextBox>
                            <%--<input id="txtEmail" type="text" class="form-control" placeholder="Email" required autofocus>--%>
                             <asp:TextBox ID="txtPassword" runat="server"  CssClass="form-control" placeholder="Password" required TextMode="Password" ></asp:TextBox>
                            <%--<input type="password" class="form-control" placeholder="Password" required>--%>
                            <asp:Label ID="lblError" runat="server" Visible="false" Text="" ForeColor="Red" CssClass="text-center"></asp:Label>
                            <asp:Button class="btn btn-lg btn-primary btn-block"
                                 ID="Button1" runat="server" Text="Sign in" OnClick="Button1_Click" />                       
                            <a href="#" class="pull-right need-help">Necesita ayuda? </a><span class="clearfix"></span>
                        </form>
                    </div>
                    <a href="#" class="text-center new-account">Crear nueva cuenta </a>
                </div>
            </div>
        </div>
    </form>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
