namespace CustomSecurityExtensions
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.rbtnTextInput = new System.Windows.Forms.RadioButton();
            this.rbtnFileInput = new System.Windows.Forms.RadioButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelSignature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // rbtnTextInput
            // 
            this.rbtnTextInput.AutoSize = true;
            this.rbtnTextInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbtnTextInput.Location = new System.Drawing.Point(20, 20);
            this.rbtnTextInput.Name = "rbtnTextInput";
            this.rbtnTextInput.Size = new System.Drawing.Size(95, 23);
            this.rbtnTextInput.TabIndex = 0;
            this.rbtnTextInput.TabStop = true;
            this.rbtnTextInput.Text = "Text Input";
            this.rbtnTextInput.UseVisualStyleBackColor = true;
            this.rbtnTextInput.CheckedChanged += new System.EventHandler(this.rbtnTextInput_CheckedChanged);
            
            // 
            // rbtnFileInput
            // 
            this.rbtnFileInput.AutoSize = true;
            this.rbtnFileInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbtnFileInput.Location = new System.Drawing.Point(140, 20);
            this.rbtnFileInput.Name = "rbtnFileInput";
            this.rbtnFileInput.Size = new System.Drawing.Size(89, 23);
            this.rbtnFileInput.TabIndex = 1;
            this.rbtnFileInput.TabStop = true;
            this.rbtnFileInput.Text = "File Input";
            this.rbtnFileInput.UseVisualStyleBackColor = true;
            this.rbtnFileInput.CheckedChanged += new System.EventHandler(this.rbtnFileInput_CheckedChanged);
            
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(20, 90);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "Enter your message here...";
            this.txtMessage.Size = new System.Drawing.Size(460, 100);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Visible = true;
            
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilePath.Location = new System.Drawing.Point(20, 90);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PlaceholderText = "Choose a file...";
            this.txtFilePath.Size = new System.Drawing.Size(360, 25);
            this.txtFilePath.TabIndex = 3;
            this.txtFilePath.Visible = false;
            
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBrowseFile.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnBrowseFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFile.Location = new System.Drawing.Point(400, 88);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(80, 30);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Visible = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSign.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(20, 200);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(120, 40);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.BtnSign_Click);
            
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerify.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(160, 200);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(120, 40);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            
            // 
            // txtSignature
            // 
            this.txtSignature.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSignature.Location = new System.Drawing.Point(20, 270);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.PlaceholderText = "The generated or verified signature will appear here...";
            this.txtSignature.Size = new System.Drawing.Size(460, 100);
            this.txtSignature.TabIndex = 7;
            
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessage.Location = new System.Drawing.Point(20, 65);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(70, 19);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Message:";
            
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSignature.Location = new System.Drawing.Point(20, 245);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(74, 19);
            this.labelSignature.TabIndex = 10;
            this.labelSignature.Text = "Signature:";
            
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.rbtnFileInput);
            this.Controls.Add(this.rbtnTextInput);
            this.Name = "MainForm";
            this.Text = "DSA Signer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnTextInput;
        private System.Windows.Forms.RadioButton rbtnFileInput;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelSignature;

        private void rbtnTextInput_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTextInput.Checked)
            {
                txtMessage.Visible = true;
                labelMessage.Text = "Message:";
                txtFilePath.Visible = false;
                btnBrowseFile.Visible = false;
            }
        }

        private void rbtnFileInput_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFileInput.Checked)
            {
                txtFilePath.Visible = true;
                btnBrowseFile.Visible = true;
                labelMessage.Text = "File to Sign:";
                txtMessage.Visible = false;
            }
        }
    }
}