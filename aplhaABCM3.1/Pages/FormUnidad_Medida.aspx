<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FormUnidad_Medida.aspx.cs" Inherits="aplhaABCM3._1.Pages.FormUnidad_Medida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="700px" align="center">
        <tr>
            <td align="center">
                <h1>Lista de Modelos</h1>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="lkb_nueva_modelo" runat="server" OnClick="lkb_nueva_modelo_Click" >Registrar nuevo modelo</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Panel ID="Panel_mant_um" Width="550px" BorderStyle="Solid" BorderWidth="1" runat="server">
               <table width="100%">
                   <tr>
                       <td align="center">
                           <asp:Label ID="lbl_titulo" runat="server" Text=""></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <table width="100%">
                               <tr>
                                   <td>Código de la empresa:</td>
                                   <td>
                                       <asp:TextBox ID="txt_id_empresa" Width="200px" runat="server"></asp:TextBox>
                                   </td>
                               </tr>
                              <tr>
                                   <td>Codigo de la unidad:</td>
                                   <td>
                                       <asp:Label ID="lbl_cod_um" runat="server" Text=""></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td>Abreviatura:</td>
                                   <td>
                                       <asp:TextBox ID="txt_txt_abrv" Width="200px" runat="server"></asp:TextBox>
                                   </td>
                               </tr>
                               <tr>
                                   <td>descripcion:</td>
                                   <td>
                                       <asp:TextBox ID="txt_txt_desc" Width="200px" runat="server"></asp:TextBox>
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
                           <asp:Button ID="btn_grabar" runat="server" Text="Grabar" OnClick="btn_grabar_Click"    />&nbsp
                           <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click"  />
                       </td>
                   </tr>

               </table>

            </asp:Panel>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grd_um" Width="100%" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:BoundField DataField="cod_um" HeaderText="Codigo de la unidad de medida" />
                        <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                        <asp:BoundField DataField="txt_desc" HeaderText="Descripcion" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("cod_um") %>' OnClick="lkb_editar_Click"  >Editar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_eliminar" runat="server" 
                                    CommandArgument='<%# Eval("cod_um") %>' 
                                     OnClientClick="return confirm('Esta seguro de eliminar la unidad de medida?')" OnClick="lkb_eliminar_Click" >Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

    </table>
</asp:Content>
