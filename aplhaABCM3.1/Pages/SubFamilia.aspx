<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubFamilia.aspx.cs" Inherits="WebApplicationFamilia.SubFamilia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Buttoninsertar" runat="server" Text="Insertar" BackColor="Window" Width="132px" OnClick="Buttoninsertar_Click" />
        <asp:Panel ID="PanelSubFamilia" runat="server" BackColor="Window" GroupingText="Mantenimiento SubFamilia" Visible="false">
            <br />
            <asp:Label ID="Label7" runat="server" Text="id_Empresa"></asp:Label>
            <asp:DropDownList ID="DropDownListid_Familia" runat="server" BackColor="Window">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Cod_iso_idio"></asp:Label>
            <asp:DropDownList ID="DropDownListcod" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Codigo_Categoria"></asp:Label>
            <asp:DropDownList ID="DropDownListcategoria" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Codigo_Clase" BackColor="Window" ></asp:Label>
            :<asp:TextBox ID="TextBoxid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Abrv" BackColor="Window"></asp:Label>
            :<asp:TextBox ID="TextBoxNommbreSub" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Desc"></asp:Label>
            :<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Buttonaceptar" runat="server" style="margin-left: 56px" BackColor="Window" Width="100px" Text="Aceptar" OnClick="Buttonaceptar_Click" />
            <asp:Button ID="Buttonimpiar" runat="server" style="margin-left: 56px" BackColor="Window" Width="100px" Text="Limpiar" OnClick="Buttonimpiar_Click" />
            <asp:Button ID="Buttoncancelar" runat="server" style="margin-left: 56px" BackColor="Window" Width="100px" Text="Cancelar" OnClick="Buttoncancelar_Click" />
            <asp:Button ID="ButtonNuevo" runat="server" style="margin-left: 56px" Text="Nuevo" BackColor="Window" Width="100px" OnClick="ButtonNuevo_Click" />
            <br />
            <br />
        </asp:Panel>

    </div>
        
        <br />
        <asp:Button ID="Buttonbuscar" runat="server" Text="Buscar" BackColor="Window" Width="82px" OnClick="Buttonbuscar_Click" />
        <asp:TextBox ID="TextBox4" runat="server" Width="308px"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="GridViewSubFamilia" runat="server" AutoGenerateColumns="False"  DataKeyNames="cod_clase" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowCancelingEdit="GridViewSubFamilia_RowCancelingEdit" OnRowDeleting="GridViewSubFamilia_RowDeleting" OnRowEditing="GridViewSubFamilia_RowEditing" OnRowUpdating="GridViewSubFamilia_RowUpdating" OnSelectedIndexChanging="GridViewSubFamilia_SelectedIndexChanging"   >
            <Columns>
                <asp:TemplateField HeaderText="id_Empresa">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_empresa") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_empresa") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_iso_isio">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cod_Categoria">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("cod_cate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("cod_cate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Codigo_Clase">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("cod_clase") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("cod_clase") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Abrv">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Desc">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("txt_desc") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("txt_desc") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowEditButton="True"  />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
