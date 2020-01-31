namespace AICorporation.Bulldozer.WindowsClient
{
    partial class Main
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
            this.GoButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(536, 398);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(123, 40);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "&Go";
            this.GoButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(665, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 40);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GoButton);
            this.Name = "Main";
            this.Text = "Bulldozer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

