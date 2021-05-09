using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi_rotX
{
    class Program
    {

        private static char[] alfabeti = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static int key; // ne kete variables e ruajme celesin
        static void Main(string[] args)
        {
            string plaintext; //ne kete variabel e ruajme plaintextin qe e shenon perdoruesi
            string pergjigjja = ""; //ne kete variables e ruajme pergjigjen se a deshiron perdoruesi me dekriptu ciphertextin e fituar
            //I kerkojme perdoruesit me shenu plaintextin
            Console.WriteLine("Sheno plaintextin:");
            plaintext = Console.ReadLine();

            Console.WriteLine();

            //I kerkojme perdoruesit me shenu celesin
            Console.WriteLine("Shenoni celsin:");
            key = Convert.ToInt32(Console.ReadLine());  // celesi qe ne fillim eshte string e kthejme ne vlere ekuivalente ne integer

            Console.WriteLine();
            string pergjigjja = "";

            StringBuilder encrypted = new StringBuilder(); // plaintexti i enkriptuar
            StringBuilder decrypted = new StringBuilder(); // ciphertexti i dekriptuar

            while (true)
            {

                encrypted = Encrypt(key, plaintext);

                Console.WriteLine("Plaintexti i enkriptuar eshte: " + encrypted);
                // Console.WriteLine(encrypted);
                Console.WriteLine();

                Console.Write("Deshironi ta dekriptoni ciphertextin:Shtyp yes ose no ");
                pergjigjja = Console.ReadLine().ToLower();

                if (pergjigjja.Equals("yes"))
                {
                    decrypted = Decrypt(key, encrypted.ToString());
                }
                else
                {
                    break;
                }
                Console.WriteLine("Teksti i dekriptuar eshte: " + decrypted);
                // Console.Write(decrypted);

               
                Console.Write("Deshironi ta dekriptoni ciphertextin:Shtyp po ose jo ");
                Console.WriteLine();
                pergjigjja = Console.ReadLine().ToLower();
                if (pergjigjja.Equals("jo"))
                {
                    break;
                }
                else
                {
                    decrypted = Decrypt(key, encrypted.ToString());
                }
                Console.WriteLine("Teksti i dekriptuar eshte: " + decrypted);
                break;
            }
        }
        public static StringBuilder Encrypt(int key, string plaintext)
        {

            StringBuilder encryption = new StringBuilder(); //plaintexti i enkriptuar
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
   
    public static StringBuilder Decrypt(int key, string plaintext)
    {

        StringBuilder decryption = new StringBuilder();
        char[] ciphertextArray = plaintext.ToCharArray();  // ne kete vektor i ruajme karakteret e ciphertextit
        char keyedLetter = ' ';// ruhet shkronja gjate shiftimit
        int letter = 0; // shkronja e re qe fitohet

        for (int i = 0; i < ciphertextArray.Length; i++)
        {


            if (ciphertextArray[i].Equals(' '))
            {
                decryption.Append(ciphertextArray[i]);
                Console.WriteLine(decryption);
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
