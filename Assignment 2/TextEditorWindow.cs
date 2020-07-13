using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment_2 {
    public partial class TextEditorWindow : Form {

        LoginWindow loginWindow;
        string name, userType, currentFile;

        public TextEditorWindow(LoginWindow loginWindow, string name, string userType) {
            InitializeComponent();
            this.loginWindow = loginWindow;
            this.name = name;
            this.userType = userType;
        }

        private void TextEditorWindow_Load(object sender, EventArgs e) {
            userLabel.Text = $"Currently logged in as: {name}";
            if (userType == "View") {
                newMenuStripItem.Enabled = false;
                saveMenuStripItem.Enabled = false;
                saveAsMenuStripItem.Enabled = false;
                editMenuStripTab.Enabled = false;
                fontMenuStripTab.Enabled = false;
                richTextBox.Enabled = false;
                topToolStrip.Enabled = false;
                leftToolStrip.Enabled = false;
            }
        }

        private void NewMenuStripItem_Click(object sender, EventArgs e) {
            if (UnsavedChanges() != DialogResult.Cancel) {
                currentFile = string.Empty;
                Text = "Text Editor";
                richTextBox.Text = string.Empty;
            }
        }
        
        private void OpenMenuStripItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open";
            dialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK) {
                currentFile = dialog.FileName;
                Text = currentFile;
                LoadFile();
            }
        }
        
        private void SaveMenuStripItem_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(currentFile))
                SaveFile();
            else
                SaveAsMenuStripItem_Click(sender, e);
        }
        
        private void SaveAsMenuStripItem_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf|" +
                "Plain Text file (*.txt)|*.txt|All file (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK) {
                currentFile = dialog.FileName;
                Text = currentFile;
                SaveFile();
            }
        }

        private void LogOutMenuStripItem_Click(object sender, EventArgs e) {
            if (UnsavedChanges() != DialogResult.Cancel) {
                Close();
                loginWindow.Show();
            }
        }

        private void AboutMenuStripItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Text Editor v1.0.0\nCreator: Adrian Wong", "About",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CutMenuStripItem_Click(object sender, EventArgs e) {
            if (richTextBox.SelectionLength > 0)
                richTextBox.Cut();
        }

        private void CopyMenuStripItem_Click(object sender, EventArgs e) {
            if (richTextBox.SelectionLength > 0)
                richTextBox.Copy();
        }

        private void PasteMenuStripItem_Click(object sender, EventArgs e) {
            richTextBox.Paste();
        }

        private void FontMenuStripItem_Click(object sender, EventArgs e) {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                richTextBox.SelectionFont = new Font(dialog.Font.Name, dialog.Font.Size, dialog.Font.Style);
                fontSizeComboBox.Text = Convert.ToString(dialog.Font.Size);
            }
        }

        private void BoldMenuStripItem_Click(object sender, EventArgs e) {
            Font currentFont = richTextBox.SelectionFont;
            if (currentFont.Bold) {
                if (currentFont.Italic && currentFont.Underline)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic | FontStyle.Underline);
                else if (currentFont.Italic)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else if (currentFont.Underline)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                boldToolStripButton.Checked = false;
            }
            else {
                richTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
                boldToolStripButton.Checked = true;
            }
        }

        private void ItalicMenuStripItem_Click(object sender, EventArgs e) {
            Font currentFont = richTextBox.SelectionFont;
            if (currentFont.Italic) {
                if (currentFont.Bold && currentFont.Underline)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Underline);
                else if (currentFont.Bold)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Underline)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                italicToolStripButton.Checked = false;
            }
            else {
                richTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
                italicToolStripButton.Checked = true;
            }
        }

        private void UnderlineMenuStripItem_Click(object sender, EventArgs e) {
            Font currentFont = richTextBox.SelectionFont;
            if (currentFont.Underline) {
                if (currentFont.Bold && currentFont.Italic)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Italic);
                else if (currentFont.Bold)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Italic)
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else
                    richTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                underlineToolStripButton.Checked = false;
            }
            else {
                richTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
                underlineToolStripButton.Checked = true;
            }
        }

        private void FontSizeComboBox_TextChanged(object sender, EventArgs e) {
            if (richTextBox.SelectionLength > 0 && Single.TryParse(fontSizeComboBox.Text, out Single fontSize)) {
                Font currentFont = richTextBox.SelectionFont;
                if (currentFont != null)
                    richTextBox.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
        }

        private void RichTextBox_MouseClick(object sender, MouseEventArgs e) {
            UpdateFontStyleButtonState();
        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e) {
            UpdateFontStyleButtonState();
        }

        private void SaveFile() {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".rtf")
                File.WriteAllText(currentFile, richTextBox.Rtf);
            else if (fileExtension == ".txt")
                File.WriteAllText(currentFile, richTextBox.Text);
        }

        private void LoadFile() {
            string fileExtension = Path.GetExtension(currentFile);
            if (fileExtension == ".rtf")
                richTextBox.LoadFile(currentFile, RichTextBoxStreamType.RichText);
            else if (fileExtension == ".txt")
                richTextBox.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
        }

        private DialogResult UnsavedChanges() {
            DialogResult result = DialogResult.None;

            if (!string.IsNullOrEmpty(currentFile) &&
                File.ReadAllText(currentFile) != richTextBox.Rtf &&
                File.ReadAllText(currentFile) != richTextBox.Text &&
                (result = MessageBox.Show($"Do you want to change saves to\n{currentFile}?", "Save File",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)) == DialogResult.Yes) {
                    SaveFile();
            }

            return result;
        }

        private void UpdateFontStyleButtonState() {
            Font currentFont = richTextBox.SelectionFont;
            if (currentFont != null) {
                boldToolStripButton.Checked = currentFont.Bold;
                italicToolStripButton.Checked = currentFont.Italic;
                underlineToolStripButton.Checked = currentFont.Underline;
            }
        }
    }
}
