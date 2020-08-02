using PasteToFile.Helpers;
using System.IO;
using System.Windows.Forms;

namespace PasteToFile.DataTypes
{
    public static class Image
    {
        private static readonly Settings Settings = new Settings(FileType.Image);
        private static readonly FilenameMask FilenameMask = new FilenameMask();

        /// <summary>
        /// Handle the creation of an image file, fetch settings, and display output choices dialog.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        public static void Handle(string outputDirectory)
        {
            var filename = FilenameMask.Generate(Settings.FilenameMask);
            var filenameExtension = Settings.FilenameExtension;
            var fullOutputPath = Path.Combine(outputDirectory, $"{filename}.{filenameExtension}");

            WriteOut(fullOutputPath);
        }

        /// <summary>
        /// Writes the image within the clipboard to the given file location.
        /// </summary>
        /// <param name="fullOutputPath">The path to write the image file to.</param>
        private static void WriteOut(string fullOutputPath)
        {
            Clipboard.GetImage()?.Save(fullOutputPath);
        }
    }
}
