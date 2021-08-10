namespace Camera
{
    partial class Setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelImgPath = new System.Windows.Forms.Label();
            this.textBoxImgPath = new System.Windows.Forms.TextBox();
            this.buttonFilePathOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFilePathOpen);
            this.groupBox1.Controls.Add(this.textBoxImgPath);
            this.groupBox1.Controls.Add(this.labelImgPath);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Path";
            // 
            // labelImgPath
            // 
            this.labelImgPath.AutoSize = true;
            this.labelImgPath.Location = new System.Drawing.Point(14, 30);
            this.labelImgPath.Name = "labelImgPath";
            this.labelImgPath.Size = new System.Drawing.Size(52, 13);
            this.labelImgPath.TabIndex = 0;
            this.labelImgPath.Text = "Img Path:";
            // 
            // textBoxImgPath
            // 
            this.textBoxImgPath.Location = new System.Drawing.Point(70, 27);
            this.textBoxImgPath.Name = "textBoxImgPath";
            this.textBoxImgPath.ReadOnly = true;
            this.textBoxImgPath.Size = new System.Drawing.Size(518, 20);
            this.textBoxImgPath.TabIndex = 1;
            // 
            // buttonFilePathOpen
            // 
            this.buttonFilePathOpen.Location = new System.Drawing.Point(603, 26);
            this.buttonFilePathOpen.Name = "buttonFilePathOpen";
            this.buttonFilePathOpen.Size = new System.Drawing.Size(51, 23);
            this.buttonFilePathOpen.TabIndex = 2;
            this.buttonFilePathOpen.Text = "Open";
            this.buttonFilePathOpen.UseVisualStyleBackColor = true;
            this.buttonFilePathOpen.Click += new System.EventHandler(this.buttonFilePathOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(613, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(58, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFilePathOpen;
        private System.Windows.Forms.TextBox textBoxImgPath;
        private System.Windows.Forms.Label labelImgPath;
        private System.Windows.Forms.Button buttonSave;
    }
}