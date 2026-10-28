using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesFactures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculerMontant()
        {
            int prix = int.Parse(txtPrix.Text);
            decimal quantite = numQuantite.Value;
            decimal montant = prix * quantite;
            txtMontant.Text = montant.ToString();
        }  
        private void cmbReference_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cmbReference.SelectedIndex == 0) {
                txtDesignation.Text = "Ecran";
                txtPrix.Text = "600";
                numQuantite.Value = 1;
            }
            else if (cmbReference.SelectedIndex == 1) {
                txtDesignation.Text = "Clavier";
                txtPrix.Text = "20";
                numQuantite.Value = 1;
            }
            else if (cmbReference.SelectedIndex == 2)
            {
                txtDesignation.Text = "Souris";
                txtPrix.Text = "15";
                numQuantite.Value = 1;
            }
            else if (cmbReference.SelectedIndex == 3)
            {
                txtDesignation.Text = "Pc";
                txtPrix.Text = "6000";
                numQuantite.Value = 1;
            }
            else if (cmbReference.SelectedIndex == 4)
            {
                txtDesignation.Text = "Imprimante";
                txtPrix.Text = "500";
                numQuantite.Value = 1;
            }
            else if (cmbReference.SelectedIndex == 5)
            {
                txtDesignation.Text = "Cable";
                txtPrix.Text = "5";
                numQuantite.Value = 1;
            }
            CalculerMontant();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReference.Items.Add("R001");
            cmbReference.Items.Add("R002");
            cmbReference.Items.Add("R003");
            cmbReference.Items.Add("R004");
            cmbReference.Items.Add("R005");

        }

        private void numQuantite_ValueChanged(object sender, EventArgs e)
        {
            CalculerMontant();
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            CalculerMontant();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbReference.SelectedIndex = -1;
            txtDesignation.Text = String.Empty;
            txtPrix.Text = "0";
            numQuantite.Value = 0;
        }
    }
}
