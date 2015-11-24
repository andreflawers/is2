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
                                            <asp:TextBox ID="txtIdProducto" runat="server" CssClass="form-control" Width="100px" Height="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Descripción : 
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Width="200px" Height="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Cantidad:
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" Width="75" Height="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Precio : 
                                        </td>
                                        <td>
                                             <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" Width="75" Height="30px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            SubFamilia
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="dpwSubFamilia" runat="server" CssClass="form-control" Width="200" Height="30"></asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="text-right">
                                            Marca : 
                                        </td>
                                        <td>
                                             <asp:DropDownList ID="dpwMarca" runat="server" CssClass="form-control" Width="200" Height="30"></asp:DropDownList>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td class="text-right">
                                            Presentación :
                                        </td>
                                        <td>
                                             <asp:DropDownList ID="dpwPresentacion" runat="server" CssClass="form-control" Width="200" Height="30"></asp:DropDownList>
                                            <br />
                                        </td>
                                    </tr>
                                     <tr>
                                        
                                        <td colspan="2">
                                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                                            <br />
                                        </td>
                                    </tr>
                                    </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="btnAceptar_Click"/>&nbsp
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
                        <asp:BoundField DataField="id_Producto" HeaderText="Id" />
                        <asp:BoundField DataField="descripción_Producto" HeaderText="Descripción" />
                        <asp:BoundField DataField="cantidad_Producto" HeaderText="Cantidad" />
                        <asp:BoundField DataField="precio_Producto" HeaderText="Precio" />
                        <asp:BoundField DataField="nombre_SubFamilia" HeaderText="SubFamilia" />
                        <asp:BoundField DataField="nombre_marca" HeaderText="Marca" />
                        <asp:BoundField DataField="caracterstica_Presentacion" HeaderText="Presentacion" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server">Editar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
