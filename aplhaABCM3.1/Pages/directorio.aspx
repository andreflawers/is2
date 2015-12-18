<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Principal.Master" AutoEventWireup="true" CodeBehind="directorio.aspx.cs" Inherits="aplhaABCM3._1.Pages.directorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-10">
                    <h1 class="text-center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Directorio</h1>
                <div class="col-md-6">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <asp:Label runat="server" Text="Categoria:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpCategoria" runat="server" CssClass="form-control" Width="180px" ></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnCate" runat="server" Text="..." OnClick="btnCate_Click" CssClass="btn btn-warning" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" Text="Clase:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpClase" runat="server" CssClass="form-control" Width="180px"></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnClase" runat="server" Text="..." OnClick="btnClase_Click" CssClass="btn btn-warning" /></div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" Text="Tipo:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpTipoProducto" runat="server" CssClass="form-control" Width="180px"></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnTipoProducto" runat="server" Text="..." OnClick="btnTipoProducto_Click" CssClass="btn btn-warning" /></div>
                            </div>
                        </div>
                    </div>
                </div> 
                <div class="col-md-6">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <asp:Label runat="server" Text="Marca:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpMarca" runat="server" CssClass="form-control" Width="180px"></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnMarca" runat="server" Text="..." OnClick="btnMarca_Click" CssClass="btn btn-warning" /></div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" Text="Modelo:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpModelo" runat="server" CssClass="form-control" Width="180px"></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnModelo" runat="server" Text="..." OnClick="btnModelo_Click" CssClass="btn btn-warning" /></div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" Text="Unidad:" CssClass="col-md-6 control-label text-right" Font-Size="24px"></asp:Label>
                            <div class="form-inline">
                                <asp:DropDownList ID="drpUnidad" runat="server" CssClass="form-control" Width="180px"></asp:DropDownList>
                                <div class="pull-right">
                                    <asp:Button ID="btnUnidad" runat="server" Text="..." OnClick="btnUnidad_Click" CssClass="btn btn-warning" /></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div >
            <div class="col-md-offset-5 col-md-2">
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success btn-block" Height="50px" Text="Ir a Producto" OnClick="Button1_Click" /></div>
            </div> 
    </div>
















    >
 
















                                        




  


                                    
                                        

                                       
                                
                          
                         
                         

                                
                                        
                                  




</asp:Content>
