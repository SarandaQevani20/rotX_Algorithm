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
