<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Familia.aspx.cs" Inherits="WebApplicationFamilia.Familia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button  ID="Buttoninsertar" runat="server"  BackColor="Window"   Text="Insertar Familia" Width="120px" OnClick="Buttoninsertar_Click" />
        <br />
        <asp:Panel ID="Panel1" GroupingText="Mantenimiento de Categoria" BackColor="Window"  Font-Bold="true" runat="server" Visible="false">
            
                <br />
                <asp:Label ID="Label5" runat="server" Text="id_Empresa"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Cod_iso_idio"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
            
                <br />
            
                <asp:Label ID="Labelidfamilia" runat="server" Text="Codigo_Categoria"></asp:Label>
            <asp:TextBox ID="TextBoxidfamilia" runat="server"></asp:TextBox>
                <br />
              <br />
            <asp:Label ID="Labelnombre" runat="server" Text="Abreviatura"></asp:Label>
            <asp:TextBox ID="TextBoxnombre" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxnombre" ErrorMessage="Solo letras" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                <br />
                <br />
                <asp:Label ID="Labeldesc" runat="server" Text="Descripcion"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Buttonaceptar" runat="server" style="margin-left: 50px" Text="Aceptar" Width="75px" BackColor="Window"  OnClick="Buttonaceptar_Click" />
                <asp:Button ID="Buttonlimpiar" runat="server" style="margin-left: 50px" Text="Limpiar" Width="75px" BackColor="Window" OnClick="Buttonlimpiar_Click" />
                <asp:Button ID="Buttoncancelar" runat="server" style="margin-left: 50px" Text="Cancelar" Width="75px" BackColor ="Window" OnClick="Buttoncancelar_Click" />
                <asp:Button ID="ButtonNuevo" runat="server" style="margin-left: 50px" Text="Nuevo" Width="75px" BackColor="Window" OnClick="ButtonNuevo_Click" />
                <br />
              <br />
            
        </asp:Panel>
         <br />
        <asp:Button ID="Btn_buscar"  BackColor="Window"  runat="server" Text="Buscar" Width="90px" OnClick="Btn_buscar_Click" />
         <asp:TextBox ID="TextBoxbuscar" runat="server" Width="462px"></asp:TextBox>
         <br />
              <br />
        <asp:GridView ID="GridViewFamilia" runat="server" HorizontalAlign="Center"  DataKeyNames="cod_cate"  OnRowEditing="GridViewFamilia_RowEditing" OnRowUpdating="GridViewFamilia_RowUpdating" OnRowCancelingEdit="GridViewFamilia_RowCancelingEdit" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnRowDeleting="GridViewFamilia_RowDeleting" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:TemplateField HeaderText="id_Empresa">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("id_empresa") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("id_empresa") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Codigo_iso_idio">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("cod_iso_idio_orgn") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Codigo_categoria">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxid" runat="server" Text='<%# Bind("cod_cate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Labelid" runat="server" Text='<%# Bind("cod_cate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Abreviatura">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("txt_abrv") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripcion">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("txt_desc") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("txt_desc") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </div>
    </form>
    
</body>
</html>
