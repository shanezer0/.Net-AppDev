using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _14022469Assignment2
{
    public partial class MainWindow2 : Form
    {
        LoginWindow LW;
        string name, userType, pwf;
        public MainWindow2(LoginWindow LW, string name, string userType)
        {
            InitializeComponent();
            this.loginWindow = LW;
            this.name = name;
            this.userType = userType;
        }



        //Removing some permissions when the user type logged in is "VIEW"

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UserLabel.Text = $"Currently logged in as: {name}";
            if (userType == "View")
            {
                toolStrip1.Enabled = true;
                toolStrip2.Enabled = false;
                toolStrip3.Enabled = true;
                New1.Enabled = false;
                Save1.Enabled = false;
                SaveAs1.Enabled = false;
                Cut1.Enabled = false;
                Paste1.Enabled = false;
                Cut2.Enabled = false;
                Paste2.Enabled = false;
                richTextBox1.ReadOnly = true;
                
                

            }
        }



      // Button Functionalities for "File Menu"

        //Menu Strip Item - New
        private void New1_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges() != DialogResult.Cancel)
            {
                pwf = string.Empty;
                Text = "Text Editor";
                richTextBox1.Text = string.Empty;
            }
        }


        //File Menu Strip Item - Open
        private void Open1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open";
            dialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Plain Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pwf = dialog.FileName;
                Text = pwf;
                LoadFile();
            }
        }

        //File Menu Strip Item - Save
        private void Save1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pwf))
                SaveFile();
            else
                SaveAs1_Click(sender, e);
        }

        //File Menu Strip Item - Save As
        private void SaveAs1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "Rich Text Format file (*.rtf)|*.rtf|" +
                "Plain Text file (*.txt)|*.txt|All file (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pwf = dialog.FileName;
                Text = pwf;
                SaveFile();
            }
        }

        //File Menu Strip Item - Logout
        private void LogOut_Click(object sender, EventArgs e)
        {
            if (UnsavedChanges() != DialogResult.Cancel)
            {
                Close();
                loginWindow.Show();
            }
        }


        //Edit Menu Strip Item - Cut
        private void Cut1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut();
        }

        //Edit Menu Strip Item - Copy
        private void Copy1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        //Edit Menu Strip Item - Paste
        private void Paste1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //About Button
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor v20.2.2\nDeveloped By: Shanmukha Kakani\nID: 14022469", "About",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void FontBox_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = new Font(dialog.Font.Name, dialog.Font.Size, dialog.Font.Style);
                FontBox.Text = Convert.ToString(dialog.Font.Size);
            }
        }
        
        /*private void FontBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }*/

        private void Bold_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Bold)
            {
                if (currentFont.Italic && currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic | FontStyle.Underline);
                else if (currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else if (currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
                Bold.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
                Bold.Checked = true;
            }
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Italic)
            {
                if (currentFont.Bold && currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Underline);
                else if (currentFont.Bold)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Underline)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
                Italic.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
                Italic.Checked = true;
            }
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont.Underline)
            {
                if (currentFont.Bold && currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Italic);
                else if (currentFont.Bold)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Italic)
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Regular);
                Underline.Checked = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
                Underline.Checked = true;
            }
        }

        private void FontBox_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0 && Single.TryParse(FontBox.Text, out Single fontSize))
            {
                Font currentFont = richTextBox1.SelectionFont;
                if (currentFont != null)
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
        }

        private void RichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateFontStyleButtonState();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateFontStyleButtonState();
        }

        private void SaveFile()
        {
            string fileExtension = Path.GetExtension(pwf);
            if (fileExtension == ".rtf")
                File.WriteAllText(pwf, richTextBox1.Rtf);
            else if (fileExtension == ".txt")
                File.WriteAllText(pwf, richTextBox1.Text);
        }

        private void LoadFile()
        {
            string fileExtension = Path.GetExtension(pwf);
            if (fileExtension == ".rtf")
                richTextBox1.LoadFile(pwf, RichTextBoxStreamType.RichText);
            else if (fileExtension == ".txt")
                richTextBox1.LoadFile(pwf, RichTextBoxStreamType.PlainText);
        }

        private void fontSizeComboBox_Click(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileMenuStripTab_Click(object sender, EventArgs e)
        {

        }

        private void File1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentUser_Click(object sender, EventArgs e)
        {

        }

        private void New2_Click(object sender, EventArgs e)
        {

        }

        private void Open2_Click(object sender, EventArgs e)
        {

        }

        private void FontBox_Click_1(object sender, EventArgs e)
        {
            Single.TryParse(FontBox.Text, out Single fontSize);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style);
            
        }

        private DialogResult UnsavedChanges()
        {
            DialogResult result = DialogResult.None;

            if (!string.IsNullOrEmpty(pwf) &&
                File.ReadAllText(pwf) != richTextBox1.Rtf &&
                File.ReadAllText(pwf) != richTextBox1.Text &&
                (result = MessageBox.Show($"Do you want to save changes to\n{pwf}?", "Save File",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                SaveFile();
            }

            return result;
        }

        private void UpdateFontStyleButtonState()
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                Bold.Checked = currentFont.Bold;
                Italic.Checked = currentFont.Italic;
                Underline.Checked = currentFont.Underline;
            }
        }

    }
}
