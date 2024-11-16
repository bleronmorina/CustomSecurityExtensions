using System;
using System.IO;
using System.Windows.Forms;
using CustomSecurityExtensions;

namespace CustomSecurityExtensions
{
    public partial class MainForm : Form
    {
        private CustomDSASignature dsaSigner;

        public MainForm()
        {
            InitializeComponent();
            dsaSigner = new CustomDSASignature(1024); 
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            try
            {
                string message = GetInputMessage();
                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Please enter a valid message or select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] signature = dsaSigner.SignMessage(message);
                txtSignature.Text = Convert.ToBase64String(signature);
                MessageBox.Show("Message signed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error signing message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string message = GetInputMessage();
                if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(txtSignature.Text))
                {
                    MessageBox.Show("Please provide both a message and a signature for verification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] signature = Convert.FromBase64String(txtSignature.Text);

                bool isValid = dsaSigner.VerifyMessage(message, signature);
                string result = isValid ? "Signature is valid." : "Signature is invalid.";
                MessageBox.Show(result, "Verification Result", MessageBoxButtons.OK, isValid ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private string GetInputMessage()
        {
            if (rbtnTextInput.Checked)
            {
                return txtMessage.Text;
            }
            else if (rbtnFileInput.Checked && !string.IsNullOrEmpty(txtFilePath.Text))
            {
                return File.ReadAllText(txtFilePath.Text);
            }
            return String.Empty;
        }
    }
}
