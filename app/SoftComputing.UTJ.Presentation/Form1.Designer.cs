namespace SoftComputing.UTJ.Presentation
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.jsonTextbox = new System.Windows.Forms.TextBox();
            this.resultPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(286, 13);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(216, 36);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Chose Diagram";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // jsonTextbox
            // 
            this.jsonTextbox.Location = new System.Drawing.Point(12, 12);
            this.jsonTextbox.Multiline = true;
            this.jsonTextbox.Name = "jsonTextbox";
            this.jsonTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonTextbox.Size = new System.Drawing.Size(268, 272);
            this.jsonTextbox.TabIndex = 2;
            // 
            // resultPicture
            // 
            this.resultPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultPicture.Location = new System.Drawing.Point(286, 55);
            this.resultPicture.MaximumSize = new System.Drawing.Size(216, 229);
            this.resultPicture.MinimumSize = new System.Drawing.Size(216, 229);
            this.resultPicture.Name = "resultPicture";
            this.resultPicture.Size = new System.Drawing.Size(216, 229);
            this.resultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPicture.TabIndex = 3;
            this.resultPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 295);
            this.Controls.Add(this.resultPicture);
            this.Controls.Add(this.jsonTextbox);
            this.Controls.Add(this.chooseFileButton);
            this.MaximumSize = new System.Drawing.Size(530, 334);
            this.MinimumSize = new System.Drawing.Size(530, 334);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soft Computing - UTJ";
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox jsonTextbox;
        private System.Windows.Forms.PictureBox resultPicture;
    }
}

