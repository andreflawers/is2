<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="WebFormProducto.aspx.cs" Inherits="aplhaABCM3._1.Pages.WebFormProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container well">
        <div class="row">
            <div>
                <asp:Button ID="btn_BusquedadAvanzada" runat="server"  Text="Busquedad Avanzada" />
                <br />
                <asp:Panel ID="panelBusAvanzada" GroupingText="BUSQUEDAD AVANZADA"  runat="server" Visible="false">
                </asp:Panel>
                <br/>
                <asp:Button ID="btn_buscar" runat="server" Text="Buscar"/>
                <asp:TextBox ID="TextBoxbuscarid" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtbuscardescripcion" runat="server" ></asp:TextBox>
                <br />
                <br />
                <asp:GridView ID="grd_Producto" runat="server">
                </asp:GridView>
                <br />
                <asp:Label ID="lbl_mesg_01" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
