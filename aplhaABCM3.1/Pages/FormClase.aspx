<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FormClase.aspx.cs" Inherits="aplhaABCM3._1.Pages.FormClase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-md-12">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="col-md-push-1 col-md-10">
                    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Lista de Clases</h1>
                    <div class="col-md-10">
                        <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
                        <asp:Button ID="Button1" runat="server" Text="" Height="1px" BackColor="#F6F6F6" BorderColor="#F3F3F3" BorderStyle="None" />
                        <asp:LinkButton ID="lkb_nueva_clase" runat="server" OnClick="lkb_nueva_clase_Click">Registrar nueva clase</asp:LinkButton>
                        <asp:Panel ID="Panel_mant_clase" Width="550px" CssClass="panel panel-default" runat="server">
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
                                   <td><h5 class="text-right">Categoría : </h5></td>
                                   <td>
                                       <asp:DropDownList ID="drp_cate" runat="server" Width="200px" CssClass="btn btn-default dropdown-toggle"></asp:DropDownList>
                                   </td>
                               </tr>
                               <tr>
                                   <td><h5 class="text-right">Código de la clase : </h5></td>
                                   <td>
                                       <asp:TextBox ID="txt_cod_clase" Width="200px" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
                                   </td>
                               </tr>
                               <tr>
                                   <td><h5 class="text-right">Abreviatura : </h5>:</td>
                                   <td>
                                       <asp:TextBox ID="txt_txt_abrv" Width="200px" runat="server" CssClass="form-control"></asp:TextBox>
                                   </td>
                               </tr>
                               <tr>
                                   <td><h5 class="text-right">Descripción : </h5></td>
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
                           <asp:Button ID="btn_grabar" runat="server" Text="Grabar" OnClick="btn_grabar_Click" CssClass="btn btn-success"   />&nbsp
                           <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" CssClass="btn btn-danger"  />
                       </td>
                   </tr>

               </table>

            </asp:Panel>
                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                            PopupControlID="Panel_mant_clase"
                            TargetControlID="Button1" Enabled="true" DropShadow="true"
                            BackgroundCssClass="modalBackground">
                        </ajaxToolkit:ModalPopupExtender>
                    </div>
                    <div class="col-md-12">
                        <asp:GridView ID="grd_clase" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" GridLines="None" UseAccessibleHeader="true" >
                    <Columns>
                        <asp:BoundField DataField="cod_cate" HeaderText="Codigo de la categoria" />
                        <asp:BoundField DataField="d" HeaderText="Descripcion de la categoria" />
                        <asp:BoundField DataField="cod_clase" HeaderText="Codigo de la clase" />
                        <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                        <asp:BoundField DataField="txt_desc" HeaderText="Descripcion de la clase" />
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("cod_clase") %>' OnClick="lkb_editar_Click"  >Editar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_eliminar" runat="server" 
                                    CommandArgument='<%# Eval("cod_clase") %>' 
                                     OnClientClick="return confirm('Esta seguro de eliminar la clase?')" OnClick="lkb_eliminar_Click" >Eliminar</asp:LinkButton>
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
