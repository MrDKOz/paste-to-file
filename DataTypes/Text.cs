using PasteToFile.Helpers;
using System.IO;
using System.Windows.Forms;

namespace PasteToFile.DataTypes
{
    public class Text
    {
        private readonly Settings _settings = new Settings(FileType.Text);
        private readonly FilenameMask _filenameMask = new FilenameMask();

        /// <summary>
        /// Handle the creation of an text file, fetch settings, and display output choices dialog.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        public void Handle(string outputDirectory)
        {
            if (_settings.ShowConfig)
                using (var fileOutput = new FileOutput(FileType.Text, outputDirectory))
                    fileOutput.ShowDialog();
            else
            {
                var filename = _filenameMask.Generate(_settings.FilenameMask);
                var filenameExtension = _settings.FilenameExtension;
                var fullOutputPath = Path.Combine(outputDirectory, $"{filename}.{filenameExtension}");

                WriteOut(fullOutputPath);
            }
        }

        /// <summary>
        /// Writes the text within the clipboard to the given file location.
        /// </summary>
        /// <param name="fullFilePath">The path to write the text file to.</param>
        public void WriteOut(string fullFilePath)
        {
            File.WriteAllText(fullFilePath, Clipboard.GetText());
        }
    }
}
