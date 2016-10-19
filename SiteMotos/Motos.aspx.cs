using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Motos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Locadora.Camadas.BLL.Motos bllMotos = new Locadora.Camadas.BLL.Motos();
            grvMotos.DataBind();

            Cache["OP"] = "X";
            habilitarcampos(false);
        }
        
    }

    protected void habilitarcampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            lblID.Text = "";
            txtMarca.Text = "";
            txtSituacao.Text = "";
            ddlIDCliente.SelectedValue = null;
            txtModelo.Text = "";
            txtAno.Text = "";
        }

        txtMarca.Enabled = status;
        txtSituacao.Enabled = status;
        ddlIDCliente.Enabled = status;
        txtModelo.Enabled = status;
        txtAno.Enabled = status;

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
        txtMarca.Focus();
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvMotos_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        Locadora.Camadas.BLL.Motos bllMotos = new Locadora.Camadas.BLL.Motos();
        grvMotos.PageIndex = e.NewPageIndex;
        grvMotos.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Locadora.Camadas.BLL.Motos bllMotos = new Locadora.Camadas.BLL.Motos();
        Locadora.Camadas.MODEL.Motos motos = new Locadora.Camadas.MODEL.Motos();
        motos.codigoMoto = Convert.ToInt32(lblID.Text);
        motos.motoMarca = txtMarca.Text;
        motos.situacao = txtSituacao.Text;
        motos.idCliente = Convert.ToInt32(ddlIDCliente.SelectedValue);
        motos.motoModelo = txtModelo.Text;
        motos.anoMoto = txtAno.Text;

        if (Cache["OP"].ToString() == "I")
        {
            bllMotos.Insert(motos);
        }
        else
        {
            if (Cache["OP"].ToString() == "E")
            {
                bllMotos.UpDate(motos);
            }
        }

        grvMotos.DataBind();

        if (Cache["OP"].ToString() == "I")
        {
            grvMotos.SetPageIndex(grvMotos.PageCount);
        }

        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvMotos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            GridViewRow linha = grvMotos.Rows[Convert.ToInt32(e.CommandArgument)];
            lblID.Text = linha.Cells[0].Text;
            txtMarca.Text = linha.Cells[1].Text;
            txtSituacao.Text = linha.Cells[2].Text;
            ddlIDCliente.Text = linha.Cells[3].Text;
            txtModelo.Text = linha.Cells[4].Text;
            txtAno.Text = linha.Cells[5].Text;
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
                txtMarca.Focus();
            }
        }
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (lblID.Text != String.Empty)
        {
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                Locadora.Camadas.BLL.Motos bllMotos = new Locadora.Camadas.BLL.Motos();
                Locadora.Camadas.MODEL.Motos motos = new Locadora.Camadas.MODEL.Motos();
                motos.codigoMoto = Convert.ToInt32(lblID.Text);
                bllMotos.Delete(motos);

                grvMotos.DataBind();

                Cache["OP"] = "X";
                habilitarcampos(false);
                txtMarca.Focus();
            }
        }
    }

    protected void ddlIDCliente_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}