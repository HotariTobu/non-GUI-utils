using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace CopyExpansion
{
    class MainPoint
    {
        [STAThread]
        static void Main()
        {
            double threshold = 1;
            var items = Clipboard.GetHistoryItemsAsync().GetResults().Items;
            DateTimeOffset last = items.FirstOrDefault().Timestamp;
            var newItems = items.TakeWhile(item =>
            {
                DateTimeOffset now = item.Timestamp;
                bool result = last.Subtract(now).TotalMinutes < threshold;
                last = now;
                return result;
            });
            var contents = newItems.Select(item => item.Content).Where(content => content.Contains(StandardDataFormats.Text)).Select(content => content.GetTextAsync().GetResults());
            DataPackage package = new DataPackage();
            package.RequestedOperation = DataPackageOperation.Copy;
            package.SetText(string.Join("\n", contents));
            Clipboard.SetContent(package);
            Clipboard.Flush();
        }
    }
}
