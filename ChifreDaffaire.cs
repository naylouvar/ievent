using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iEvent
{
    public partial class ChifreDaffaire : DevExpress.XtraEditors.XtraForm
    {
        public ChifreDaffaire(string res, string pax, string chiffre)
        {
            InitializeComponent();
            this.res = res;
            this.pax = pax;
            this.chiffre = chiffre;
        }
        string res, pax, chiffre;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChifreDaffaire_Load(object sender, EventArgs e)
        {
            textEdit1.Text = res;
            textEdit2.Text = pax;
            textEdit3.Text = chiffre;
        }
    }
}