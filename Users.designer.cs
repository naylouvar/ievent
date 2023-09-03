namespace iEvent
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.prenomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEventDataSet = new iEvent.iEventDataSet();
            this.userTableAdapter = new iEvent.iEventDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new iEvent.iEventDataSetTableAdapters.TableAdapterManager();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(51, 19);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(90, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Nom d\'utilisateur:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(51, 45);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(75, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Mot de passe:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(51, 97);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(51, 123);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(47, 13);
            prenomLabel.TabIndex = 9;
            prenomLabel.Text = "Prénom:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(51, 149);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(25, 13);
            telLabel.TabIndex = 11;
            telLabel.Text = "Tél:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(51, 175);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 5;
            label1.Text = "Confirmer:";
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Login", true));
            this.loginTextEdit.Location = new System.Drawing.Point(152, 16);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(160, 20);
            this.loginTextEdit.TabIndex = 0;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.passwordTextEdit.Location = new System.Drawing.Point(152, 42);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(160, 20);
            this.passwordTextEdit.TabIndex = 1;
            // 
            // nomTextEdit
            // 
            this.nomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Nom", true));
            this.nomTextEdit.Location = new System.Drawing.Point(152, 94);
            this.nomTextEdit.Name = "nomTextEdit";
            this.nomTextEdit.Size = new System.Drawing.Size(160, 20);
            this.nomTextEdit.TabIndex = 3;
            // 
            // prenomTextEdit
            // 
            this.prenomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Prenom", true));
            this.prenomTextEdit.Location = new System.Drawing.Point(152, 120);
            this.prenomTextEdit.Name = "prenomTextEdit";
            this.prenomTextEdit.Size = new System.Drawing.Size(160, 20);
            this.prenomTextEdit.TabIndex = 4;
            // 
            // telTextEdit
            // 
            this.telTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Tel", true));
            this.telTextEdit.Location = new System.Drawing.Point(152, 146);
            this.telTextEdit.Name = "telTextEdit";
            this.telTextEdit.Size = new System.Drawing.Size(160, 20);
            this.telTextEdit.TabIndex = 5;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(152, 172);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(160, 20);
            this.emailTextEdit.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(91, 221);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "&Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(204, 221);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 28);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "&Annuler";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "Password", true));
            this.textEdit1.Location = new System.Drawing.Point(152, 68);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.PasswordChar = '*';
            this.textEdit1.Size = new System.Drawing.Size(160, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.iEventDataSet;
            // 
            // iEventDataSet
            // 
            this.iEventDataSet.DataSetName = "iEventDataSet";
            this.iEventDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmplacementTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iEvent.iEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // Users
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(378, 272);
            this.ControlBox = false;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextEdit);
            this.Controls.Add(label1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextEdit);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextEdit);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Name = "Users";
            this.ShowIcon = false;
            this.Text = "Utilisateur -Admin";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iEventDataSet iEventDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private iEvent.iEventDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private iEvent.iEventDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit nomTextEdit;
        private DevExpress.XtraEditors.TextEdit prenomTextEdit;
        private DevExpress.XtraEditors.TextEdit telTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}