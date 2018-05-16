using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        private bool symbol;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBoxHelper.No = "X";
            MessageBoxHelper.Yes = "O";

            MessageBoxHelper.Register();

            DialogResult dialogWizard = MessageBox.Show
            (
                "Selecione um símbolo",
                "Jogo da Velha", MessageBoxButtons.YesNo, MessageBoxIcon.Information
            );
            MessageBoxHelper.Unregister();

            if (dialogWizard == DialogResult.Yes)
            {
                // YES
                symbol = true;
            }
            else
            {
                // NO
                symbol = false;
            }

            ActivateButtons();

        }

        private void btnEsqSup_Click(object sender, EventArgs e)
        {
            if (symbol)
            {
                btnEsqSup.Text = "O";
            }
            else
            {
                btnEsqSup.Text = "X";
            }
        }

        private void btnMidSup_Click(object sender, EventArgs e)
        {

        }

        private void btnDirSup_Click(object sender, EventArgs e)
        {

        }

        private void btnEsqMid_Click(object sender, EventArgs e)
        {

        }

        private void btnMidMid_Click(object sender, EventArgs e)
        {

        }

        private void btnDirMid_Click(object sender, EventArgs e)
        {

        }

        private void btnEsqInf_Click(object sender, EventArgs e)
        {

        }

        private void btnMidInf_Click(object sender, EventArgs e)
        {

        }

        private void btnDirInf_Click(object sender, EventArgs e)
        {

        }

        private void ActivateButtons()
        {
            btnEsqSup.Enabled = true;
            btnMidSup.Enabled = true;
            btnDirSup.Enabled = true;
            btnEsqMid.Enabled = true;
            btnMidMid.Enabled = true;
            btnDirMid.Enabled = true;
            btnEsqInf.Enabled = true;
            btnMidInf.Enabled = true;
            btnDirInf.Enabled = true;
        }
    }
}
