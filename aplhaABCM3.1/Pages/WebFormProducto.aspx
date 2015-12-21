<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="WebFormProducto.aspx.cs" Inherits="aplhaABCM3._1.Pages.WebFormProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8">
                <asp:Panel ID="panelBusAvanzada"  runat="server" Visible="false">
                    
                </asp:Panel>
                <br />
                <%--<asp:Button ID="btn_BusquedadAvanzada" runat="server" Text="Busquedad Avanzada" Cssclass="btn btn-primary btn-warning" />--%>
                <br />
                <br>
                <div >
                    <asp:Button ID="btn_buscar" runat="server" Text="Buscar" OnClick="btn_buscar_Click" />
                    <asp:TextBox ID="txtbuscarid"  PlaceHolder="Colocar el ID" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtbuscardescripcion"  PlaceHolder="Colocar la Descripcion" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:GridView ID="grd_Producto" Width="100%" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" UseAccessibleHeader="true" GridLines="None" >
                    <Columns>
                        <asp:BoundField DataField="id_producto" HeaderText="ID Producto" />
                        <asp:BoundField DataField="Categoria" HeaderText="Categoria" />
                        <asp:BoundField DataField="Clase" HeaderText="Clase" />
                        <asp:BoundField DataField="Tipo_Producto" HeaderText="Tipo de Producto" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                        <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lkb_eliminar" runat="server" 
                                    CommandArgument='<%# Eval("id_producto") %>' 
                                     OnClientClick="return confirm('Esta seguro de eliminar el producto?')" OnClick="lkb_eliminar_Click" >Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                    <br />
                    <asp:Label ID="lbl_mesg_01" runat="server" Text="Label" Visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
