// Developer Express Code Central Example:
// How to customize the Edit Appointment form to show custom fields
// 
// This example illustrates the use of a custom form to enable the end-user to edit
// custom fields. The custom form is invoked instead of the default one by handling
// the SchedulerControl.EditAppointmentFormShowing event. See Also:
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E152


namespace iEvent
{
    partial class Form2
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
            this.checkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.timeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.timeStart = new DevExpress.XtraEditors.TimeEdit();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.dtStart = new DevExpress.XtraEditors.DateEdit();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.edStatus = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this.edLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.txSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblEnd = new System.Windows.Forms.Label();
            this.prix = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.fax = new DevExpress.XtraEditors.TextEdit();
            this.pax = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomStatus = new System.Windows.Forms.Label();
            this.lblCustomName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new DevExpress.XtraEditors.TextEdit();
            this.appointmentResourceEdit1 = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.txtdescription = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.durationEdit1 = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentResourceEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkAllDay
            // 
            this.checkAllDay.Location = new System.Drawing.Point(12, 245);
            this.checkAllDay.Name = "checkAllDay";
            this.checkAllDay.Properties.Caption = "All day event";
            this.checkAllDay.Size = new System.Drawing.Size(91, 18);
            this.checkAllDay.TabIndex = 23;
            this.checkAllDay.Visible = false;
            this.checkAllDay.CheckedChanged += new System.EventHandler(this.checkAllDay_CheckedChanged);
            // 
            // timeEnd
            // 
            this.timeEnd.EditValue = new System.DateTime(2006, 3, 28, 13, 0, 0, 0);
            this.timeEnd.Location = new System.Drawing.Point(388, 192);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEnd.Size = new System.Drawing.Size(66, 20);
            this.timeEnd.TabIndex = 21;
            this.timeEnd.EditValueChanged += new System.EventHandler(this.timeEnd_EditValueChanged);
            // 
            // timeStart
            // 
            this.timeStart.EditValue = new System.DateTime(2006, 3, 28, 12, 0, 0, 0);
            this.timeStart.Location = new System.Drawing.Point(388, 168);
            this.timeStart.Name = "timeStart";
            this.timeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeStart.Size = new System.Drawing.Size(66, 20);
            this.timeStart.TabIndex = 19;
            this.timeStart.EditValueChanged += new System.EventHandler(this.timeStart_EditValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.EditValue = new System.DateTime(2005, 11, 25, 0, 0, 0, 0);
            this.dtEnd.Location = new System.Drawing.Point(297, 192);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtEnd.Size = new System.Drawing.Size(85, 20);
            this.dtEnd.TabIndex = 12;
            this.dtEnd.EditValueChanged += new System.EventHandler(this.dtEnd_EditValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.EditValue = new System.DateTime(2005, 11, 25, 0, 0, 0, 0);
            this.dtStart.Location = new System.Drawing.Point(297, 168);
            this.dtStart.Name = "dtStart";
            this.dtStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtStart.Size = new System.Drawing.Size(85, 20);
            this.dtStart.TabIndex = 11;
            this.dtStart.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(236, 171);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 18);
            this.lblStart.TabIndex = 33;
            this.lblStart.Text = "Début:";
            // 
            // lblLabel
            // 
            this.lblLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Red;
            this.lblLabel.Location = new System.Drawing.Point(33, 195);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(66, 19);
            this.lblLabel.TabIndex = 31;
            this.lblLabel.Text = "Type:";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(4, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 18);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Confirmation:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edStatus
            // 
            this.edStatus.Location = new System.Drawing.Point(105, 171);
            this.edStatus.Name = "edStatus";
            this.edStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edStatus.Size = new System.Drawing.Size(125, 20);
            this.edStatus.TabIndex = 6;
            // 
            // edLabel
            // 
            this.edLabel.Location = new System.Drawing.Point(105, 195);
            this.edLabel.Name = "edLabel";
            this.edLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edLabel.Size = new System.Drawing.Size(125, 20);
            this.edLabel.TabIndex = 7;
            // 
            // txSubject
            // 
            this.txSubject.EditValue = "";
            this.txSubject.Location = new System.Drawing.Point(105, 12);
            this.txSubject.Name = "txSubject";
            this.txSubject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSubject.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txSubject.Properties.Appearance.Options.UseFont = true;
            this.txSubject.Properties.Appearance.Options.UseForeColor = true;
            this.txSubject.Size = new System.Drawing.Size(350, 20);
            this.txSubject.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Tomato;
            this.lblSubject.Location = new System.Drawing.Point(33, 13);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(66, 18);
            this.lblSubject.TabIndex = 22;
            this.lblSubject.Text = "Client:";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(161, 360);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(236, 197);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(50, 18);
            this.lblEnd.TabIndex = 36;
            this.lblEnd.Text = "Fin:";
            // 
            // prix
            // 
            this.prix.EditValue = "";
            this.prix.Location = new System.Drawing.Point(330, 37);
            this.prix.Name = "prix";
            this.prix.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.prix.Properties.Appearance.Options.UseFont = true;
            this.prix.Properties.Appearance.Options.UseForeColor = true;
            this.prix.Properties.Mask.BeepOnError = true;
            this.prix.Properties.Mask.EditMask = "n";
            this.prix.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.prix.Properties.Mask.ShowPlaceHolders = false;
            this.prix.Size = new System.Drawing.Size(125, 20);
            this.prix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(232, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prix appliqué:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email
            // 
            this.email.EditValue = "";
            this.email.Location = new System.Drawing.Point(105, 116);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(350, 20);
            this.email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "E-mail:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fax
            // 
            this.fax.EditValue = "";
            this.fax.Location = new System.Drawing.Point(105, 92);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(350, 20);
            this.fax.TabIndex = 4;
            // 
            // pax
            // 
            this.pax.EditValue = "";
            this.pax.Location = new System.Drawing.Point(105, 38);
            this.pax.Name = "pax";
            this.pax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pax.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.pax.Properties.Appearance.Options.UseFont = true;
            this.pax.Properties.Appearance.Options.UseForeColor = true;
            this.pax.Properties.EditFormat.FormatString = "N0";
            this.pax.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pax.Properties.Mask.BeepOnError = true;
            this.pax.Properties.Mask.EditMask = "d";
            this.pax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.pax.Properties.MaxLength = 4;
            this.pax.Size = new System.Drawing.Size(125, 20);
            this.pax.TabIndex = 1;
            // 
            // lblCustomStatus
            // 
            this.lblCustomStatus.Location = new System.Drawing.Point(1, 90);
            this.lblCustomStatus.Name = "lblCustomStatus";
            this.lblCustomStatus.Size = new System.Drawing.Size(98, 19);
            this.lblCustomStatus.TabIndex = 44;
            this.lblCustomStatus.Text = "Fax:";
            this.lblCustomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomName
            // 
            this.lblCustomName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCustomName.Location = new System.Drawing.Point(1, 38);
            this.lblCustomName.Name = "lblCustomName";
            this.lblCustomName.Size = new System.Drawing.Size(98, 19);
            this.lblCustomName.TabIndex = 43;
            this.lblCustomName.Text = "Nombre de Pax:";
            this.lblCustomName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Téléphone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tel
            // 
            this.tel.EditValue = "";
            this.tel.Location = new System.Drawing.Point(105, 66);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(350, 20);
            this.tel.TabIndex = 3;
            // 
            // appointmentResourceEdit1
            // 
            this.appointmentResourceEdit1.Location = new System.Drawing.Point(105, 142);
            this.appointmentResourceEdit1.Name = "appointmentResourceEdit1";
            this.appointmentResourceEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.appointmentResourceEdit1.Size = new System.Drawing.Size(125, 20);
            this.appointmentResourceEdit1.TabIndex = 9;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(105, 221);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtdescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtdescription.Size = new System.Drawing.Size(349, 133);
            this.txtdescription.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Observations:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // durationEdit1
            // 
            this.durationEdit1.EditValue = System.TimeSpan.Parse("1.00:00:00");
            this.durationEdit1.Location = new System.Drawing.Point(330, 142);
            this.durationEdit1.Name = "durationEdit1";
            this.durationEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.durationEdit1.Properties.Items.AddRange(new object[] {
            System.TimeSpan.Parse("00:01:00"),
            System.TimeSpan.Parse("00:05:00"),
            System.TimeSpan.Parse("00:10:00"),
            System.TimeSpan.Parse("00:15:00"),
            System.TimeSpan.Parse("00:30:00"),
            System.TimeSpan.Parse("01:00:00"),
            System.TimeSpan.Parse("02:00:00"),
            System.TimeSpan.Parse("03:00:00"),
            System.TimeSpan.Parse("04:00:00"),
            System.TimeSpan.Parse("05:00:00"),
            System.TimeSpan.Parse("06:00:00"),
            System.TimeSpan.Parse("07:00:00"),
            System.TimeSpan.Parse("08:00:00"),
            System.TimeSpan.Parse("09:00:00"),
            System.TimeSpan.Parse("10:00:00"),
            System.TimeSpan.Parse("11:00:00"),
            System.TimeSpan.Parse("12:00:00"),
            System.TimeSpan.Parse("18:00:00"),
            System.TimeSpan.Parse("1.00:00:00"),
            System.TimeSpan.Parse("2.00:00:00"),
            System.TimeSpan.Parse("3.00:00:00"),
            System.TimeSpan.Parse("4.00:00:00"),
            System.TimeSpan.Parse("7.00:00:00"),
            System.TimeSpan.Parse("14.00:00:00")});
            this.durationEdit1.Size = new System.Drawing.Size(125, 20);
            this.durationEdit1.TabIndex = 50;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(249, 144);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Olive;
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "&Rappel:";
            this.checkEdit1.Size = new System.Drawing.Size(75, 18);
            this.checkEdit1.TabIndex = 51;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(492, 399);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.durationEdit1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.appointmentResourceEdit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.pax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCustomStatus);
            this.Controls.Add(this.lblCustomName);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.checkAllDay);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.edStatus);
            this.Controls.Add(this.edLabel);
            this.Controls.Add(this.txSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Text = "iEvent Réservation";
            ((System.ComponentModel.ISupportInitialize)(this.checkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentResourceEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkAllDay;
        private DevExpress.XtraEditors.TimeEdit timeEnd;
        private DevExpress.XtraEditors.TimeEdit timeStart;
        private DevExpress.XtraEditors.DateEdit dtEnd;
        private DevExpress.XtraEditors.DateEdit dtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraScheduler.UI.AppointmentStatusEdit edStatus;
        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit edLabel;
        private DevExpress.XtraEditors.TextEdit txSubject;
        private System.Windows.Forms.Label lblSubject;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.Label lblEnd;
        private DevExpress.XtraEditors.TextEdit prix;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit email;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit fax;
        private DevExpress.XtraEditors.TextEdit pax;
        private System.Windows.Forms.Label lblCustomStatus;
        private System.Windows.Forms.Label lblCustomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tel;
        private DevExpress.XtraScheduler.UI.AppointmentResourceEdit appointmentResourceEdit1;
        private DevExpress.XtraEditors.MemoEdit txtdescription;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraScheduler.UI.DurationEdit durationEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}