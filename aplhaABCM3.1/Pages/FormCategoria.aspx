<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="FormCategoria.aspx.cs" Inherits="aplhaABCM3._1.Pages.FormCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script>
        $(function () {
            $("#div_modal01").dialog({
                autoOpen: false,
                height: 400,
                width: 300,
                modal: true,
                resizable: false
            });
        });
        function Mostrar_Ventana_Modal() {  //Ingresa en la propiedad titulo
            $("#div_modal01").dialog("open");  //Abre la ventana modal
            
            return false    //Se debe quedar en el cliente no debe ir al servidor
        }
        <%--document.getElementById('<%=txt_cambio_efectivo.ClientID%>').value = parseFloat(document.getElementById('<%=txt_cantidad_efectivo.ClientID%>').value)-parseFloat(document.getElementById('<%=txt_recibido_efectivo.ClientID%>').value);
        --%>
        
    </script>
    <script type ="text/javascript">
        function Cerrar()
        {
            $("#div_modal01").dialog("close");
        }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 well">
                <table width="700px" class="left">
                    <tr>
                        <td align="center">
                            <h1>Lista de Categorias</h1>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Label ID="lbl_mesg_01" runat="server" Text="" CssClass="text_error"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:LinkButton ID="lkb_nueva_categoria" runat="server" OnClientClick="return Mostrar_Ventana_Modal" OnClick="lkb_nueva_categoria_Click">Registrar nueva categoria</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:Panel ID="Panel_mant_cate" Width="550px" CssClass="panel panel-default" runat="server">
                                <table width="100%">
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="lbl_titulo" runat="server" Text="" CssClass="text-center" Font-Size="X-Large"></asp:Label>
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
                                                        <h5 class="text-right">Código de la categiría : </h5>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lbl_cod_cate" runat="server" Text=""></asp:Label>
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
                                                        <h5 class="text-right">Abreviatura : </h5>
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
                                            <br />
                                        </td>
                                    </tr>

                                </table>

                            </asp:Panel>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <br />
                            <asp:GridView ID="grd_cate" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" GridLines="None" UseAccessibleHeader="true">
                                <Columns>
                                    <asp:BoundField DataField="cod_cate" HeaderText="Codigo de la categoria" />
                                    <asp:BoundField DataField="txt_abrv" HeaderText="Abreviatura" />
                                    <asp:BoundField DataField="txt_desc" HeaderText="Descripcion" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkb_editar" runat="server" CommandArgument='<%# Eval("cod_cate") %>' OnClick="lkb_editar_Click">Editar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkb_eliminar" runat="server"
                                                CommandArgument='<%# Eval("cod_cate") %>'
                                                OnClientClick="return confirm('Esta seguro de eliminar el modelo?')" OnClick="lkb_eliminar_Click">Eliminar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>

                </table>
                <div class="col-md-12 well">
                    <!-- Button trigger modal -->
                    <asp:Button Text="text" CssClass="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal" runat="server"  ID="myInput"/>
                    <!-- Modal -->
                    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                        <div class="modal-backdrop" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="myModalLabel">Modal title</h4>
                                </div>
                                <div class="modal-body">
                                    ...
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                    <button type="button" class="btn btn-primary">Save changes</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
