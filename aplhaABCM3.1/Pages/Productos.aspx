<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="aplhaABCM3._1.Pages.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="800px">
        <tr>
            <td class="text-center"><h2>Lista de Productos</h2>
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnCreate" runat="server" Text="Insertar Producto" OnClick="btnCreate_Click" />
            </td>
        </tr>
        <tr>
            <td class="center-block">
                
                <br />
                <br />
                <asp:Panel ID="pnlForm" runat="server" width="350px" BorderColor="#996600" BorderStyle="Solid" BorderWidth="1px" Visible="false">
                    <table Width="100%">
                        <tr>
                            <td class="text-center">
                                <h4>Nuevo Producto</h4>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table Width="100%">
                                    <tr>
                                        <td class="text-right">
                                            idProducto : 
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtIdProducto" runat="server" CssClass="form-control" Width="100px" Height="25px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Descripción : 
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Width="200px" Height="25px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Cantidad:
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" Width="75" Height="25px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Precio : 
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" Width="75" Height="25px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            SubFamilia
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="dpwSubFamilia" runat="server" CssClass="form-control" Width="200" Height="25"></asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Marca : 
                                        </td>
                                        <td>
                                             <asp:DropDownList ID="dpwMarca" runat="server" CssClass="form-control" Width="200" Height="25"></asp:DropDownList>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td class="text-right">
                                            Presentación :
                                        </td>
                                        <td>
                                             <asp:DropDownList ID="drpPresentacion" runat="server" CssClass="form-control" Width="200" Height="25"></asp:DropDownList>
                                            <br />
                                        </td>
                                    </tr>
                                    </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success"/>&nbsp
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />                                                                
                            </td>                            
                        </tr>
                        <tr>
                            <td>
                                <br />
                            </td>
                        </tr>
                    </table>

                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td >
                <asp:GridView ID="grd_producto" runat="server" CssClass="table table-striped" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="idProducto" HeaderText="Id" />
                        <asp:BoundField DataField="descripcionProducto" HeaderText="Descripción" />
                        <asp:BoundField DataField="cantidadProducto" HeaderText="Cantidad" />
                        <asp:BoundField DataField="precioProducto" HeaderText="Precio" />
                        <asp:BoundField DataField="subFamiliaProducto" HeaderText="SubFamilia" />
                        <asp:BoundField DataField="marcaProducto" HeaderText="Marca" />
                        <asp:BoundField DataField="presentacionProducto" HeaderText="Presentacion" />
                    </Columns>

                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
