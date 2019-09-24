using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmUsuario : Form
    {
        private void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = true;
            ds_senhaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        } 
        private void Desabilitar()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = true;
            ds_senhaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        
        
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource.Count > 0)
            {
                tbUsuarioBindingSource.RemoveCurrent();
                tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilitar();
        }
    }
}
