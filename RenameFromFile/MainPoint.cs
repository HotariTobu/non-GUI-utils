using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFromFile
{
    class MainPoint
    {
        [STAThread]
        static void Main(string[] args)
        {
            string file = args[0];
            string directory = Clipboard.GetText();
            if (File.Exists(file) && Directory.Exists(directory))
            {
                string[] names = File.ReadAllLines(file).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                string[] files = Directory.GetFiles(directory);
                if (names.Length == files.Length)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        string name = Path.Combine(directory, names[i]);
                        while (File.Exists(name))
                        {
                            name = Path.Combine(directory, Path.GetFileNameWithoutExtension(name) + "_" + Path.GetExtension(names[i]));
                        }
                        File.Move(files[i], name);
                    }
                }
            }
        }
    }
}
