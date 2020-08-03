using System;
using System.Collections.Generic;
using System.Linq;

namespace PasteToFile.DataTypes
{
    /// <summary>
    /// Supported File Types.
    /// </summary>
    public enum FileType
    {
        Text,
        Image
    }

    /// <summary>
    /// Supported Text file extensions.
    /// </summary>
    public enum TextFileExtension
    {
        txt,
        json
    }

    /// <summary>
    /// Supported Image file extensions.
    /// </summary>
    public enum ImageFileExtension
    {
        png,
        jpg,
        bmp,
        gif,
    }

    public static class Output
    {
        /// <summary>
        /// Returns a list string containing all supported file types.
        /// </summary>
        /// <returns>A list string of all supported file types.</returns>
        public static List<string> FileTypes()
        {
            var fileTypes = new List<string>();
            fileTypes.AddRange(from FileType fileType in Enum.GetValues(typeof(FileType)) select fileType.ToString());

            return fileTypes;
        } 

        /// <summary>
        /// Returns a list string containing all supported Text file extensions.
        /// </summary>
        /// <returns>A list string of all supported Text file extensions.</returns>
        public static List<string> TextExtensions()
        {
            var extensions = new List<string>();
            extensions.AddRange(from TextFileExtension extension in Enum.GetValues(typeof(TextFileExtension)) select extension.ToString());

            return extensions;
        }

        /// <summary>
        /// Returns a list string containing all supported Image file extensions.
        /// </summary>
        /// <returns>A list string of all supported Image file extensions.</returns>
        public static List<string> ImageExtensions()
        {
            var extensions = new List<string>();
            extensions.AddRange(from ImageFileExtension extension in Enum.GetValues(typeof(ImageFileExtension)) select extension.ToString());

            return extensions;
        }
    }
}
