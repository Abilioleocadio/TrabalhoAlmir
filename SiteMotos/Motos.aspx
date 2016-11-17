<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true" CodeFile="Motos.aspx.cs" Inherits="Motos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
    .auto-style18 {
        text-align: center;
    }
    .auto-style19 {
        font-size: x-large;
    }
    .auto-style27 {
        width: 100%;
        height: 199px;
    }
    .auto-style29 {
            width: 294px;
        }
    .auto-style30 {
            width: 176px;
        }
    .auto-style31 {
        width: 157px;
    }
    .auto-style32 {
        width: 157px;
        height: 13px;
    }
    .auto-style33 {
        width: 294px;
        height: 13px;
    }
    .auto-style34 {
        width: 176px;
        height: 13px;
            text-align: center;
        }
    .auto-style35 {
            height: 13px;
        }
        .auto-style36 {
            width: 176px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style18">
    <strong>
    <span class="auto-style19">MOTOS</span></strong></p>
<p>
    <asp:SqlDataSource ID="sqlMotos" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [idCliente], [codigoMoto], [motoMarca], [situacao], [motoModelo], [anoMoto] FROM [Motos]"></asp:SqlDataSource>
</p>
<p>
</p>
    <asp:GridView ID="grvMotos" runat="server" CssClass="table" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Bottom" CellPadding="3" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="codigoMoto" DataSourceID="sqlMotos" OnPageIndexChanging="grvMotos_PageIndexChanging1" OnRowCommand="grvMotos_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="codigoMoto" HeaderText="ID Moto" SortExpression="codigoMoto" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="motoMarca" HeaderText="Marca" SortExpression="motoMarca" />
            <asp:BoundField DataField="situacao" HeaderText="Situação" SortExpression="situacao" />
            <asp:BoundField DataField="idCliente" HeaderText="ID Cliente" SortExpression="idCliente" />
            <asp:BoundField DataField="motoModelo" HeaderText="Modelo" SortExpression="motoModelo" />
            <asp:BoundField DataField="anoMoto" HeaderText="Ano" SortExpression="anoMoto" />
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
    <p>
        <table class="auto-style27">
            <tr>
                <td class="auto-style32"><strong>ID:</strong></td>
                <td class="auto-style33">
                    <asp:Label ID="lblID" runat="server"></asp:Label>
                </td>
                <td class="auto-style34"><strong>
                    <asp:Button ID="btnInserir" runat="server" CssClass="btn btn-primary" Text="Inserir" Width="90px" Height="50px" OnClick="btnInserir_Click" />
                    </strong></td>
                <td class="auto-style35"></td>
                <td class="auto-style35"></td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>Marca:</strong></td>
                <td class="auto-style29">
                    <asp:TextBox ID="txtMarca" CssClass="form-control" runat="server" Width="130px" Height="20px"></asp:TextBox>
                </td>
                <td class="auto-style36"><strong>
                    <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-primary" Text="Editar" Width="90px" OnClick="btnEditar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>Situação:</strong></td>
                <td class="auto-style29">
                    <asp:TextBox ID="txtSituacao" CssClass="form-control" runat="server" Height="20px" Width="46px"></asp:TextBox>
                </td>
                <td class="auto-style36"><strong>
                    <asp:Button ID="btnRemover" runat="server" CssClass="btn btn-danger" Text="Remover" Width="90px" OnClick="btnRemover_Click" />
                    </strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>Cliente:</strong></td>
                <td class="auto-style29">
                    <asp:DropDownList ID="ddlIDCliente" runat="server" DataSourceID="SqlDataSource1" DataTextField="nome" DataValueField="codigoCliente" Width="118px">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style36"><strong>
                    <asp:Button ID="btnGravar" runat="server" CssClass="btn btn-primary" Text="Gravar" Width="90px" OnClick="btnGravar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>Modelo:</strong></td>
                <td class="auto-style29">
                    <asp:TextBox ID="txtModelo" CssClass="form-control" runat="server" Height="20px" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style36"><strong>
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" Width="90px" OnClick="btnCancelar_Click" />
                    </strong></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style31"><strong>Ano:</strong></td>
                <td class="auto-style29">
                    <asp:TextBox ID="txtAno" CssClass="form-control" runat="server" Height="20px" Width="100px"></asp:TextBox>
                </td>
                <td class="auto-style30"><strong></strong></td>
                <td>&nbsp;</td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoCliente], [nome], [celular], [email], [nascimento], [cpf] FROM [Cliente]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
</p>
    <p>
        &nbsp;</p>
</asp:Content>

