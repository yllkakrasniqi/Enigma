using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Enigma : Form
    {
        public Enigma()
        {
            InitializeComponent();
        }

        Char[] Rotor1 = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
        Char[] Rotor2 = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' };
        Char[] Rotor3 = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' };
        Char[] Rotor4 = { 'E', 'S', 'O', 'V', 'P', 'Z', 'J', 'A', 'Y', 'Q', 'U', 'I', 'R', 'H', 'X', 'L', 'N', 'F', 'T', 'G', 'K', 'D', 'C', 'M', 'W', 'B' };
        Char[] Rotor5 = { 'V', 'Z', 'B', 'R', 'G', 'I', 'T', 'Y', 'U', 'P', 'S', 'D', 'N', 'H', 'L', 'X', 'A', 'W', 'M', 'J', 'Q', 'O', 'F', 'E', 'C', 'K' };
        Char[] Rotor6 = { 'J', 'P', 'G', 'V', 'O', 'U', 'M', 'F', 'Y', 'Q', 'B', 'E', 'N', 'H', 'Z', 'R', 'D', 'K', 'A', 'S', 'X', 'L', 'I', 'C', 'T', 'W' };
        Char[] Rotor7 = { 'N', 'Z', 'J', 'H', 'G', 'R', 'C', 'X', 'M', 'Y', 'S', 'W', 'B', 'O', 'U', 'F', 'A', 'I', 'V', 'L', 'P', 'E', 'K', 'Q', 'D', 'T' };
        Char[] Rotor8 = { 'F', 'K', 'Q', 'H', 'T', 'L', 'X', 'O', 'C', 'B', 'J', 'S', 'P', 'D', 'Z', 'R', 'A', 'M', 'E', 'W', 'N', 'I', 'U', 'Y', 'G', 'V' };

        Char[] ReflectorA = { 'E', 'J', 'M', 'Z', 'A', 'L', 'Y', 'X', 'V', 'B', 'W', 'F', 'C', 'R', 'Q', 'U', 'O', 'N', 'T', 'S', 'P', 'I', 'K', 'H', 'G', 'D' };
        Char[] ReflectorB = { 'Y', 'R', 'U', 'H', 'Q', 'S', 'L', 'D', 'P', 'X', 'N', 'G', 'O', 'K', 'M', 'I', 'E', 'B', 'F', 'Z', 'C', 'W', 'V', 'J', 'A', 'T' };
        Char[] ReflectorC = { 'F', 'V', 'P', 'J', 'I', 'A', 'O', 'Y', 'E', 'D', 'R', 'Z', 'X', 'W', 'G', 'C', 'T', 'K', 'U', 'Q', 'S', 'B', 'N', 'M', 'H', 'L' };
        Char[] r1, r2, r3, r;

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            if (cmbRotor1_1.SelectedItem == "Rotor I")
            {
                r1 = Rotor1;
            }
            else if (cmbRotor1_1.SelectedItem == "Rotor II")
            {
                r1 = Rotor2;
            }
            else if (cmbRotor1_1.SelectedItem.ToString() == "Rotor III")
            {
                r1 = Rotor3;
            }
            else if (cmbRotor1_1.SelectedItem == "Rotor IV")
            {
                r1 = Rotor4;
            }
            else if (cmbRotor1_1.SelectedItem.ToString() == "Rotor V")
            {
                r1 = Rotor5;
            }
            else if (cmbRotor1_1.SelectedItem == "Rotor VI")
            {
                r1 = Rotor6;
            }
            else if (cmbRotor1_1.SelectedItem.ToString() == "Rotor VII")
            {
                r1 = Rotor7;
            }
            else if (cmbRotor1_1.SelectedItem.ToString() == "Rotor VIII")
            {
                r1 = Rotor8;
            }
            if (cmbRotor2_1.SelectedItem.ToString() == "Rotor I")
            {
                r2 = Rotor1;
            }
            else if (cmbRotor2_1.SelectedItem.ToString() == "Rotor II")
            {
                r2 = Rotor2;
            }
            else if (cmbRotor2_1.SelectedItem.ToString() == "Rotor III")
            {
                r2 = Rotor3;
            }
            else if (cmbRotor2_1.SelectedItem == "Rotor IV")
            {
                r2 = Rotor4;
            }
            else if (cmbRotor2_1.SelectedItem.ToString() == "Rotor V")
            {
                r2 = Rotor5;
            }
            else if (cmbRotor2_1.SelectedItem == "Rotor VI")
            {
                r2 = Rotor6;
            }
            else if (cmbRotor2_1.SelectedItem.ToString() == "Rotor VII")
            {
                r2 = Rotor7;
            }
            else if (cmbRotor2_1.SelectedItem.ToString() == "Rotor VIII")
            {
                r2 = Rotor8;
            }
            if (cmbRotor3_1.SelectedItem.ToString() == "Rotor I")
            {
                r3 = Rotor1;
            }
            else if (cmbRotor3_1.SelectedItem.ToString() == "Rotor II")
            {
                r3 = Rotor2;
            }
            else if (cmbRotor3_1.SelectedItem.ToString() == "Rotor III")
            {
                r3 = Rotor3;
            }
            else if (cmbRotor3_1.SelectedItem == "Rotor IV")
            {
                r3 = Rotor4;
            }
            else if (cmbRotor3_1.SelectedItem.ToString() == "Rotor V")
            {
                r3 = Rotor5;
            }
            else if (cmbRotor3_1.SelectedItem == "Rotor VI")
            {
                r3 = Rotor6;
            }
            else if (cmbRotor3_1.SelectedItem.ToString() == "Rotor VII")
            {
                r3 = Rotor7;
            }
            else if (cmbRotor3_1.SelectedItem.ToString() == "Rotor VIII")
            {
                r3 = Rotor8;
            }
            if (cmbReflector1.SelectedItem.ToString() == "Reflector A")
            {
                r = ReflectorA;
            }
            else if (cmbReflector1.SelectedItem.ToString() == "Reflector B")
            {
                r = ReflectorB;
            }
            else if (cmbReflector1.SelectedItem.ToString() == "Reflector C")
            {
                r = ReflectorC;
            }
            int position1 = (int)nudPosition1.Value;
            int position2 = (int)nudPosition2.Value;
            int position3 = (int)nudPosition3.Value;
            txtTektiiDekriptuar.Text = Enkripto(txtCiphertext1.Text, r1, r2, r3, r, position1, position2, position3);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbReflector.SelectedIndex = 1;
            cmbRotor1.SelectedIndex = 0;
            cmbRotor2.SelectedIndex = 1;
            cmbRotor3.SelectedIndex = 2;
            cmbReflector1.SelectedIndex = 1;
            cmbRotor1_1.SelectedIndex = 0;
            cmbRotor2_1.SelectedIndex = 1;
            cmbRotor3_1.SelectedIndex = 2;
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            
            if (cmbRotor1.SelectedItem == "Rotor I")
            {
                r1 = Rotor1;
            }
            else if (cmbRotor1.SelectedItem == "Rotor II")
            {
                r1 = Rotor2;
            }
            else if (cmbRotor1.SelectedItem.ToString() == "Rotor III")
            {
                r1 = Rotor3;
            }
            else if (cmbRotor1.SelectedItem == "Rotor IV")
            {
                r1 = Rotor4;
            }
            else if (cmbRotor1.SelectedItem.ToString() == "Rotor V")
            {
                r1 = Rotor5;
            }
            else if (cmbRotor1.SelectedItem == "Rotor VI")
            {
                r1 = Rotor6;
            }
            else if (cmbRotor1.SelectedItem.ToString() == "Rotor VII")
            {
                r1 = Rotor7;
            }
            else if (cmbRotor1.SelectedItem.ToString() == "Rotor VIII")
            {
                r1 = Rotor8;
            }
            if (cmbRotor2.SelectedItem.ToString() == "Rotor I")
            {
                r2 = Rotor1;
            }
            else if (cmbRotor2.SelectedItem.ToString() == "Rotor II")
            {
                r2 = Rotor2;
            }
            else if (cmbRotor2.SelectedItem.ToString() == "Rotor III")
            {
                r2 = Rotor3;
            }
            else if (cmbRotor1.SelectedItem == "Rotor IV")
            {
                r2 = Rotor4;
            }
            else if (cmbRotor2.SelectedItem.ToString() == "Rotor V")
            {
                r2 = Rotor5;
            }
            else if (cmbRotor2.SelectedItem == "Rotor VI")
            {
                r2 = Rotor6;
            }
            else if (cmbRotor2.SelectedItem.ToString() == "Rotor VII")
            {
                r2 = Rotor7;
            }
            else if (cmbRotor2.SelectedItem.ToString() == "Rotor VIII")
            {
                r2 = Rotor8;
            }
            if (cmbRotor3.SelectedItem.ToString() == "Rotor I")
            {
                r3 = Rotor1;
            }
            else if (cmbRotor3.SelectedItem.ToString() == "Rotor II")
            {
                r3 = Rotor2;
            }
            else if (cmbRotor3.SelectedItem.ToString() == "Rotor III")
            {
                r3 = Rotor3;
            }
            else if (cmbRotor3.SelectedItem == "Rotor IV")
            {
                r3 = Rotor4;
            }
            else if (cmbRotor3.SelectedItem.ToString() == "Rotor V")
            {
                r3 = Rotor5;
            }
            else if (cmbRotor3.SelectedItem == "Rotor VI")
            {
                r3 = Rotor6;
            }
            else if (cmbRotor3.SelectedItem.ToString() == "Rotor VII")
            {
                r3 = Rotor7;
            }
            else if (cmbRotor3.SelectedItem.ToString() == "Rotor VIII")
            {
                r3 = Rotor8;
            }
            if (cmbReflector.SelectedItem.ToString() == "Reflector A")
            {
                r = ReflectorA;
            }
            else if (cmbReflector.SelectedItem.ToString() == "Reflector B")
            {
                r = ReflectorB;
            }
            else if (cmbReflector.SelectedItem.ToString() == "Reflector C")
            {
                r = ReflectorC;
            }
            int position1 = (int)nudPosition1.Value;
            int position2 = (int)nudPosition2.Value;
            int position3 = (int)nudPosition3.Value;
            txtCiphertext.Text = Enkripto(txtPlaintext.Text, r1, r2, r3, r, position1, position2, position3);
        }

        public string Enkripto(string plaintext,Char[] r1, Char[] r2, Char[] r3, Char[] r,int position1, int position2, int position3)
        {
            string plainteksti = plaintext.ToUpper();
            StringBuilder rez = new StringBuilder(plainteksti);
            
            int i = 0;
            int pos1 = position1;
            int pos2 = position2- 1;
            int pos3 = position3 - 1;

            
            for (i = 0; i < plainteksti.Length; i++)
            {
                try
                {
                    int n1 = ((int)plainteksti[i]) + pos1 + i;
                    int n2 = ((int)r1[(n1 - 65 + 26) % 26]) - i - pos1 + pos2;
                    int n3 = ((int)r2[(n2 - 65 + 26) % 26]) - pos2 + pos3;
                    int n4 = ((int)r3[(n3 - 65 + 26) % 26]) - pos3;
                    for (int j = 0; j < r3.Length; j++)
                    {
                        if (r3[j] == (char)((int)r[n4 - 65] + pos3))
                        {
                            for (int k = 0; k < r2.Length; k++)
                            {
                                if (r2[k] == (Char)(j + 65 + pos2 - pos3))
                                {
                                    for (int l = 0; l < r1.Length; l++)
                                    {
                                        if (r1[l] == (Char)(((k + pos1 + i - pos2 + 26) % 26) + 65))
                                        {
                                            rez[i] = (Char)(((l - i - pos1 + 26) % 26) + 65);

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    rez[i] = plainteksti[i];
                }
                if ((i + 1) % 16 == 0)
                {
                    pos2++;
                }
                if ((i + 1) % 104 == 0)
                {
                    pos3++;
                }
            }
            return rez.ToString();
        }
    }
}