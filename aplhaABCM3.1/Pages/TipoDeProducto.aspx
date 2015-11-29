<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TipoDeProducto.aspx.cs" Inherits="WebApplicationFamilia.TipoDeProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="PanelTipo" GroupingText="Mantenimiento Tipo de Producto" runat="server">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Id_Empresa"></asp:Label>
            <asp:DropDownList ID="DropDownListidempresa" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cod_iso_idio"></asp:Label>
            <asp:DropDownList ID="DropDownListcod_iso" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Codigo_Categoria"></asp:Label>
            <asp:DropDownList ID="DropDownListcategoria" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Codigo_Clase"></asp:Label>
            <asp:DropDownList ID="DropDownListclase" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Codigo_Tipo"></asp:Label>
            <asp:TextBox ID="TextBoxcod_tipo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Abvr"></asp:Label>
            <asp:TextBox ID="TextBoxabvr" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Desc"></asp:Label>
            <asp:TextBox ID="TextBoxdesc" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonAcpetar" runat="server" style="margin-left: 56px" Text="Aceptar" Width="90px" OnClick="ButtonAcpetar_Click" />
            <asp:Button ID="ButtonLimpiar" runat="server" Text="Limpiar" style="margin-left: 56px" Width="90px" />
            <asp:Button ID="Buttoncancelar" runat="server" Text="Cancelar" style="margin-left: 56px" Width="90px" />
            <asp:Button ID="Buttonnuevo" runat="server" style="margin-left: 56px" Width="90px" Text="Nuevo" />
            <br />
            <br />
        </asp:Panel>
    </div>

        <br />

        <asp:GridView ID="GridViewTipoProducto" runat="server" DataKeyNames="cod_tipo" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" OnRowDeleting="GridViewTipoProducto_RowDeleting" OnRowCancelingEdit="GridViewTipoProducto_RowCancelingEdit" OnRowEditing="GridViewTipoProducto_RowEditing" OnRowUpdating="GridViewTipoProducto_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="Id_Empresa">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_empresa") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_empresa") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_iso_idio">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_Categoria">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("cod_cate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("cod_cate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_Clase">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("cod_clase") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("cod_clase") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_Tipo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("cod_tipo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("cod_tipo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Abrv">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("txt_desc") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("txt_desc") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>

    </form>
    
</body>
</html>
