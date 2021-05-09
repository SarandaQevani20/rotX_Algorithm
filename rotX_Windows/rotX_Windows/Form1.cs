using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotX_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            string plaintext = textBox1.Text;
            textBox2.Text = rotX.Encrypt(key, plaintext);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBox4.Text);
            string ciphertext = textBox2.Text;
            textBox1.Text = rotX.Decrypt(key, ciphertext);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static char[] alfabeti = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public class rotX
        {
            public static string Encrypt(int key, string plaintext)
            {

                string encryption = " ";
                char[] plaintextArray = plaintext.ToCharArray(); //ne kete vektor i kemi ru te gjitha karakteret e plaintextit
                char keyedLetter = ' '; //ruhet shkronja pas shiftimit

                for (int i = 0; i < plaintextArray.Length; i++) // iterojme pergjate vektorit
                {

                    //kontrollojme nese brenda plaintextit ka hapesira,nese po ato hapesira i percillen edhe ciphertextit
                    if (plaintextArray[i].Equals(' '))
                    {
                        encryption.Append(plaintextArray[i]);
                        continue;
                    }

                    for (int j = 0; j < alfabeti.Length; j++)
                    {

                        if (plaintextArray[i].Equals(alfabeti[j]))   // kontrollohet nese shkronjat e plaintextit gjenden ne alfabet
                        {

                            //merr shkronjen ne vargun alfabeti e cila është e barabarte me shkronjen aktuale në vargun e plaintextit 
                            //shton vleren e celesit ne vleren  aktuale të indeksit të vargut alfabeti
                            //% 26 në të per tu siguruar qe eshte gjithmone ne alfabet dhe nuk del jashte kufijve
                            keyedLetter = alfabeti[(j + key) % 26];
                            encryption.Append(keyedLetter);

                        }

                    }

                }

                return encryption;
            }

            public static string Decrypt(int key, string ciphertext)
            {

                string decryption =" ";
                char[] ciphertextArray = ciphertext.ToCharArray();  // ne kete vektor i ruajme karakteret e ciphertextit
                char keyedLetter = ' ';// ruhet shkronja gjate shiftimit
                int letter = 0; // shkronja e re qe fitohet

                for (int i = 0; i < ciphertextArray.Length; i++)
                {


                    if (ciphertextArray[i].Equals(' '))
                    {
                        decryption.Append(ciphertextArray[i]);
                       
                        continue;
                    }

                    for (int j = 0; j < alfabeti.Length; j++)
                    {

                        if (ciphertextArray[i].Equals(alfabeti[j]))
                        {
                            letter = (j - key) % 26;

                            // perserisa moduli i nje numri negativ eshte nje numer negativ
                            // shtimi i 26 në numrin negativ ka të njëjtin rezultat si te fitohej numer pozitiv
                            if (letter < 0)
                            {
                                letter += 26;
                            }

                            keyedLetter = alfabeti[letter];
                            decryption.Append(keyedLetter);

                        }

                    }

                }

                return decryption;
            }

           

        }
    }
}
