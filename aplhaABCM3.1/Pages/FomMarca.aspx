﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FomMarca.aspx.cs" Inherits="aplhaABCM3._1.Pages.FomMarca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="col-md-push-1 col-md-10">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lista de Marcas</h1>
                    <div class="col-md-10">
                        <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
                        <asp:Button ID="Button1" CssClass="botoninvi" runat="server" Text="" Height="1px" BackColor="#F6F6F6" BorderColor="#F3F3F3" BorderStyle="None" />
                        <asp:LinkButton ID="lkb_nueva_marca" runat="server" OnClick="lkb_nueva_marca_Click">Registrar nueva marca</asp:LinkButton>
                        <asp:Panel ID="Panel_mant_marca" Width="550px" CssClass="panel panel-default" runat="server">
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
                                                    <h5 class="text-right">Código Marca : </h5>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txt_cod_marca" runat="server" Width="200px" Enabled="false" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Abreviatura : </h5>
                                                    :</td>
                                                <td>
                                                    <asp:TextBox ID="txt_txt_abrv" Width="200px" runat="server" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h5 class="text-right">Descripción </h5>
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
                            PopupControlID="Panel_mant_marca"
                            TargetControlID="Button1" Enabled="true" DropShadow="true"
                            BackgroundCssClass="modalBackground">
                        </ajaxToolkit:ModalPopupExtender>
                    </div>
                    <div class="col-md-12">
                        <asp:GridView ID="grd_marca" Width="100%" runat="server" AutoGenerateColumns="False" GridLines="None" UseAccessibleHeader="true" CssClass="table table-striped">
                            <Columns>
                                <asp:BoundField DataField="cod_marca" HeaderText="Codigo de la Marca" />
                                <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                                <asp:BoundField DataField="txt_desc" HeaderText="Descripcion" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("cod_marca") %>' OnClick="lkb_editar_Click">Editar</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lkb_eliminar" runat="server"
                                            CommandArgument='<%# Eval("cod_marca") %>'
                                            OnClientClick="return confirm('Esta seguro de eliminar la marca?')" OnClick="lkb_eliminar_Click">Eliminar</asp:LinkButton>
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
