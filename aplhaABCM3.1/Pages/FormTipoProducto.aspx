<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FormTipoProducto.aspx.cs" Inherits="aplhaABCM3._1.Pages.FormTipoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="col-md-push-1 col-md-10">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lista de Tipo de Productos</h1>
                    <div class="col-md-10">
                        <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
                        <asp:LinkButton ID="lkb_nuevo_tipo_producto" runat="server" OnClick="lkb_nuevo_tipo_producto_Click">Registrar nuevo tipo de producto</asp:LinkButton>
                        <asp:Button ID="Button1" runat="server" Text="" Height="1px" BackColor="#F6F6F6" BorderColor="#F3F3F3" BorderStyle="None" />
                        <asp:Panel ID="Panel_mant_tipo" Width="550px" CssClass="panel panel-default" runat="server">
                            <table width="100%">
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="lbl_titulo" runat="server" Text="" Font-Size="X-Large"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Código de la empresa : </h5>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_id_empresa" Width="200px" runat="server" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Categoría : </h5>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="drp_cate" runat="server"  CssClass="btn btn-default dropdown-toggle"></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Clase : </h5>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="drp_clase" runat="server" CssClass="btn btn-default dropdown-toggle"></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Código tipo de producto : </h5>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_cod_tipo" Width="200px" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Abreviatura : </h5>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_txt_abrv" Width="200px" runat="server" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Descripción : </h5>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_txt_desc" Width="200px" runat="server" CssClass="form-control"></asp:TextBox>
                                                </td>
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
                                        <asp:Button ID="btn_grabar" runat="server" Text="Grabar" OnClick="btn_grabar_Click" CssClass="btn btn-success" />&nbsp
                           <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" CssClass="btn btn-danger" />
                                    </td>
                                </tr>

                            </table>

                        </asp:Panel>
                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                            PopupControlID="Panel_mant_tipo"
                            TargetControlID="Button1" Enabled="true" DropShadow="true"
                            BackgroundCssClass="modalBackground">
                        </ajaxToolkit:ModalPopupExtender>
                    </div>
                    <div class="col-md-12">
                        <asp:GridView ID="grd_tipo" Width="100%" runat="server" AutoGenerateColumns="False" GridLines="None" UseAccessibleHeader="true" CssClass="table table-striped">
                            <Columns>
                                <asp:BoundField DataField="cod_cate" HeaderText="Codigo de la categoria" />
                                <asp:BoundField DataField="categoria" HeaderText="Descripcion de la categoria" />
                                <asp:BoundField DataField="cod_clase" HeaderText="Codigo de la clase" />
                                <asp:BoundField DataField="clase" HeaderText="Descripcion de la clase" />
                                <asp:BoundField DataField="cod_tipo" HeaderText="Codigo del tipo de Producto" />
                                <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                                <asp:BoundField DataField="txt_desc" HeaderText="Descripcion del Tipo de Producto" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("cod_tipo") %>' OnClick="lkb_editar_Click">Editar</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lkb_eliminar" runat="server"
                                            CommandArgument='<%# Eval("cod_tipo") %>'
                                            OnClientClick="return confirm('Esta seguro de eliminar el tipo de producto?')" OnClick="lkb_eliminar_Click">Eliminar</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
