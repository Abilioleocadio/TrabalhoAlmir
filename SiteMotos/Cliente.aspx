<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="Cliente.aspx.cs" Inherits="Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style18 {
            color: #000066;
            font-size: x-large;
        }
        .auto-style19 {
            text-align: center;
        }
    .auto-style20 {
        text-align: right;
    }
    .auto-style21 {
        width: 100%;
        margin-top: 3px;
    }
    .auto-style22 {
        width: 76px;
    }
    .auto-style23 {
        width: 298px;
    }
        .auto-style24 {
            width: 127px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style19">
        <span class="auto-style18"><strong>Cliente</strong></span><br />
    </p>
    <p>
        &nbsp;</p>
    <p class="auto-style20">
        <asp:HyperLink ID="HyperLink1" runat="server" EnableTheming="True" NavigateUrl="~/Home.aspx">Voltar</asp:HyperLink>
    </p>
    <div>
        <asp:GridView ID="grvCliente" CssClass="table" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" HorizontalAlign="Center" OnPageIndexChanging="grvCliente_PageIndexChanging" OnRowCommand="grvCliente_RowCommand" CellSpacing="2" Height="147px" DataKeyNames="codigoCliente" DataSourceID="sqlCliente">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="codigoCliente" HeaderText="codigoCliente" ReadOnly="True" SortExpression="codigoCliente" />
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                <asp:BoundField DataField="celular" HeaderText="celular" SortExpression="celular" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="nascimento" HeaderText="nascimento" SortExpression="nascimento" />
                <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" />
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
        <asp:SqlDataSource ID="sqlCliente" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
    </div>
    <table class="auto-style21">
        <tr>
            <td class="auto-style22"><strong>ID:</strong></td>
            <td class="auto-style23">
                <asp:Label ID="lblID" runat="server"></asp:Label>
            </td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnInserir" runat="server" CssClass="btn btn-primary" Text="Inserir" Width="100px" OnClick="btnInserir_Click" style="height: 26px" />
                </strong></td>
            <td class="auto-style19">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"><strong>Nome:</strong></td>
            <td class="auto-style23">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server" Width="272px"></asp:TextBox>
            </td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar" Width="100px" OnClick="btnEditar_Click" />
                </strong></td>
            <td class="auto-style19">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"><strong>Celular:</strong></td>
            <td class="auto-style23">
                <asp:TextBox ID="txtCelular" CssClass="form-control" runat="server" Width="136px"></asp:TextBox>
            </td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnRemover" runat="server" CssClass="btn btn-danger" Text="Remover" Width="100px" OnClick="btnRemover_Click" />
                </strong></td>
            <td class="auto-style19">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"><strong>Email:</strong></td>
            <td class="auto-style23">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="268px"></asp:TextBox>
            </td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnGravar" runat="server" CssClass="btn btn-primary" Text="Gravar" Width="100px" OnClick="btnGravar_Click" />
                </strong></td>
            <td class="auto-style19">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"><strong>Nascimento:</strong></td>
            <td class="auto-style23">
                <asp:TextBox ID="txtNascimento" runat="server" CssClass="form-control" Width="109px"></asp:TextBox>
            </td>
            <td class="auto-style24"><strong>
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" Width="100px" OnClick="btnCancelar_Click" />
                </strong></td>
            <td class="auto-style19">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22"><strong>CPF:</strong></td>
            <td class="auto-style23">
                <asp:TextBox ID="txtCpf" runat="server"  CssClass="form-control" Width="137px"></asp:TextBox>
            </td>
            <td class="auto-style24" rowspan="5">&nbsp;</td>
            <td class="auto-style19">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td><strong>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
</table>
    </p>
</asp:Content>

