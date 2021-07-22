
using System;
using System.IO;
using System.Net.Sockets;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ServerSide
{

    class program
    {






        public static string Extraction(LinkedList<string> e, string name)
        {

            foreach (string str in e)
            {

                
                if (str.Substring(0, 4).Contains(name))
                {
                    return str;
                    break;
                }


            }
            return "null";
        }
        public int ReceiveTimeout { get; set; }
        static void Register(string n, string p, string m, string inv, int y, double e)
        {



            XElement xe;

            if (File.Exists("C:\\Users\\freec\\Desktop\\Data Security Project\\Data.xml"))
                xe = XElement.Load("C:\\Users\\freec\\Desktop\\Data Security Project\\Data.xml");
            else
                xe = new XElement("User");
            XElement newUser = new XElement("User");
            newUser.Add(new XAttribute("Name", n));
            newUser.Add(new XElement("Type_Of_Invoice", inv));
            newUser.Add(new XElement("Password", p));
            newUser.Add(new XElement("year", y.ToString()));
            newUser.Add(new XElement("month", m));
            newUser.Add(new XElement("euros", e.ToString()));
            newUser.Add(new XElement("details", n + "," + inv + "," + m + "," + y.ToString() + "," + e.ToString()));
            xe.Add(newUser);
            xe.Save("C:\\Users\\freec\\Desktop\\Data Security Project\\Data.xml");


        }
        static void Main(string[] args)
        {



            LinkedList<string> Name = new LinkedList<string>();
            LinkedList<string> Month = new LinkedList<string>();
            LinkedList<string> Invoice = new LinkedList<string>();
            LinkedList<int> year = new LinkedList<int>();
            LinkedList<Double> Euro = new LinkedList<Double>();
            LinkedList<string> Password = new LinkedList<string>();
            LinkedList<string> Super = new LinkedList<string>();


            XmlTextReader xtr = new XmlTextReader("C:\\Users\\freec\\Desktop\\Data Security Project\\Data.xml");


            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Name")
                {
                    string s1 = xtr.ReadElementContentAsString();
                    Name.AddLast(s1);
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Password")
                {
                    string s2 = xtr.ReadElementContentAsString();
                    string p = Class1.hashPassword(s2);
                    Password.AddLast(p);

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Type_Of_Invoice")
                {
                    string s3 = xtr.ReadElementContentAsString();
                    Invoice.AddLast(s3);

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "year")
                {
                    string s4 = xtr.ReadElementContentAsString();

                    year.AddLast(Int32.Parse(s4));

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "month")
                {
                    string s5 = xtr.ReadElementContentAsString();
                    Month.AddLast(s5);

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "euros")
                {
                    string s6 = xtr.ReadElementContentAsString();
                    Euro.AddLast(Double.Parse(s6));

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "details")
                {
                    string s7 = xtr.ReadElementContentAsString();
                    Super.AddLast(s7);
                    

                }


            }


            xtr.Close();






            TcpListener server = new TcpListener(8888);

            server.Start();


            Console.WriteLine("Server Started and waiting");
            Socket socketForClients = server.AcceptSocket();
            NetworkStream ns = new NetworkStream(socketForClients);
            if (socketForClients.Connected)
            {

                StreamWriter sw = new StreamWriter(ns);

                Console.WriteLine("Server>> Welcome Client. ");
                sw.WriteLine("Welcome User");
                sw.Flush();


                StreamReader sr = new StreamReader(ns);
                string x = sr.ReadLine();
                StreamReader s1 = new StreamReader(ns);
                StreamReader s2 = new StreamReader(ns);
                StreamReader s3 = new StreamReader(ns);
                StreamReader s4 = new StreamReader(ns);
                StreamReader s5 = new StreamReader(ns);
                StreamReader s6 = new StreamReader(ns);