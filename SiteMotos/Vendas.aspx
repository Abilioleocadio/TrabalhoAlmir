<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="Vendas.aspx.cs" Inherits="Vendas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
    .auto-style19 {
        text-align: center;
    }
    .auto-style20 {
        font-size: x-large;
        color: #3333FF;
    }
        .auto-style21 {
            width: 58px;
        }
        .auto-style22 {
            width: 58px;
            text-align: right;
        }
        .auto-style23 {
            width: 174px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style19">
        <strong><span class="auto-style20">Vendas</span></strong><br />
</p>
<p>
    <asp:SqlDataSource ID="sqlVendas" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoVenda], [idCliente], [idPecas], [idMoto], [quantidade] FROM [VendaPecas]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlMoto" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [motoMarca], [codigoMoto], [situacao], [idCliente], [motoModelo], [anoMoto] FROM [Motos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlCliente" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoCliente], [nome], [celular], [email], [nascimento], [cpf] FROM [Cliente]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlPeca" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoPecas], [nome], [anoPeca], [quantidade], [preco] FROM [Pecas]"></asp:SqlDataSource>
</p>
<p class="auto-style19">
    <asp:GridView ID="grvVendas" CssClass="table" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="codigoVenda" DataSourceID="sqlVendas" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" OnPageIndexChanging="grvVendas_PageIndexChanging" OnRowCommand="grvVendas_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="codigoVenda" HeaderText="codigoVenda" InsertVisible="False" ReadOnly="True" SortExpression="codigoVenda" />
            <asp:BoundField DataField="idPecas" HeaderText="idPecas" SortExpression="idPecas" />
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" />
            <asp:BoundField DataField="idMoto" HeaderText="idMoto" SortExpression="idMoto" />
            <asp:BoundField DataField="quantidade" HeaderText="quantidade" SortExpression="quantidade" />
            <asp:CommandField ButtonType="Button" SelectText="Selecionar" ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    </p>
<p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style22">ID:</td>
            <td class="auto-style23">
                <asp:Label ID="lblID" runat="server"></asp:Label>
            </td>
            <td><strong>
                <asp:Button ID="btnInserir" runat="server" CssClass="btn btn-primary" Text="Inserir" Width="90px" OnClick="btnInserir_Click" />
                </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">Cliente:</td>
            <td class="auto-style23">
                <asp:DropDownList ID="ddlCliente" runat="server" DataSourceID="sqlCliente" DataTextField="nome" DataValueField="codigoCliente" Width="120px">
                </asp:DropDownList>
            </td>
            <td><strong>
                <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar" Width="90px" OnClick="btnEditar_Click" />
                </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">Peça:</td>
            <td class="auto-style23">
                <asp:DropDownList ID="ddlPeca" runat="server" DataSourceID="sqlPeca" DataTextField="nome" DataValueField="codigoPecas" Width="120px" Height="16px">
                </asp:DropDownList>
            </td>
            <td><strong>
                <asp:Button ID="btnRemover" runat="server" CssClass="btn btn-danger" Text="Remover" Width="90px" OnClick="btnRemover_Click" />
                </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">Moto:</td>
            <td class="auto-style23">
                <asp:DropDownList ID="ddlMoto" runat="server" DataSourceID="sqlMoto" DataTextField="motoModelo" DataValueField="codigoMoto" Width="120px">
                </asp:DropDownList>
            </td>
            <td><strong>
                <asp:Button ID="btnVender" runat="server" CssClass="btn btn-primary" Text="Vender" Width="90px" OnClick="btnVender_Click" />
                </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">Quantidade:</td>
            <td class="auto-style23">
                <asp:TextBox ID="txtQuantidade" runat="server" Width="100px"></asp:TextBox>
            </td>
            <td><strong>
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" Width="90px" OnClick="btnCancelar_Click" />
                </strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
</asp:Content>

