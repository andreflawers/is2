<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="directorio.aspx.cs" Inherits="aplhaABCM3._1.Pages.directorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="700px" class="form-group left">
        <tr>
            <td align="center">
                <h2>Directorio</h2>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <%--   <asp:LinkButton ID="lkb_nuevo_producto" runat="server" OnClick="lkb_nuevo_producto_Click" >Registrar nuevo producto</asp:LinkButton>--%>
            </td>
        </tr>
        <tr>
            <td align="left">

                <table width="100%">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lbl_titulo" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table width="750px" class="form-group">

                                <tr>
                                    <td style="width: 100px;">
                                        <h4 class="text-right">Categoría : </h4>
                                    </td>
                                    <td class="dropdown" style="width: 150px;">
                                        <asp:DropDownList ID="drpCategoria" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList>
                                    </td>
                                    <td>&nbsp<asp:Button ID="btnCate" runat="server" Text="..." OnClick="btnCate_Click" CssClass="btn btn-warning" /></td>
                                    <td style="width: 200px;">
                                        <h4 class="text-right">Marca : </h4>
                                    </td>
                                    <td style="width: 100px;">
                                        <asp:DropDownList ID="drpMarca" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList></td>
                                    <td>&nbsp<asp:Button ID="btnMarca" runat="server" Text="..." OnClick="btnMarca_Click" CssClass="btn btn-warning" /></td>

                                </tr>
                                <tr>
                                    <td>
                                        <h4 class="text-right">Clase : </h4>
                                    </td>
                                    <td style="width: 150px;">
                                        <asp:DropDownList ID="drpClase" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList></td>
                                    <td>&nbsp<asp:Button ID="btnClase" runat="server" Text="..." OnClick="btnClase_Click" CssClass="btn btn-warning" /></td>

                                    <td>
                                        <h4 class="text-right">Modelo : </h4>
                                    </td>
                                    <td style="width: 100px;">
                                        <asp:DropDownList ID="drpModelo" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList></td>
                                    <td>&nbsp<asp:Button ID="btnModelo" runat="server" Text="..." OnClick="btnModelo_Click" CssClass="btn btn-warning" /></td>
                                </tr>
                                <tr>
                                    <td>
                                        <h4 class="text-right">Tipo :</h4>
                                    </td>
                                    <td style="width: 150px;">
                                        <asp:DropDownList ID="drpTipoProducto" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList></td>
                                    <td>&nbsp<asp:Button ID="btnTipoProducto" runat="server" Text="..." OnClick="btnTipoProducto_Click" CssClass="btn btn-warning" /></td>

                                    <td>
                                        <h4 class="text-right">Unidad : </h4>
                                    </td>
                                    <td style="width: 100px;">
                                        <asp:DropDownList ID="drpUnidad" runat="server" CssClass="btn btn-default btn-sm dropdown-toggle"></asp:DropDownList></td>
                                    <td>&nbsp<asp:Button ID="btnUnidad" runat="server" Text="..." OnClick="btnUnidad_Click" CssClass="btn btn-warning" /></td>
                                </tr>
                </table>
            </td>
            </tr>
                   <tr>
                       <td align="center">
                           <asp:Label ID="lbl_confirmacion" runat="server" Text=""></asp:Label>
                       </td>
                   </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btn_grabar" runat="server" Text="Ir a Productos" OnClick="btn_grabar_Click" CssClass="btn btn-success"/>&nbsp                           
                </td>
            </tr>
            </table>
                
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:GridView ID="grd_producto" Width="100%" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="id_producto" HeaderText="Codigo del producto" />
                        <asp:BoundField DataField="cod_cate" HeaderText="Codigo de la categoria" />
                        <asp:BoundField DataField="cod_clase" HeaderText="Codigo de la clase" />
                        <asp:BoundField DataField="cod_tipo" HeaderText="Codigo del tipo de producto" />
                        <asp:BoundField DataField="cod_marca" HeaderText="Codigo de la marca" />
                        <asp:BoundField DataField="cod_modelo" HeaderText="Codigo del modelo" />
                        <asp:BoundField DataField="cod_um_principal" HeaderText="Codigo de la unidad" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("id_producto") %>' OnClick="lkb_editar_Click">Editar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_eliminar" runat="server"
                                    CommandArgument='<%# Eval("id_producto") %>'
                                    OnClientClick="return confirm('Esta seguro de eliminar el producto?')" OnClick="lkb_eliminar_Click">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

    </table>

</asp:Content>
