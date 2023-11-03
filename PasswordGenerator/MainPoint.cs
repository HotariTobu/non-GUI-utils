using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            int limit = 0;
            if (!int.TryParse(Clipboard.GetText(), out limit))
            {
                limit = 16;
            }

            Random rand = new Random();
            string password = string.Empty;
            for (int i = 0; i < limit; i++)
            {
                password += (char)rand.Next(33, 122);
            }

            Clipboard.SetText(password);
        }
    }
}
