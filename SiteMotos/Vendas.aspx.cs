using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vendas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Locadora.Camadas.BLL.VendaPecas bllVenPec = new Locadora.Camadas.BLL.VendaPecas();
            ddlCliente.DataBind();
            ddlMoto.DataBind();
            ddlPeca.DataBind();
            grvVendas.DataBind();

            Cache["OP"] = "X";
            habilitarcampos(false);
        }
    }
        protected void habilitarcampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            lblID.Text = "";
            ddlCliente.SelectedValue = null;
            ddlMoto.SelectedValue = null;
            ddlPeca.SelectedValue = null;
            txtQuantidade.Text = null;
        }

        ddlCliente.Enabled = status;
        ddlMoto.Enabled = status;
        ddlPeca.Enabled = status;
        txtQuantidade.Enabled = status;

        btnInserir.Enabled = !status;
        btnEditar.Enabled = !status;
        btnRemover.Enabled = !status;
        btnVender.Enabled = status;
        btnCancelar.Enabled = status;
    }


    protected void btnInserir_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "I";
        habilitarcampos(true);
        lblID.Text = "-1";
        
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (lblID.Text != String.Empty)
        {
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitarcampos(true);
                
            }
        }
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (lblID.Text != String.Empty)
        {
            if (Convert.ToInt32(lblID.Text) > 0)
            {
                Locadora.Camadas.BLL.VendaPecas bllVenPecas = new Locadora.Camadas.BLL.VendaPecas();
                Locadora.Camadas.MODEL.VendaPecas venPecas = new Locadora.Camadas.MODEL.VendaPecas();
                venPecas.codigoVenda = Convert.ToInt32(lblID.Text);
                bllVenPecas.Delete(venPecas);

                grvVendas.DataBind();

                Cache["OP"] = "X";
                habilitarcampos(false);
            }
        }
    }

    protected void btnVender_Click(object sender, EventArgs e)
    {
        Locadora.Camadas.BLL.Pecas bllPecas = new Locadora.Camadas.BLL.Pecas();
        Locadora.Camadas.MODEL.Pecas pecas = new Locadora.Camadas.MODEL.Pecas();
        Locadora.Camadas.BLL.VendaPecas bllVenPecas = new Locadora.Camadas.BLL.VendaPecas();
        Locadora.Camadas.MODEL.VendaPecas venPecas = new Locadora.Camadas.MODEL.VendaPecas();
        venPecas.codigoVenda = Convert.ToInt32(lblID.Text);
        venPecas.idCliente = Convert.ToInt32(ddlCliente.SelectedValue);
        venPecas.idMoto = Convert.ToInt32(ddlMoto.SelectedValue);
        venPecas.idPecas = Convert.ToInt32(ddlPeca.SelectedValue);
        venPecas.quantidade = Convert.ToInt32(txtQuantidade.Text);
        pecas = bllPecas.SelectById(Convert.ToInt32(ddlPeca.SelectedValue));
        pecas.quantidade -= Convert.ToInt32(txtQuantidade.Text);
        
        if (Cache["OP"].ToString() == "I")
        {
            bllVenPecas.Insert(venPecas);
            bllPecas.UpDate(pecas);
        }
        else
        {
            if (Cache["OP"].ToString() == "E")
            {
                bllVenPecas.Update(venPecas);
            }
        }

        grvVendas.DataBind();

        if (Cache["OP"].ToString() == "I")
        {
            grvVendas.SetPageIndex(grvVendas.PageCount);
        }

        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvVendas_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Locadora.Camadas.BLL.VendaPecas bllVenPecas = new Locadora.Camadas.BLL.VendaPecas();
        grvVendas.PageIndex = e.NewPageIndex;
        grvVendas.DataBind();
    }

    protected void grvVendas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            GridViewRow linha = grvVendas.Rows[Convert.ToInt32(e.CommandArgument)];
            lblID.Text = linha.Cells[1].Text;
            ddlCliente.Text = linha.Cells[2].Text;
            ddlPeca.Text = linha.Cells[4].Text;
            ddlMoto.Text = linha.Cells[3].Text;        
            txtQuantidade.Text = linha.Cells[5].Text;
        }
    }
}