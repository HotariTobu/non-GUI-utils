using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URLOpener
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            Clipboard.GetText().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(x =>
             {
                 if (x.StartsWith("http"))
                 {
                     using (var pro = new Process())
                     {
                         pro.StartInfo = new ProcessStartInfo(x.Trim());
                         pro.Start();
                     }
                 }
             });
        }
    }
}
