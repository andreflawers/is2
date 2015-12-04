<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="WebFormInv.aspx.cs" Inherits="aplhaABCM3._1.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="800px">
        <tr>
            <td class="text-center"><h2>Inventario</h2></td>
        </tr>
        <tr>
            <td>Tipo de Inventario :</td>
            <td><asp:DropDownList ID="dpdl_inv" runat="server" >          
                </asp:DropDownList></td>
        </tr>
        <tr><td>Almacen :</td>
            <td>
                <asp:DropDownList ID="dpdl_alm" runat="server" >
                </asp:DropDownList></td>
        </tr>
        <tr> <td class="text-center">
            <asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" OnClick="btn_Aceptar_Click" /></td></tr>
        <tr><td>
            <asp:Label ID="LblMensajeError" runat="server" Text=""></asp:Label>
            </td></tr>
        <tr>
           <asp:GridView ID="Gdv_inv" runat="server" AutoGenerateColumns="False" AllowPaging="True">
                <Columns>          
                    
                    <%--<asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    --%>                    
                </Columns>
            </asp:GridView>
           
        </tr>
    </table>
</asp:Content>
