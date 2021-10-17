using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle
{
    //interface iPrintTask
    //{
    //    bool printContent(string Content);
    //    bool ScanContent(string Content);
    //    bool FaxContent(string Content);
    //    bool PhotoCopyContent(string Content);
    //    bool PrintDuplexConent(string Content);
    //}
    interface iPrintScanContent
    {
        bool printContent(string Content);
        bool ScanContent(string Content);
    }
    interface iFaxContent
    {
        bool FaxContent(string Content);
    }
    interface iPrint
    {
        bool printContent(string Content);
    }
}
