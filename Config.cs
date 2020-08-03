using PasteToFile.Helpers;
using System;
using System.Windows.Forms;
using PasteToFile.DataTypes;

namespace PasteToFile
{
    public partial class Config : Form
    {
        private FileType _fileTypeFocused = FileType.Text;
        private Settings _settings;
        private readonly FilenameMask _filenameMask = new FilenameMask();
        private readonly ContextEntry _contextEntry = new ContextEntry();

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
            cboxFileTypes.DataSource = Output.FileTypes();
        }

        /// <summary>
        /// Loads the supported extensions for the selected file type.
        /// </summary>
        private void LoadExtensions()
        {
            var bindingSource = new BindingSource();

            switch (_fileTypeFocused)
            {
                case FileType.Text:
                    bindingSource.DataSource = Output.TextExtensions();
                    break;
                case FileType.Image:
                    bindingSource.DataSource = Output.ImageExtensions();
                    break;
                default:
                    throw new Exception("Invalid File Type passed when fetching extensions.");
            }

            cboxExtension.DataSource = bindingSource;
        }

        /// <summary>
        /// Loads the settings for the selected tab.
        /// </summary>
        private void LoadAndApplySettings()
        {
            LoadExtensions();

            _settings = new Settings(_fileTypeFocused);

            // Configure Install/Uninstall context entry button
            btnContextMenu.Text = _contextEntry.CheckIfRegistered()
                ? "Remove Right Click Context Entry"
                : "Install Right Click Context Entry";

            // General UI
            lblInformation.Text = $"Settings related to the output when {_fileTypeFocused} data is detected in your clipboard.";

            tboxFilenameMask.Text = _settings.FilenameMask;
            lblFilenameMaskPreview.Text = _filenameMask.Generate(tboxFilenameMask.Text);
            cboxExtension.Text = _settings.FilenameExtension;
            chkAskForOptionsEverytime.Checked = _settings.ShowConfig;
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
            _settings.FilenameExtension = cboxExtension.Text;
            _settings.ShowConfig = chkAskForOptionsEverytime.Checked;

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

        /// <summary>
        /// Creates or removes the context entry, depending on if it already exists
        /// </summary>
        private void btnContextMenu_Click(object sender, EventArgs e)
        {
            string message = _contextEntry.CheckIfRegistered()
                ? "Are you sure you wish to remove the right click context menu item?"
                : "Are you sure you wish to create the right click context menu item?";

            var dlgResult = MessageBox.Show(
                message,
                "Context Menu Entry",
                MessageBoxButtons.YesNo);

            if (dlgResult == DialogResult.Yes)
            {
                _contextEntry.Toggle();
                LoadAndApplySettings();
            }
        }
    }
}
