using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Management;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;

namespace iEvent
{
    public partial class Serial : DevExpress.XtraEditors.XtraForm
    {
        public Serial()
        {
            InitializeComponent();
          
        }
        private bool activée = false;
        private static string MonGUID = "AF8F2DAB-B629-42b7-ADE0-452F7A1743FB";  //String pour le GUID de l'ordinateur
        private static string MaPrivateKey = "dilwal";   //et celui pour la clé privée

        Guid id = Guid.NewGuid();                  //Le truc tout fait qui gère le GUID 
        KeyGenerator GenKey = new KeyGenerator(MaPrivateKey, MonGUID);   //L'appel de ma classe KeyGenerator

        public static string GetMACAddress()
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
        public string GetHDDSerialNumber()
        {

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
        public string StripString(string targetString)
        {
            return Regex.Replace(targetString, @"\W*", "");
        }
        private void Serial_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'iEventDataSet.Serials'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.serialsTableAdapter.Fill(this.iEventDataSet.Serials);
            // TODO : cette ligne de code charge les données dans la table 'iEventDataSet.User'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            string serial = GetMACAddress() + GetBios() + GetHDDSerialNumber();
            string key = string.Empty;
            serial = RijndaelSimple.Encrypt(StripString(serial));
            serial = RandomSNKGenerator.GetSerialKeyAlphaNumaric(StripString(serial).Remove(25).ToUpper(), SNKeyLength.SN25, SNDelimiter.Hyphen, 5);
            textEdit2.Text = serial;
        }
 
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string serial = GetMACAddress() + GetBios() + GetHDDSerialNumber();
            string key = string.Empty;
            serial = RijndaelSimple.Encrypt(StripString(serial));
            serial = RandomSNKGenerator.GetSerialKeyAlphaNumaric(StripString(serial).Remove(25).ToUpper(), SNKeyLength.SN25, SNDelimiter.Hyphen, 5);
            //key = RandomSNKGenerator.GetSerialKeyAlphaNumaric(StripString(DataProtection.ProtectData(serial, "SerialKey")).Remove(25).ToUpper(), SNKeyLength.SN25, SNDelimiter.Hyphen, 5);

            // Encrypt the string to an array of bytes.
            // key = GenKey.MakeKey(serial.Replace("-", ""));

           // textEdit3.Text = RandomSNKGenerator.GetSerialKeyAlphaNumaric(key, SNKeyLength.SN25, SNDelimiter.Hyphen, 5);
           // textEdit1.Text = serial.Replace("-", "");
           // textEdit1.Text = DataProtection.ProtectData(textEdit3.Text, "SerialKey");

            if (GenKey.TestKey(textEdit1.Text.Replace("-", ""), serial.Replace("-", "")))
            {
                //Properties.Settings.Default.serialtxt = textEdit1.Text;
                //Properties.Settings.Default.Save();
                //if (rows.Count != 0)
                this.serialsTableAdapter.Insert(textEdit1.Text);
                               
                //DataRowCollection rows = this.iEventDataSet.Serials.Rows;
                //DataRow row;
                //row= 
                //this.iEventDataSet.Serials.Rows.Add(
                //rows[rows.Count]["Code"] = textEdit1.Text;
                
                this.Validate();
                this.serialsBindingSource.EndEdit();
                this.serialsTableAdapter.Update(iEventDataSet);
                activée = true;
                this.Close();
            }
            else 
                MessageBox.Show("Le code entré n'est pas valide! Assurer d'avoir entrer le code correcte et ressayer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Serial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activée == false) Application.Exit();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iEventDataSet);

        }
    }



    public enum SNDelimiter
    {
        None = 0, Tab = 1, Space = 2, Hyphen = 3, Period = 4, Slash = 5, Comma = 6
    }

    public enum SNKeyLength
    {
        SN16 = 16, SN20 = 20, SN25 = 25, SN28 = 28, SN32 = 32
    }
    public enum SNKeyNumLength
    {
        SN4 = 4, SN8 = 8, SN12 = 12
    }
    public static class RandomSNKGenerator
    {

        private static string convertDelimiter(SNDelimiter delInt)
        {
            String temp = "";
            switch (Convert.ToInt32(delInt))
            {
                case 0:
                    temp = "";
                    break;
                case 1:
                    temp = "\t";
                    break;
                case 2:
                    temp = " ";
                    break;
                case 3:
                    temp = "-";
                    break;
                case 4:
                    temp = ".";
                    break;
                case 5:
                    temp = "/";
                    break;
                case 6:
                    temp = ",";
                    break;
            }
            return temp;
        }

        private static string AppendSpecifiedStr(int length, int delLength, string str, char[] newKey)
        {

            string newKeyStr = "";
            int k = 0;
            for (int i = 0; i < length; i++)
            {
                if (delLength != 0)
                {
                    for (k = i; k < delLength + i; k++)
                    {
                        newKeyStr += newKey[k];
                    }
                }
                else
                {
                    newKeyStr += newKey[i];
                }
                if (k == length)
                {
                    break;
                }
                else
                {

                    if (delLength != 0)
                    {
                        i = (k) - 1;
                        newKeyStr += str;
                    }
                }
            }
            return newKeyStr;
        }

         // must be 16 bytes

        /// 
        /// Generate standard serial key with alphanumaric format
        /// 
        /// the supported length of the serial key
        /// returns formated serial key
        public static string GetSerialKeyAlphaNumaric(String tracstr, SNKeyLength keyLength, SNDelimiter delimiter, int delimiterLength)
        {
            String del,  tracStr;
            del = convertDelimiter(delimiter);
            //string passPhrase = "Devdas++";        // can be any string
            //string initVector = "@1BdiLwal5F6g7H8";
            //RijndaelEnhanced rijndaelKey = new RijndaelEnhanced(passPhrase, initVector);
            //serial = Serial.GetBios() + Serial.GetMACAddress();
            //serial = serial.Remove(25);
            //string newguid = "B2BC711FFA0F4b0f9300A6B16";
            //string randomStr = newguid.ToString();
            //string tracStr = randomStr.Substring(0, (int)keyLength);
            //tracStr = rijndaelKey.Encrypt(serial);
            tracStr = tracstr.ToUpper();
            char[] newKey = tracStr.ToCharArray();
            string newSerialNumber = "";
            switch (keyLength)
            {
                case SNKeyLength.SN16:
                    newSerialNumber = AppendSpecifiedStr(16, delimiterLength, del, newKey);
                    break;
                case SNKeyLength.SN20:
                    newSerialNumber = AppendSpecifiedStr(20, delimiterLength, del, newKey);
                    break;
                case SNKeyLength.SN25:
                    newSerialNumber = AppendSpecifiedStr(25, delimiterLength, del, newKey);
                    break;
                case SNKeyLength.SN28:
                    newSerialNumber = AppendSpecifiedStr(28, delimiterLength, del, newKey);
                    break;
                case SNKeyLength.SN32:
                    newSerialNumber = AppendSpecifiedStr(32, delimiterLength, del, newKey);
                    break;
            }
            return newSerialNumber;
        }
        ///
        /// Generate serial key with only numaric
        ///
        /// the supported length of the serial key
        /// returns formated serial key
        public static string GetSerialKeyNumaric(SNKeyNumLength keyLength)
        {
            int rn = 10;
            double sd = Math.Round(rn * Math.Pow(10, (int)keyLength) + 4);
            return sd.ToString().Substring(0, (int)keyLength);
        }


    }
}