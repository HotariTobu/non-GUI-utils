using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineUpWords
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            var vs = Clipboard.GetText().Split(',');
            int length = vs.Length;
            
            int limit = 1;
            var indices = new int[length - 1];
            for (int i = 2; i <= length; i++)
            {
                indices[i - 2] = limit;
                limit *= i;
            }

            var re = new string[limit];

            for (int i = 0; i < limit; i++)
            {
                var copy = vs.ToList();

                for (int j = length; j > 1; j--)
                {
                    int index = i / indices[j - 2] % j;
                    re[i] += copy[index] + " ";
                    copy.RemoveAt(index);
                }
                re[i] += copy[0];
            }

            Clipboard.SetText(string.Join("\r\n", re));
        }
    }
}
