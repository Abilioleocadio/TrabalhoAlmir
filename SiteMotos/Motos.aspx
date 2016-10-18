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
        .auto-style37 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style18">
    <strong>
    <span class="auto-style19">MOTOS</span></strong></p>
<p>
    <asp:SqlDataSource ID="sqlMotos" runat="server" ConnectionString="<%$ ConnectionStrings:MOTOSConnectionString %>" SelectCommand="SELECT [codigoMoto], [anoMoto], [situacao], [idCliente], [motoMarca], [motoModelo] FROM [Motos]"></asp:SqlDataSource>
</p>
<p>
</p>
    <asp:GridView ID="grvMotos" runat="server" CssClass="table" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CaptionAlign="Bottom" CellPadding="3" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" DataKeyNames="codigoMoto" DataSourceID="sqlMotos" OnPageIndexChanging="grvMotos_PageIndexChanging1" OnRowCommand="grvMotos_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="codigoMoto" HeaderText="codigoMoto" ReadOnly="True" SortExpression="codigoMoto" InsertVisible="False" />
            <asp:BoundField DataField="anoMoto" HeaderText="anoMoto" SortExpression="anoMoto" />
            <asp:BoundField DataField="situacao" HeaderText="situacao" SortExpression="situacao" />
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" />
            <asp:BoundField DataField="motoMarca" HeaderText="motoMarca" SortExpression="motoMarca" />
            <asp:BoundField DataField="motoModelo" HeaderText="motoModelo" SortExpression="motoModelo" />
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
                    <asp:TextBox ID="txtIDCliente" CssClass="form-control" runat="server" Height="20px" Width="74px"></asp:TextBox>
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
                <td>&nbsp;</td>
            </tr>
        </table>
</p>
    <p>
        &nbsp;</p>
</asp:Content>

