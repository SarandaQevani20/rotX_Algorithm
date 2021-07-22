using System;
using System.Collections.Generic;
using System.Text;
using ExpressEncription;
namespace ServerSide
{
    class generator
    {
        static void main (string []args)
        {

            ExpressEncription.RSAEncription.MakeKey(@"C:\Users\freec\Desktop\Data Security Project\public.key", @"C:\Users\freec\Desktop\Data Security Project\private.key");
        }
    }
}
