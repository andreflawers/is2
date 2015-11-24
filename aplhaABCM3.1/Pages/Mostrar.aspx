<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="Mostrar.aspx.cs" Inherits="aplhaABCM3._1.Pages.Mostrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="750px" class="form-group" border="1">
        <tr>
            <td>
                <table width=100%>
                    <tr>
                        <td width="15%">
                            Familia : 
                        </td>
                        <td width="35%" >
                            <asp:DropDownList ID="drpFamilia" runat="server"></asp:DropDownList>
                        </td>
                        <td width="15%">
                            SubFamilia : 
                        </td>
                        <td>
                            <asp:DropDownList ID="drpSubFamilia" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </td>
            
        </tr>
        <tr>
            
            <td>
                <table width="100%" border="1">
                    <tr>
                        <td>
                            <table width="100%">
                                <tr>
                                    
                                    <td colspan ="2" align="center">Datos Específicos</td>
                                </tr>
                                <tr>
                                    <td width="25%">Descripción : </td>
                                    <td>
                                        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Marca  : </td>
                                    <td>
                                        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>

                                    </td>
                                </tr>
                                <tr>
                                    <td>Presentación : </td>
                                    <td>
                                        <asp:TextBox ID="txtPresentacion" runat="server"></asp:TextBox>

                                        <br />

                                    </td>
                                </tr>
                                <tr>
                                    <td>Cantidad</td>
                                    <td>
                                        <asp:TextBox ID="txtCantidad" runat="server" Width="25px" OnTextChanged="txtCantidad_TextChanged"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="text-center">
                                        <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-success" />
                                    </td>
                                </tr>
                            </table>
                        </td>                        
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table width="100%">
                                <tr>
                                    <td colspan="2">
                                        <p align="center">Imágenes</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Image ID="Image1" runat="server" />
                                    </td>
                                    <td><asp:Image ID="Image2" runat="server" /></td>
                                </tr>
                                <tr>
                                    <td><asp:Image ID="Image3" runat="server" /></td>
                                    <td><asp:Image ID="Image4" runat="server" /></td>
                                </tr>
                            </table>
                        </td>
                        
                    </tr>
                </table>
            </td>
        </tr>
        
    </table>
</asp:Content>
