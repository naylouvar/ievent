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
    public partial class Endroits : DevExpress.XtraEditors.XtraForm
    {
        public Endroits()
        {
            InitializeComponent();
        }

        private void emplacementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emplacementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEventDataSet);

        }

        private void Location_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'iEventDataSet.Emplacement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.emplacementTableAdapter.Fill(this.iEventDataSet.Emplacement);

        }
    }
}