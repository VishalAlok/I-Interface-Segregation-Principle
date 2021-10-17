using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle
{
    class HPLaser : iPrintScanContent
    {
        public bool printContent(string Content)
        {
            Console.WriteLine("print done");
            return true;
        }
        public bool ScanContent(string Content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
        //public bool FaxContent(string Content)
        //{
        //    Console.WriteLine("Fax done");
        //    return true;
        //}

        //public bool PhotoCopyContent(string Content)
        //{
        //    Console.WriteLine("PhotoCopy done");
        //    return true;
        //}
        //public bool PrintDuplexConent(string Content)
        //{
        //    Console.WriteLine("print Duplex done");
        //    return true;
        //}

        //public bool ScanContent(string Content)
        //{
        //    Console.WriteLine("Scan done");
        //    return true;
        //}
    }
}
