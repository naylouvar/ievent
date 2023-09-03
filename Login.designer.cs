namespace iEvent
{
    partial class Login
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
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEventDataSet = new iEvent.iEventDataSet();
            this.userTableAdapter = new iEvent.iEventDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new iEvent.iEventDataSetTableAdapters.TableAdapterManager();
            this.serialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialsTableAdapter = new iEvent.iEventDataSetTableAdapters.SerialsTableAdapter();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRemember
            // 
            this.cbRemember.AccessibleDescription = "Remember password";
            this.cbRemember.AccessibleName = "Remember Password";
            this.cbRemember.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRemember.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbRemember.Location = new System.Drawing.Point(140, 155);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(145, 25);
            this.cbRemember.TabIndex = 13;
            this.cbRemember.Text = "Memoriser le mot de passe";
            // 
            // lblUserName
            // 
            this.lblUserName.AccessibleDescription = "User Name";
            this.lblUserName.AccessibleName = "User Name";
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(27, 99);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(107, 18);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Nom d\'utilisateur:";
            // 
            // txtUserName
            // 
            this.txtUserName.AccessibleDescription = "User name";
            this.txtUserName.AccessibleName = "User name";
            this.txtUserName.Location = new System.Drawing.Point(140, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 20);
            this.txtUserName.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "Password";
            this.txtPassword.AccessibleName = "Password";
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(140, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // lblVersion
            // 
            this.lblVersion.AccessibleDescription = "Version label";
            this.lblVersion.AccessibleName = "Version Label";
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(90, 48);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(292, 15);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version Approuvée - Licence accordée à Beldi Country Club";
            // 
            // Label3
            // 
            this.Label3.AccessibleDescription = "";
            this.Label3.AccessibleName = "";
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(97, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "iEVent";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "Cancel";
            this.btnCancel.AccessibleName = "Cancel";
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(265, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleDescription = "OK";
            this.btnOK.AccessibleName = "OK";
            this.btnOK.AutoEllipsis = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(177, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 24);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Tan;
            this.Panel1.Controls.Add(this.lblVersion);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(-2, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(398, 81);
            this.Panel1.TabIndex = 8;
            // 
            // PictureBox1
            // 
            this.PictureBox1.AccessibleDescription = "Logo for UltimateSPA";
            this.PictureBox1.AccessibleName = "Logo for UltimateSPA";
            this.PictureBox1.Image = global::iEvent.Properties.Resources.Security;
            this.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(81, 81);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AccessibleDescription = "Password";
            this.lblPassword.AccessibleName = "Password";
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(27, 131);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 18);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Mot de passe:";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OURBATI GROUP  © 2010";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.tableAdapterManager.SerialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iEvent.iEventDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // serialsBindingSource
            // 
            this.serialsBindingSource.DataMember = "Serials";
            this.serialsBindingSource.DataSource = this.iEventDataSet;
            // 
            // serialsTableAdapter
            // 
            this.serialsTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnOK;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(397, 242);
            this.ControlBox = false;
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Tan;
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEventDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox cbRemember;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Label label1;
        private iEventDataSet iEventDataSet;
        private iEvent.iEventDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private iEvent.iEventDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource serialsBindingSource;
        private iEvent.iEventDataSetTableAdapters.SerialsTableAdapter serialsTableAdapter;

        
        
    }
}