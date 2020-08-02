using System;
using System.Text;

namespace PasteToFile.Helpers
{
    /// <summary>
    /// The file types available to use.
    /// </summary>
    public enum FileType
    {
        Text,
        Image
    }

    public class FilenameMask
    {
        //private readonly FileType _fileType;

        //public FilenameMask(FileType fileType)
        //{
        //    _fileType = fileType;
        //}

        /// <summary>
        /// Returns the filename with the mask applied.
        /// </summary>
        /// <param name="input">The given string to preview</param>
        /// <returns>The filename with the mask applied.</returns>
        public string Generate(string input)
        {
            var stringBuilder = new StringBuilder(input);

            stringBuilder.Replace("%y", DateTime.Now.Year.ToString());
            stringBuilder.Replace("%mo", DateTime.Now.Month.ToString());
            stringBuilder.Replace("%d", DateTime.Now.Day.ToString());
            stringBuilder.Replace("%h", DateTime.Now.Hour.ToString());
            stringBuilder.Replace("%mi", DateTime.Now.Minute.ToString());
            stringBuilder.Replace("%s", DateTime.Now.Second.ToString());

            return stringBuilder.ToString();
        }
    }
}
