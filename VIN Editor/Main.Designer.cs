namespace VIN_Editor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.readBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vinNumTextBox = new System.Windows.Forms.TextBox();
            this.openBinBtn = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.calcChecksum = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.Enabled = false;
            this.readBtn.Location = new System.Drawing.Point(43, 457);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(238, 52);
            this.readBtn.TabIndex = 0;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number";
            // 
            // serialNumTextBox
            // 
            this.serialNumTextBox.Location = new System.Drawing.Point(259, 175);
            this.serialNumTextBox.Name = "serialNumTextBox";
            this.serialNumTextBox.Size = new System.Drawing.Size(362, 43);
            this.serialNumTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "VIN Number";
            // 
            // vinNumTextBox
            // 
            this.vinNumTextBox.Location = new System.Drawing.Point(259, 242);
            this.vinNumTextBox.Name = "vinNumTextBox";
            this.vinNumTextBox.Size = new System.Drawing.Size(362, 43);
            this.vinNumTextBox.TabIndex = 4;
            // 
            // openBinBtn
            // 
            this.openBinBtn.Location = new System.Drawing.Point(43, 377);
            this.openBinBtn.Name = "openBinBtn";
            this.openBinBtn.Size = new System.Drawing.Size(238, 52);
            this.openBinBtn.TabIndex = 5;
            this.openBinBtn.Text = "Open Bin";
            this.openBinBtn.UseVisualStyleBackColor = true;
            this.openBinBtn.Click += new System.EventHandler(this.openBinBtn_Click);
            // 
            // writeBtn
            // 
            this.writeBtn.Enabled = false;
            this.writeBtn.Location = new System.Drawing.Point(357, 457);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(264, 52);
            this.writeBtn.TabIndex = 6;
            this.writeBtn.Text = "Write";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Enabled = false;
            this.logTextBox.Location = new System.Drawing.Point(668, 105);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(1026, 514);
            this.logTextBox.TabIndex = 7;
            // 
            // calcChecksum
            // 
            this.calcChecksum.Enabled = false;
            this.calcChecksum.Location = new System.Drawing.Point(357, 377);
            this.calcChecksum.Name = "calcChecksum";
            this.calcChecksum.Size = new System.Drawing.Size(264, 52);
            this.calcChecksum.TabIndex = 8;
            this.calcChecksum.Text = "Checksum Validate";
            this.calcChecksum.UseVisualStyleBackColor = true;
            this.calcChecksum.Click += new System.EventHandler(this.calcChecksum_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(190, 53);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(200, 37);
            this.fileLabel.TabIndex = 9;
            this.fileLabel.Text = "No file selected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Path: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.calcChecksum);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.openBinBtn);
            this.Controls.Add(this.vinNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialNumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBtn);
            this.Name = "Main";
            this.Text = "VIN Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button readBtn;
        private Label label1;
        private TextBox serialNumTextBox;
        private Label label2;
        private TextBox vinNumTextBox;
        private Button openBinBtn;
        private Button writeBtn;
        private TextBox logTextBox;
        private Button calcChecksum;
        private Label fileLabel;
        private Label label3;
    }
}