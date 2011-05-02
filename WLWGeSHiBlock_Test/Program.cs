using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using WLWGeSHiBlock;

namespace WLWGeSHiBlock_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GeShiBlockPlugin geshi = new GeShiBlockPlugin();
            
            String newContent = "";
            geshi.CreateContent(null, ref newContent);

            Console.WriteLine(newContent);
        }
    }
}
