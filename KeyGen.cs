using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace iEvent
{
    class KeyGenerator
    {

        Random MonRnd = new Random(System.Environment.TickCount); //Un random qui va servir pour les premiers caractères aléatoires
        const int KeyLengh = 25;        //Longueur de la clé
        const int NbRandomChar = 4;     //Nombre de caractères aléatoires au début de la clé
        const int NbChar = 36;          //Nombre de caractères utilisés pour la partie aléatoire (0-9 A-Z)
        string PrivateKey;              //La clé privée
        string MyGUID;                  //Le GUID

        public KeyGenerator(string MaCle, string MonGUID)
        {
            //Initialisation de la classe en lui fournissant une clé privée et un GUID (peuvent être nuls)
            PrivateKey = MaCle;
            MyGUID = MonGUID;
        }

        public void ChangeGUID(string MonGUID)
        {
            //Change la valeur du GUID
            MyGUID = MonGUID;
        }
        public void ChangePrivateKey(string MaCle)
        {
            //Change la clé privée
            PrivateKey = MaCle;
        }
        public string GetPrivateKey()
        {
            //Me revoie la valeur de la clé privée
            return PrivateKey;
        }
        public string GetGUID()
        {
            //Me revoie la valeur du GUID enregistré dans la classe
            return MyGUID;
        }

        //Fonction qui génère la clé à partir de 4 caractères aléatoires transmis dans un tableau d'int, ainsi que la clé publique
        private string GenKey(int[] MyValueKey, string PublicKey)
        {
            //Matrice des caractères utilisé
            char[] Matrice1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //Liste de nombre premiers
            int[] Premier = { 2, 3, 5, 7, 11, 22, 17, 19, 23, 29, 31, 37, 41, 43, 47, 51, 57, 61, 67, 71, 73, 79, 83, 89, 97 }; //0-24
            int[] NbQ = { 2, 3, 5, 7, 11, 101, 131, 151, 131, 147, 317, 379, 373, 383, 727, 757, 787, 797, 917, 925, 10361, 10501, 10301, 11311, 11411, 12421, 12721, 12821, 13331, 13831, 13931, 14841, 16741, 15451, 15551, 16061, 16361, 16561, 16661, 19471, 17971, 18781, 18481, 19691, 19791, 19991 }; //0-24

            //Mes clés (servent à la suite des opérations)
            string MyKey1 = "";
            string MyKey2 = "";
            string MyKey3 = "";


            //Bon héhé, J'explique: ce morceau la, va générer les 21 caractères restants en effectuant des calculs dessus 
            //on prend des caractères qu'on multiplie avec d'autre avec des modulo des nombres premiers (parait que c'est mieux)
            //et on arrive à une belle clé pas facile à deviner.
            MyValueKey[4] = Math.Abs((MyValueKey[0] * MyValueKey[0] * MyValueKey[3] + NbQ[1]) * Premier[0] + 42971 * (((MyValueKey[0] + NbQ[21]) % NbQ[16]) + NbQ[11])) % Matrice1.Length;
            MyValueKey[5] = Math.Abs((MyValueKey[0] * MyValueKey[1] * MyValueKey[4] + NbQ[12]) * Premier[2] + 145 * (((MyValueKey[3] + NbQ[22]) % NbQ[17]) + NbQ[12])) % Matrice1.Length;
            MyValueKey[6] = Math.Abs((MyValueKey[0] * MyValueKey[2] * MyValueKey[4] + NbQ[3]) * Premier[9] + 639 * (((MyValueKey[2] + NbQ[23]) % NbQ[18]) + NbQ[13])) % Matrice1.Length;
            MyValueKey[7] = Math.Abs((MyValueKey[0] * MyValueKey[3] * MyValueKey[1] + NbQ[13]) * Premier[9] + 1277 * (((MyValueKey[4] + NbQ[23]) % NbQ[18]) + NbQ[13])) % Matrice1.Length;
            MyValueKey[8] = Math.Abs((MyValueKey[1] * MyValueKey[0] * MyValueKey[1] + NbQ[4]) * Premier[8] + 5622 * (((MyValueKey[1] + NbQ[24]) % NbQ[19]) + NbQ[14])) % Matrice1.Length;
            MyValueKey[9] = Math.Abs((MyValueKey[1] * MyValueKey[1] * MyValueKey[0] + NbQ[5]) * Premier[6] + 74026 * (((MyValueKey[4] + NbQ[0]) % NbQ[20]) + NbQ[15])) % Matrice1.Length;
            MyValueKey[10] = Math.Abs((MyValueKey[1] * MyValueKey[2] * MyValueKey[3] + NbQ[26]) * Premier[5] + 927 * (((MyValueKey[0] + NbQ[1]) % NbQ[21]) + NbQ[16])) % Matrice1.Length;
            MyValueKey[11] = Math.Abs((MyValueKey[1] * MyValueKey[3] * MyValueKey[4] + NbQ[7]) * Premier[4] + 4838 * (((MyValueKey[2] + NbQ[2]) % NbQ[22]) + NbQ[17])) % Matrice1.Length;
            MyValueKey[12] = Math.Abs((MyValueKey[2] * MyValueKey[0] * MyValueKey[6] + NbQ[8]) * Premier[3] + 779 * (((MyValueKey[6] + NbQ[3]) % NbQ[23]) + NbQ[18])) % Matrice1.Length;
            MyValueKey[13] = Math.Abs((MyValueKey[2] * MyValueKey[1] * MyValueKey[3] + NbQ[19]) * Premier[7] + 356 * (((MyValueKey[3] + NbQ[4]) % NbQ[24]) + NbQ[19])) % Matrice1.Length;
            MyValueKey[14] = Math.Abs((MyValueKey[2] * MyValueKey[2] * MyValueKey[8] + NbQ[10]) * Premier[1] + 422 * (((MyValueKey[4] + NbQ[7]) % NbQ[6]) + NbQ[20])) % Matrice1.Length;
            MyValueKey[15] = Math.Abs((MyValueKey[2] * MyValueKey[3] * MyValueKey[1] + NbQ[11]) * Premier[10] + 533 * (((MyValueKey[9] + NbQ[6]) % NbQ[1]) + NbQ[21])) % Matrice1.Length;
            MyValueKey[16] = Math.Abs((MyValueKey[3] * MyValueKey[0] * MyValueKey[3] + NbQ[12]) * Premier[22] + 13 * (((MyValueKey[8] + NbQ[7]) % NbQ[2]) + NbQ[22])) % Matrice1.Length;
            MyValueKey[17] = Math.Abs((MyValueKey[3] * MyValueKey[1] * MyValueKey[3] + NbQ[23]) * Premier[11] + 63 * (((MyValueKey[7] + NbQ[8]) % NbQ[3]) + NbQ[23])) % Matrice1.Length;
            MyValueKey[18] = Math.Abs((MyValueKey[3] * MyValueKey[2] * MyValueKey[2] + NbQ[14]) * Premier[23] + 54 * (((MyValueKey[4] + NbQ[9]) % NbQ[4]) + NbQ[24])) % Matrice1.Length;
            MyValueKey[19] = Math.Abs((MyValueKey[3] * MyValueKey[3] * MyValueKey[4] + NbQ[13]) * Premier[19] + 109 * (((MyValueKey[3] + NbQ[10]) % NbQ[5]) + NbQ[0])) % Matrice1.Length;
            MyValueKey[20] = Math.Abs((MyValueKey[4] * MyValueKey[0] * MyValueKey[3] + NbQ[16]) * Premier[18] + 77 * (((MyValueKey[8] + NbQ[11]) % NbQ[6]) + NbQ[1])) % Matrice1.Length;
            MyValueKey[21] = Math.Abs((MyValueKey[5] * MyValueKey[3] * MyValueKey[1] + NbQ[7]) * Premier[12] + 541 * (((MyValueKey[6] + NbQ[12]) % NbQ[7]) + NbQ[2])) % Matrice1.Length;
            MyValueKey[22] = Math.Abs((MyValueKey[6] * MyValueKey[2] * MyValueKey[9] + NbQ[18]) * Premier[15] + 89 * (((MyValueKey[5] + NbQ[13]) % NbQ[7]) + NbQ[3])) % Matrice1.Length;
            MyValueKey[23] = Math.Abs((MyValueKey[7] * MyValueKey[1] * MyValueKey[1] + NbQ[19]) * Premier[12] + 83 * (((MyValueKey[7] + NbQ[14]) % NbQ[9]) + NbQ[4])) % Matrice1.Length;
            MyValueKey[24] = Math.Abs((MyValueKey[8] * MyValueKey[0] * MyValueKey[0] + NbQ[11]) * Premier[24] + 113 * (((MyValueKey[3] + NbQ[15]) % NbQ[10]) + NbQ[5])) % Matrice1.Length;
            
            //Je transforme ma chaîne de valeurs en caractère de 0-9 A-Z grâce à ma matrice
            foreach (int x in MyValueKey)
                MyKey1 = MyKey1 + Matrice1[x].ToString();

            //Petite idée qui m'est venue par la suite, je mélange mes clés (privées, publiques, GUID, etc...) avec du MD5 et SHA pour
            //en obtenir un truc joli et parfaitement iréversible
            MyKey2 = CreateMD5Hash(PrivateKey + MyKey1);    //Pour la clé privée
            MyKey2 = CreateMD5Hash(MyGUID + MyKey2);        //Pour le GUID
            MyKey2 = CreateSHAHash(PublicKey + MyKey2);     //et une dernière pour la clé publique

            //Je réécris mes premiers caractère qui ne doivent pas changer
            for (int i = 0; i < NbRandomChar; i++)
                MyKey3 = MyKey3 + Matrice1[MyValueKey[i]].ToString();

            //je remélange les suivante avec des valeurs quelquonques pour avoir des caractères de 0-9A-Z 
            //(Le SHA et MD5 retournent de l'hexadecimal A-F, donc ça fait moins de posibilités de clé) 
            for (int i = NbRandomChar; i < KeyLengh; i++)
                MyKey3 = MyKey3 + Matrice1[((MyValueKey[i] + MyKey1[i]) * MyKey2[i] % 36)].ToString();

            //Tout en majuscule
            return MyKey3.ToUpper();
        }

        public bool TestKey(string Key, string PublicKey)
        {
            //Fonction de test d'un clé
            //Simple, je prends les 4 premiers caractère et j'en génère une nouvelle clé
            //Que je n'ai qu'a comparer avec celle que l'utilisateur veux tester

            int[] ValueKey = new int[KeyLengh];

            Key = Key.ToUpper();
            if (Key.Length == KeyLengh)
            {
                for (int i = 0; i < NbRandomChar; i++)
                {
                    if (char.IsLetter(Key[i]))
                        ValueKey[i] = Key[i] - 55;
                    else
                        ValueKey[i] = Convert.ToInt32(Key[i].ToString());
                }
                return (Key == GenKey(ValueKey, PublicKey));
            }
            else
                return false;
        }

        public string MakeKey(string PublicKey)
        {
            //Genère 4 nombre aléatoire qui serviront pour la génération de la clé
            int[] ValueKey = new int[KeyLengh];
            for (int i = 0; i < NbRandomChar; i++)
            {
                ValueKey[i] = MonRnd.Next(NbChar - 1) + 1;
            }
            return GenKey(ValueKey, PublicKey); //Génère la clé
        }

        private string CreateMD5Hash(string input)
        {
            //Fonction pour créer un MD5 (pas de moi)

            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
                // To force the hex string to lower-case letters instead of
                // upper-case, use he following line instead:
                // sb.Append(hashBytes[i].ToString("x2")); 
            }
            return sb.ToString();
        }

        private string CreateSHAHash(string text)
        {
            //Fonction pour créer un SHA (pas de moi)

            // Gets the SHA1 hash for text
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] data = Encoding.Default.GetBytes(text);
            byte[] hash = sha1.ComputeHash(data);
            // Transforms as hexa
            string hexaHash = "";
            foreach (byte b in hash)
            {
                hexaHash += String.Format("{0:x2}", b);
            }
            // Returns SHA1 hexa hash
            return hexaHash;
        }
    }
}
