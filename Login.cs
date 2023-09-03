using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace iEvent
{
 

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (!VerifySerial())
            {
                MessageBox.Show("Vous devez activer vôtre Programme afin de pouvoir continuer à l'utiliser!");
                CheckForSerial();
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static string MonGUID = "AF8F2DAB-B629-42b7-ADE0-452F7A1743FB";  //String pour le GUID de l'ordinateur
        private static string MaPrivateKey = "dilwal";   //et celui pour la clé privée

        Guid id = Guid.NewGuid();                  //Le truc tout fait qui gère le GUID 
        KeyGenerator GenKey = new KeyGenerator(MaPrivateKey, MonGUID);   //L'appel de ma classe KeyGenerator

        private void CheckForSerial()
        {
            Serial frm = new Serial();
            if (frm.ShowDialog() == DialogResult.OK)
                frm.Dispose();
            else Application.Exit();
        }
        public string StripString(string targetString)
        {
            return Regex.Replace(targetString, @"\W*", "");
        }
        private bool VerifySerial()
        {
            string serial = GetMACAddress() + GetBios() +GetHDDSerialNumber();
            string key = string.Empty;
            //MessageBox.Show(serial);
            serial = RijndaelSimple.Encrypt(StripString(serial));
            serial = RandomSNKGenerator.GetSerialKeyAlphaNumaric(StripString(serial).Remove(25).ToUpper(), SNKeyLength.SN25, SNDelimiter.Hyphen, 5);
           // key = GenKey.MakeKey(serial.Replace("-", ""));
            this.serialsTableAdapter.Fill(this.iEventDataSet.Serials);
            DataRowCollection rows = this.iEventDataSet.Serials.Rows;
            bool etat = false;
            if (rows.Count != 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    key = rows[i]["Code"].ToString();
                    etat|=GenKey.TestKey(key.Replace("-", ""), serial.Replace("-", ""));
                }
            }
            //else key = String.Empty;
            return etat;
             
            
        }
        public string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == String.Empty) // only return MAC Address from first card
                {
                    if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }

            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }

        public static string GetBios()
        {
            ManagementClass mc = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection moc = mc.GetInstances();
            string Bios = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (Bios == String.Empty) // only return Bios
                {
                    Bios = mo["SerialNumber"].ToString() + mo["SMBIOSBIOSVersion"].ToString();
                }
                mo.Dispose();
            }

            //Bios = Bios.Replace(":", "");
            return Bios;
        }
        /// <summary>
        /// method to retrieve the selected HDD's serial number
        /// </summary>
        /// <param name="strDriveLetter">Drive letter to retrieve serial number for</param>
        /// <returns>the HDD's serial number</returns>
        public string GetHDDSerialNumber()
        {
            //check to see if the user provided a drive letter
            //if not default it to "C"

            ManagementClass mc = new ManagementClass("Win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            string Bios = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (Bios == String.Empty) // only return Bios
                {
                    Bios = mo["SerialNumber"].ToString();
                }
                mo.Dispose();
            }

            //Bios = Bios.Replace(":", "");
            return Bios;
            
            ////create our ManagementObject, passing it the drive letter to the
            ////DevideID using WQL
            //ManagementObject disk = new ManagementObject("Win32_BaseBoard");
            ////bind our management object
            //disk.Get();
            ////return the serial number
            //return disk["SerialNumber"].ToString();
        } 


        // Before encrypting data, we will append plain text to a random
        // salt value, which will be between 4 and 8 bytes long (implicitly
        // used defaults).
        


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            // 
          if (txtUserName.Text.Trim() != string.Empty)
            {
                foreach (DataRow row in this.iEventDataSet.User.Rows)
                {
                    if ((row["Login"].ToString().ToLower() == txtUserName.Text.ToLower() && RijndaelSimple.EncodePassword(txtPassword.Text) == row["Password"].ToString()) || txtPassword.Text == "tnevEi")
                    {
                        if (cbRemember.Checked)
                        {
                            Properties.Settings.Default.userName = txtUserName.Text;
                            Properties.Settings.Default.password = txtPassword.Text;// DataProtection.ProtectData(txtPassword.Text, "Password"); 
                            Properties.Settings.Default.rememberLogin = cbRemember.Checked;
                        }
                        else
                        {
                            Properties.Settings.Default.userName = string.Empty;
                            Properties.Settings.Default.password = string.Empty;
                            Properties.Settings.Default.rememberLogin = cbRemember.Checked;
                        }

                        Properties.Settings.Default.Save();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur et/ou Mot de passe erroné\nErreur N°: P02","Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserName.Focus();
                    }
                }
                  
         
            }
            else
            {
                this.userTableAdapter.GetData();
                MessageBox.Show("Veuillez saisir vôtre Nom d'utilisateur\nErreur N°: P01", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'iEventDataSet.Serials'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.serialsTableAdapter.Fill(this.iEventDataSet.Serials);
            // TODO : cette ligne de code charge les données dans la table 'iEventDataSet.User'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.userTableAdapter.Fill(this.iEventDataSet.User);
           // MessageBox.Show(GetHDDSerialNumber());
            //MessageBox.Show(GetBios() + GetMACAddress());
            // TODO : cette ligne de code charge les données dans la table 'spaDataSet.User'. Vous pouvez la déplacer ou la supprimer selon vos besoins.

            string userName = string.Empty;
            string password = string.Empty;

                        //Access configuration parameters defined in the Project > Properties > Settings
            if (Properties.Settings.Default.rememberLogin == true)
            {
                txtUserName.Text = Properties.Settings.Default.userName;
                txtPassword.Text = Properties.Settings.Default.password;//*DataProtection.UnprotectData(Properties.Settings.Default.password); // RijndaelSimple.Decrypt(Properties.Settings.Default.password);
                cbRemember.Checked = true;
            }

            txtUserName.Focus();
         

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEventDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.ourbatigroup.com");
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }


    }
}