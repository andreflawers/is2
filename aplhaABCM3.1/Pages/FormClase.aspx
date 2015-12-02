<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FormClase.aspx.cs" Inherits="aplhaABCM3._1.Pages.FormClase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="700px" align="center">
        <tr>
            <td align="center">
                <h1>Lista de Clases</h1>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:LinkButton ID="lkb_nueva_clase" runat="server" OnClick="lkb_nueva_clase_Click"   >Registrar nueva clase</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Panel ID="Panel_mant_clase" Width="550px" BorderStyle="Solid" BorderWidth="1" runat="server">
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
                                   <td>Categoria:</td>
                                   <td>
                                       <asp:DropDownList ID="drp_cate" runat="server"></asp:DropDownList>
                                   </td>
                               </tr>
                               <tr>
                                   <td>Codigo de la clase:</td>
                                   <td>
                                       <asp:Label ID="lbl_cod_clase" runat="server" Text=""></asp:Label>
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
                <asp:GridView ID="grd_clase" Width="100%" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        
                        <asp:BoundField DataField="cod_clase" HeaderText="Codigo de la clase" />
                        <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                        <asp:BoundField DataField="txt_desc" HeaderText="Descripcion de l clase" />
                        <asp:BoundField DataField="d" HeaderText="Descripcion de la categoria" />
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
            </td>
        </tr>

    </table>
</asp:Content>
