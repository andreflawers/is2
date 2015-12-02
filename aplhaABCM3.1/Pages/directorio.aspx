<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="directorio.aspx.cs" Inherits="aplhaABCM3._1.Pages.directorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="700px" align="center">
        <tr>
            <td align="center">
                <h1>Lista de Productos</h1>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="lkb_nuevo_producto" runat="server" OnClick="lkb_nuevo_producto_Click" >Registrar nuevo producto</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Panel ID="Panel_mant_producto" Width="100%" BorderStyle="Solid" BorderWidth="1" runat="server">
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
                            <td style="width: 100px;" class="text-right">Categoría :</td>
                            <td class="form-control" style="width: 150px;">
                                <asp:DropDownList ID="drpCategoria" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnCate" runat="server" Text="..." OnClick="btnCate_Click" /></td>
                            <td style="width: 200px;" class="text-right">Marca : </td>
                            <td class="form-control" style="width: 100px;">
                                <asp:DropDownList ID="drpMarca" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnMarca" runat="server" Text="..." OnClick="btnMarca_Click" /></td>

                        </tr>
                        <tr>
                            <td class="text-right">Clase : </td>
                            <td class="form-control" style="width: 150px;">
                                <asp:DropDownList ID="drpClase" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnClase" runat="server" Text="..." OnClick="btnClase_Click" /></td>
                            <td class="text-right">Modelo : </td>
                            <td class="form-control" style="width: 100px;">
                                <asp:DropDownList ID="drpModelo" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnModelo" runat="server" Text="..." OnClick="btnModelo_Click" /></td>
                        </tr>
                        <tr>
                            <td class="text-right">Tipo de Producto : </td>
                            <td class="form-control" style="width: 150px;">
                                <asp:DropDownList ID="drpTipoProducto" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnTipoProducto" runat="server" Text="..." OnClick="btnTipoProducto_Click" /></td>
                            <td class="text-right">Unidad : </td>
                            <td class="form-control" style="width: 100px;">
                                <asp:DropDownList ID="drpUnidad" runat="server"></asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnUnidad" runat="server" Text="..." OnClick="btnUnidad_Click" /></td>
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
                           <asp:Button ID="btn_grabar" runat="server" Text="Grabar" OnClick="btn_grabar_Click"    />&nbsp
                           <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click"  />
                       </td>
                   </tr>
               </table>
                </asp:Panel>
            </td>
        </tr> 
        <tr> 
            <td> <br />
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
                                    OnClientClick="return confirm('Esta seguro de eliminar el producto?')" OnClick="lkb_eliminar_Click" >Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

    </table>

</asp:Content>
