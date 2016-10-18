using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Locadora.Camadas.BLL.Cliente bllCliente = new Locadora.Camadas.BLL.Cliente();
            grvCliente.DataBind();

            Cache["OP"] = "X";
            habilitarcampos(false);
        }
    }

    protected void habilitarcampos(bool status)
    {
        if(Cache["OP"].ToString() != "E")
        {
            lblID.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtNascimento.Text = "";
            txtCpf.Text = "";
        }

        txtNome.Enabled = status;
        txtCelular.Enabled = status;
        txtEmail.Enabled = status;
        txtNascimento.Enabled = status;
        txtCpf.Enabled = status;

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

    protected void grvCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Locadora.Camadas.BLL.Cliente bllCliente = new Locadora.Camadas.BLL.Cliente();
        grvCliente.PageIndex = e.NewPageIndex;
        grvCliente.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Locadora.Camadas.BLL.Cliente bllCliente = new Locadora.Camadas.BLL.Cliente();
        Locadora.Camadas.MODEL.Cliente cliente = new Locadora.Camadas.MODEL.Cliente();
        cliente.codigoCliente = Convert.ToInt32(lblID.Text);
        cliente.nome = txtNome.Text;
        cliente.celular = txtCelular.Text;
        cliente.email = txtEmail.Text;
        cliente.nascimento = txtNascimento.Text;
        cliente.cpf = txtCpf.Text;

        if (Cache["OP"].ToString() == "I")
        {
            bllCliente.Insert(cliente);
        }
        else
        {
            if (Cache["OP"].ToString() == "E")
            {
                bllCliente.UpDate(cliente);
            }
        }

        grvCliente.DataBind();

        if(Cache["OP"].ToString() == "I")
        {
            grvCliente.SetPageIndex(grvCliente.PageCount);
        }

        Cache["OP"] = "X";
        habilitarcampos(false);
    }

    protected void grvCliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "Select")
        {
            GridViewRow linha = grvCliente.Rows[Convert.ToInt32(e.CommandArgument)];
            lblID.Text = linha.Cells[0].Text;
            txtNome.Text = linha.Cells[1].Text;
            txtCelular.Text = linha.Cells[2].Text;
            txtEmail.Text = linha.Cells[3].Text;
            txtNascimento.Text = linha.Cells[4].Text;
            txtCpf.Text = linha.Cells[5].Text;
        }
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if(lblID.Text != String.Empty)
        {
            if(Convert.ToInt32(lblID.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitarcampos(true);
                txtNome.Focus();
            }
        }
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if(lblID.Text != String.Empty)
        {
            if(Convert.ToInt32(lblID.Text) > 0)
            {
                Locadora.Camadas.BLL.Cliente bllCliente = new Locadora.Camadas.BLL.Cliente();
                Locadora.Camadas.MODEL.Cliente cliente = new Locadora.Camadas.MODEL.Cliente();
                cliente.codigoCliente = Convert.ToInt32(lblID.Text);
                bllCliente.Delete(cliente);

                grvCliente.DataBind();

                Cache["OP"] = "X";
                habilitarcampos(false);
                txtNome.Focus();
            }
        }
    }

    protected void grvCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        //teste
    }
}