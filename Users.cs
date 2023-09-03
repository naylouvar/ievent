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
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
        public Users()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEventDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'spaDataSet.User'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.userTableAdapter.Fill(this.iEventDataSet.User);
            password = passwordTextEdit.Text; 
        }
        string password = String.Empty;
        private void okButton_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.None;
            //    
             // must be 16 bytes

            // Before encrypting data, we will append plain text to a random
            // salt value, which will be between 4 and 8 bytes long (implicitly
            // used defaults).
       
            if (passwordTextEdit.Text.Length <4) 
                XtraMessageBox.Show("Veuillez saisir un mot de passe valide \nminimum 4 caractères", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (loginTextEdit.Text.Trim() != string.Empty)
            {
                if (passwordTextEdit.Text != password)
                    if (passwordTextEdit.Text == textEdit1.Text)
                        passwordTextEdit.Text =RijndaelSimple.EncodePassword(passwordTextEdit.Text); // DataProtection.ProtectData(passwordTextEdit.Text, "Password");//
                    else
                    { XtraMessageBox.Show("Les mots de passe sont differents", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                    }
                        //DataProtection.ProtectData(passwordTextEdit.Text, "motdepasse");
           
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEventDataSet);
            }
            else XtraMessageBox.Show("Veuillez saisir vôtre Nom d'utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}