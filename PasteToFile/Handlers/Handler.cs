using System.Windows.Forms;

namespace PasteToFile.Handlers
{
    public class Handler
    {
        public string DestinationPath;

        public Handler(string destinationPath)
        {
            DestinationPath = destinationPath;
        }

        public void HandleRequest()
        {
            if (Clipboard.ContainsText())
            {
                var text = new Text(DestinationPath);
                text.Paste();
            }
        }
    }
}
