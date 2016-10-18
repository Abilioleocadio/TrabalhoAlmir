<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="Pecas.aspx.cs" Inherits="Pecas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
    .auto-style18 {
        font-size: x-large;
        color: #0000FF;
    }
    .auto-style19 {
        text-align: center;
    }
        .auto-style20 {
            height: 26px;
        }
        .auto-style21 {
            height: 26px;
            width: 108px;
        }
        .auto-style22 {
            width: 108px;
        }
        .auto-style23 {
            height: 26px;
            width: 207px;
        }
        .auto-style24 {
            width: 207px;
        }
        .auto-style25 {
            margin-left: 0px;
        }
        .auto-style26 {
            height: 26px;
            width: 120px;
        }
        .auto-style27 {
            width: 120px;
        }
        .auto-style28 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style19">
    <strong><span class="auto-style18">Peças</span></strong><br />
</p>
<p>
    <asp:SqlDataSource ID="sqlPecas" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoPecas], [nome], [anoPeca], [quantidade], [preco] FROM [Pecas]"></asp:SqlDataSource>
</p>
<p class="auto-style19">
    <asp:GridView ID="grvPecas" CssClass="table" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="codigoPecas" DataSourceID="sqlPecas" OnPageIndexChanging="grvPecas_PageIndexChanging" OnRowCommand="grvPecas_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="codigoPecas" HeaderText="ID:" InsertVisible="False" ReadOnly="True" SortExpression="codigoPecas" />
            <asp:BoundField DataField="nome" HeaderText="Nome:" SortExpression="nome" />
            <asp:BoundField DataField="anoPeca" HeaderText="Data:" SortExpression="anoPeca" />
            <asp:BoundField DataField="quantidade" HeaderText="Quantidade" SortExpression="quantidade" />
            <asp:BoundField DataField="preco" HeaderText="Preço" SortExpression="preco" />
            <asp:CommandField ButtonType="Button" SelectText="Selecionar" ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</p>
    <p class="auto-style19">
        <table style="width:100%;">
            <tr>
                <td class="auto-style21">ID:</td>
                <td class="auto-style23">
                    <asp:Label ID="lblID" runat="server"></asp:Label>
                </td>
                <td class="auto-style26"><strong>
                    <asp:Button ID="btnInserir" runat="server" CssClass="btn btn-primary" Height="25px" Text="Inserir" Width="100px" OnClick="btnInserir_Click" />
                    </strong></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style22">Nome:</td>
                <td class="auto-style24">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style27"><strong>
                    <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Height="25px" Text="Editar" Width="100px" OnClick="btnEditar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">Data:</td>
                <td class="auto-style24">
                    <asp:TextBox ID="txtAno" CssClass="form-control" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style27"><strong>
                    <asp:Button ID="btnRemover" runat="server" CssClass="btn btn-danger" Height="25px" Text="Remover" Width="100px" OnClick="btnRemover_Click" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">Quantidade:</td>
                <td class="auto-style24">
                    <asp:TextBox ID="txtQuantidade" CssClass="form-control" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style27"><strong>
                    <asp:Button ID="btnGravar" runat="server" CssClass="btn btn-primary" Height="25px" Text="Gravar" Width="100px" OnClick="btnGravar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">Preço:</td>
                <td class="auto-style24">
                    <asp:TextBox ID="txtPreco" CssClass="form-control" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style27"><strong>
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Height="25px" Text="Cancelar" Width="100px" OnClick="btnCancelar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style27">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</p>
    <p class="auto-style19">
        &nbsp;</p>
</asp:Content>

