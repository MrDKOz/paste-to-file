using System.IO;
using System.Windows.Forms;

namespace PasteToFile.Handlers
{
    public class Text
    {
        private string _destinationPath;

        public Text(string destinationPath)
        {
            _destinationPath = destinationPath;
        }

        public void Paste()
        {
            string fileToCreate = Path.Combine(_destinationPath, "test.txt");

            File.WriteAllText(fileToCreate, Clipboard.GetText());
        }
    }
}
