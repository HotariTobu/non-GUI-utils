using System;
using System.Windows.Forms;

namespace DDXXYY
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            string f = Clipboard.GetText();
            Clipboard.SetText($"d/dx {f}, d/dy {f},d^2/dxdx {f}, d^2/dydx {f}, d^2/dxdy {f}, d^2/dydy {f}");
        }
    }
}
