using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFileNames
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            string text = "";

            void add(string path, int level)
            {
                for (int i = 0; i < level; i++)
                {
                    text += "\t";
                }
                text += Path.GetFileName(path) + "\n";
            }

            void scan(string path, int level)
            {
                foreach (string child in Directory.GetFiles(path))
                {
                    add(child, level);
                }

                foreach (string directory in Directory.GetDirectories(path))
                {
                    add(directory, level);
                    scan(directory, level + 1);
                }
            }

            string rootPath = Clipboard.GetText();
            if (Directory.Exists(rootPath))
            {
                scan(rootPath, 0);
            }

            Clipboard.SetText(text);
        }
    }
}
