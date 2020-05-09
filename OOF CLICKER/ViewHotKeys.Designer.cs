namespace OOF_CLICKER
{
    partial class ViewHotKeys
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
            this.gradientPanel1 = new OOF_CLICKER.GradientPanel();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.bottomColor = System.Drawing.Color.Red;
            this.gradientPanel1.Location = new System.Drawing.Point(-8, -31);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(815, 488);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.topColor = System.Drawing.Color.Orange;
            // 
            // ViewHotKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ViewHotKeys";
            this.Text = "ViewHotKeys";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
    }
}