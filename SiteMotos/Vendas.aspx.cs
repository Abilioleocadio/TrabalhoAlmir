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
        }

        ddlCliente.Enabled = status;
        ddlMoto.Enabled = status;
        ddlPeca.Enabled = status;

        btnInserir.Enabled = !status;
        btnEditar.Enabled = !status;
        btnRemover.Enabled = !status;
        btnGravar.Enabled = status;
        btnCancelar.Enabled = status;
    }

}