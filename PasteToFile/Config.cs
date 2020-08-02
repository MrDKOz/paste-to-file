using PasteToFile.Helpers;
using System;
using System.Windows.Forms;

namespace PasteToFile
{
    public partial class Config : Form
    {
        private FileType _fileTypeFocused = FileType.Text;
        private Settings _settings;
        private readonly FilenameMask _filenameMask = new FilenameMask();

        private readonly string _version = $"v{System.Reflection.Assembly.GetEntryAssembly()?.GetName().Version}";

        public Config()
        {
            InitializeComponent();

            // Load and display configuration
            LoadFileTypes();
            LoadAndApplySettings();

            // Show version
            lblVersion.Text = _version;
        }

        /// <summary>
        /// Loads the file types and displays them in the drop down.
        /// </summary>
        private void LoadFileTypes()
        {
            foreach (FileType fileType in Enum.GetValues(typeof(FileType)))
                cboxFileTypes.Items.Add(fileType);

            cboxFileTypes.SelectedIndex = 0;
        }

        /// <summary>
        /// Loads the settings for the selected tab.
        /// </summary>
        private void LoadAndApplySettings()
        {
            _settings = new Settings(_fileTypeFocused);

            lblInformation.Text = $"Settings related to the output when {_fileTypeFocused} data is detected in your clipboard.";

            tboxFilenameMask.Text = _settings.FilenameMask;
            lblFilenameMaskPreview.Text = _filenameMask.Generate(tboxFilenameMask.Text);
            tboxFileExtension.Text = _settings.FilenameExtension;
            chkChooseExtensionEverytime.Checked = _settings.ChooseExtension;
        }

        /// <summary>
        /// Update the preview label for the tab currently selected.
        /// </summary>
        private void tboxFilenameMask_KeyUp(object sender, KeyEventArgs e)
        {
            lblFilenameMaskPreview.Text = _filenameMask.Generate(tboxFilenameMask.Text);
        }

        /// <summary>
        /// Keep track of which file type is selected
        /// </summary>
        private void cboxFileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert selected combobox text to enum
            var option = (ComboBox) sender;
            Enum.TryParse(option.Text, out _fileTypeFocused);

            // Update the UI
            LoadAndApplySettings();
        }

        /// <summary>
        /// Save all changes.
        /// </summary>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show(
                "Are you sure you wish to save all changes?",
                "Save all Changes?",
                MessageBoxButtons.YesNo);

            if (dlgResult != DialogResult.Yes) return;

            _settings.FilenameMask = tboxFilenameMask.Text;
            _settings.FilenameExtension = tboxFileExtension.Text;
            _settings.ChooseExtension = chkChooseExtensionEverytime.Checked;

            _settings.Save();
        }

        /// <summary>
        /// Resets all configuration back to the saved values.
        /// </summary>
        private void btnResetToSaved_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show(
                "Are you sure you wish to reset and lose all unsaved changes?",
                "Rest Configuration?",
                MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
                LoadAndApplySettings();
        }

        /// <summary>
        /// Confirms with the user that they wish to exit and lose all unsaved changes.
        /// </summary>
        private void btnCancelAndClose_Click(object sender, EventArgs e)
        {
            var dlgResult = MessageBox.Show(
                "Are you sure you wish to close and lose all unsaved changes?",
                "Exit Paste to File?",
                MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
                Close();
        }

        /// <summary>
        /// Open the appropriate link in the default browser
        /// </summary>
        private void Link_Clicked(object sender, EventArgs e)
        {
            var linkClicked = (LinkLabel) sender;

            System.Diagnostics.Process.Start(
                linkClicked.Text == "@MrDKOz"
                ? "https://twitter.com/mrdkoz"
                : "https://github.com/MrDKOz/paste-to-file");
        }
    }
}
