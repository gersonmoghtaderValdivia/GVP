<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GVP.VIEW.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label>
                    usuario: 
                </label>
                <br />

                <asp:TextBox ID="tbUsuario" runat="server"></asp:TextBox>
                <br />
                <label>
                    contraseña: 
                </label>
                <br />

                <asp:TextBox ID="tbPass" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
