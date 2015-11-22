<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="directorio.aspx.cs" Inherits="aplhaABCM3._1.Pages.directorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="750px" class="form-group">
        <tr>
            <td style="width:100px;"  class="text-right" >
                Categoría :</td>
            <td class="form-control" style="width:150px;"><asp:DropDownList ID="drpCategoria" runat="server"></asp:DropDownList></td>
             <td><asp:Button ID="Button1" runat="server" Text="..." OnClick="Button1_Click" /></td>
            <td style="width:200px;" class="text-right">Marca : </td>
            <td class="form-control"style="width:100px;"><asp:DropDownList ID="drpMarca" runat="server"></asp:DropDownList></td>
            <td><asp:Button ID="btnMarca" runat="server" Text="..." OnClick="btnMarca_Click" /></td>
            
        </tr>
        <tr >
            <td class="text-right">Clase : </td>
           <td class="form-control" style="width:150px;"><asp:DropDownList ID="drpClase" runat="server"></asp:DropDownList></td>
              <td><asp:Button ID="Button2" runat="server" Text="..." /></td>
            <td class="text-right">Modelo : </td>
            <td class="form-control"style="width:100px;" ><asp:DropDownList ID="drpModelo" runat="server"></asp:DropDownList></td>
            <td><asp:Button ID="btnModelo" runat="server" Text="..." OnClick="btnModelo_Click" /></td>
        </tr>
        <tr>
          <td class="text-right">Tipo de Producto : </td>
            <td class="form-control" style="width:150px;"><asp:DropDownList ID="drpTipoProducto" runat="server"></asp:DropDownList></td>
            <td><asp:Button ID="Button4" runat="server" Text="..." /></td>
            <td class="text-right">Unidad : </td>
            <td class="form-control"style="width:100px;"><asp:DropDownList ID="drpUnidad" runat="server"></asp:DropDownList></td>
            <td><asp:Button ID="btnUnidad" runat="server" Text="..." OnClick="btnUnidad_Click" /></td>        </tr>
      
    </table>
</asp:Content>
