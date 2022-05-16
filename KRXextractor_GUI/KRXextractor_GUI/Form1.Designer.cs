namespace KRXextractor_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_copyright = new System.Windows.Forms.Label();
            this.button_filePicker = new System.Windows.Forms.Button();
            this.textBox_selectedFile = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.checkbox_defaultSave = new System.Windows.Forms.CheckBox();
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.groupBox_output = new System.Windows.Forms.GroupBox();
            this.button_outputFolder = new System.Windows.Forms.Button();
            this.textBox_outputFolder = new System.Windows.Forms.TextBox();
            this.button_extract = new System.Windows.Forms.Button();
            this.groupBox_input.SuspendLayout();
            this.groupBox_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_copyright.Location = new System.Drawing.Point(87, 27);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(228, 12);
            this.label_copyright.TabIndex = 0;
            this.label_copyright.Text = "by Ruzsa Gergely Gábor || https://ruzger.hu/";
            // 
            // button_filePicker
            // 
            this.button_filePicker.Location = new System.Drawing.Point(19, 33);
            this.button_filePicker.Name = "button_filePicker";
            this.button_filePicker.Size = new System.Drawing.Size(85, 21);
            this.button_filePicker.TabIndex = 1;
            this.button_filePicker.Text = "Tallózás";
            this.button_filePicker.UseVisualStyleBackColor = true;
            this.button_filePicker.Click += new System.EventHandler(this.button_filePicker_Click);
            // 
            // textBox_selectedFile
            // 
            this.textBox_selectedFile.Enabled = false;
            this.textBox_selectedFile.Location = new System.Drawing.Point(109, 34);
            this.textBox_selectedFile.Name = "textBox_selectedFile";
            this.textBox_selectedFile.Size = new System.Drawing.Size(245, 21);
            this.textBox_selectedFile.TabIndex = 2;
            this.textBox_selectedFile.TextChanged += new System.EventHandler(this.textBox_selectedFile_TextChanged);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(132, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(128, 18);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "KRXextractor";
            // 
            // checkbox_defaultSave
            // 
            this.checkbox_defaultSave.AutoSize = true;
            this.checkbox_defaultSave.Checked = true;
            this.checkbox_defaultSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_defaultSave.Location = new System.Drawing.Point(18, 30);
            this.checkbox_defaultSave.Name = "checkbox_defaultSave";
            this.checkbox_defaultSave.Size = new System.Drawing.Size(240, 17);
            this.checkbox_defaultSave.TabIndex = 4;
            this.checkbox_defaultSave.Text = "Alapértelmezett mentési hely (asztal)";
            this.checkbox_defaultSave.UseVisualStyleBackColor = true;
            this.checkbox_defaultSave.CheckedChanged += new System.EventHandler(this.checkbox_defaultSave_CheckedChanged);
            // 
            // groupBox_input
            // 
            this.groupBox_input.Controls.Add(this.button_filePicker);
            this.groupBox_input.Controls.Add(this.textBox_selectedFile);
            this.groupBox_input.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_input.Location = new System.Drawing.Point(12, 54);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(373, 74);
            this.groupBox_input.TabIndex = 5;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Bemeneti állomány";
            // 
            // groupBox_output
            // 
            this.groupBox_output.Controls.Add(this.textBox_outputFolder);
            this.groupBox_output.Controls.Add(this.button_outputFolder);
            this.groupBox_output.Controls.Add(this.checkbox_defaultSave);
            this.groupBox_output.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_output.Location = new System.Drawing.Point(12, 146);
            this.groupBox_output.Name = "groupBox_output";
            this.groupBox_output.Size = new System.Drawing.Size(373, 104);
            this.groupBox_output.TabIndex = 6;
            this.groupBox_output.TabStop = false;
            this.groupBox_output.Text = "Kimeneti állományok";
            // 
            // button_outputFolder
            // 
            this.button_outputFolder.Enabled = false;
            this.button_outputFolder.Location = new System.Drawing.Point(18, 65);
            this.button_outputFolder.Name = "button_outputFolder";
            this.button_outputFolder.Size = new System.Drawing.Size(85, 21);
            this.button_outputFolder.TabIndex = 5;
            this.button_outputFolder.Text = "Tallózás";
            this.button_outputFolder.UseVisualStyleBackColor = true;
            this.button_outputFolder.Click += new System.EventHandler(this.button_outputFolder_Click);
            // 
            // textBox_outputFolder
            // 
            this.textBox_outputFolder.Enabled = false;
            this.textBox_outputFolder.Location = new System.Drawing.Point(109, 65);
            this.textBox_outputFolder.Name = "textBox_outputFolder";
            this.textBox_outputFolder.Size = new System.Drawing.Size(244, 21);
            this.textBox_outputFolder.TabIndex = 6;
            this.textBox_outputFolder.TextChanged += new System.EventHandler(this.textBox_outputFolder_TextChanged);
            // 
            // button_extract
            // 
            this.button_extract.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_extract.Location = new System.Drawing.Point(135, 256);
            this.button_extract.Name = "button_extract";
            this.button_extract.Size = new System.Drawing.Size(122, 36);
            this.button_extract.TabIndex = 7;
            this.button_extract.Text = "Kibontás";
            this.button_extract.UseVisualStyleBackColor = true;
            this.button_extract.Click += new System.EventHandler(this.button_extract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 303);
            this.Controls.Add(this.button_extract);
            this.Controls.Add(this.groupBox_output);
            this.Controls.Add(this.groupBox_input);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_copyright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "KRXextractor GUI";
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            this.groupBox_output.ResumeLayout(false);
            this.groupBox_output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Button button_filePicker;
        private System.Windows.Forms.TextBox textBox_selectedFile;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.CheckBox checkbox_defaultSave;
        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.GroupBox groupBox_output;
        private System.Windows.Forms.TextBox textBox_outputFolder;
        private System.Windows.Forms.Button button_outputFolder;
        private System.Windows.Forms.Button button_extract;
    }
}

