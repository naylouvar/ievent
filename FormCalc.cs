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
    public partial class FormCalc : DevExpress.XtraEditors.XtraForm
    {
        public FormCalc()
        {
            InitializeComponent();
        }
        //DateTime date1; DateTime date2;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1.date1 = dateEdit1.DateTime; // < dateEdit2.DateTime ? dateEdit1.DateTime : dateEdit2.DateTime;
            Form1.date2 = dateEdit2.DateTime.AddDays(1);
            this.Close();
        }

    
    }
}