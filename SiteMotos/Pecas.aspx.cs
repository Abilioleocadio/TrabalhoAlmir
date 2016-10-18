using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pecas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Locadora.Camadas.BLL.Pecas bllPecas = new Locadora.Camadas.BLL.Pecas();
            grvPecas.DataBind();

            Cache["OP"] = "X";
            habilitarcampos(false);
        }
    }

    protected void habilitarcampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            lblID.Text = "";
            txtNome.Text = "";
            txtAno.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        txtNome.Enabled = status;
        txtAno.Enabled = status;
        txtQuantidade.Enabled = status;
        txtPreco.Enabled = status;

        btnInserir.Enabled = !status;
        btnEditar.Enabled = !status;
        btnRemover.Enabled = !status;
        btnGravar.Enabled = status;
        btnCancelar.Enabled = status;
    }

    protected void btnInserir_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "I";
        habilitarcampos(true);
        lblID.Text = "-1";
        txtNome.Focus();
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvPecas_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Locadora.Camadas.BLL.Pecas bllPecas = new Locadora.Camadas.BLL.Pecas();
        grvPecas.PageIndex = e.NewPageIndex;
        grvPecas.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Locadora.Camadas.BLL.Pecas bllPecas = new Locadora.Camadas.BLL.Pecas();
        Locadora.Camadas.MODEL.Pecas pecas = new Locadora.Camadas.MODEL.Pecas();
        pecas.codigoPecas = Convert.ToInt32(lblID.Text);
        pecas.nome = txtNome.Text;
        pecas.anoPeca = txtAno.Text;
        pecas.quantidade = Convert.ToInt32(txtQuantidade.Text);
        pecas.preco = Convert.ToSingle(txtPreco.Text);

        if (Cache["OP"].ToString() == "I")
        {
            bllPecas.Insert(pecas);
        }
        else
        {
            if (Cache["OP"].ToString() == "E")
            {
                bllPecas.UpDate(pecas);
            }
        }

        grvPecas.DataBind();

        if (Cache["OP"].ToString() == "I")
        {
            grvPecas.SetPageIndex(grvPecas.PageCount);
        }

        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvPecas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            GridViewRow linha = grvPecas.Rows[Convert.ToInt32(e.CommandArgument)];
            lblID.Text = linha.Cells[0].Text;
            txtNome.Text = linha.Cells[1].Text;
            txtAno.Text = linha.Cells[2].Text;
            txtQuantidade.Text = linha.Cells[3].Text;
            txtPreco.Text = linha.Cells[4].Text;
        }
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (lblID.Text != String.Empty)
        {
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitarcampos(true);
                txtNome.Focus();
            }
        }
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (lblID.Text != String.Empty)
        {
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                Locadora.Camadas.BLL.Pecas bllPecas = new Locadora.Camadas.BLL.Pecas();
                Locadora.Camadas.MODEL.Pecas pecas = new Locadora.Camadas.MODEL.Pecas();
                pecas.codigoPecas = Convert.ToInt32(lblID.Text);
                bllPecas.Delete(pecas);

                grvPecas.DataBind();

                Cache["OP"] = "X";
                habilitarcampos(false);
                txtNome.Focus();
            }
        }
    }
}