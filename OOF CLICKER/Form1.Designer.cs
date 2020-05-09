namespace OOF_CLICKER
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MinCPSText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxCPSText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toggleButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.minimumCPSTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.maximumCPSTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mouseDownTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.editHotkeysTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.epicImageTooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.epicImageTooltip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gradientPanel1 = new OOF_CLICKER.GradientPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.dragControl1 = new OOF_CLICKER.DragControl();
            this.dragControl2 = new OOF_CLICKER.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "MinCPS:";
            // 
            // MinCPSText
            // 
            this.MinCPSText.AutoSize = true;
            this.MinCPSText.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.MinCPSText.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinCPSText.Location = new System.Drawing.Point(631, 202);
            this.MinCPSText.Name = "MinCPSText";
            this.MinCPSText.Size = new System.Drawing.Size(20, 30);
            this.MinCPSText.TabIndex = 3;
            this.MinCPSText.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "MaxCPS:";
            // 
            // MaxCPSText
            // 
            this.MaxCPSText.AutoSize = true;
            this.MaxCPSText.BackColor = System.Drawing.Color.SpringGreen;
            this.MaxCPSText.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxCPSText.Location = new System.Drawing.Point(642, 580);
            this.MaxCPSText.Name = "MaxCPSText";
            this.MaxCPSText.Size = new System.Drawing.Size(20, 30);
            this.MaxCPSText.TabIndex = 5;
            this.MaxCPSText.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1035, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 320);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(78, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 228);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(471, 462);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(401, 34);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Only click when mouse is held down";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.bottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.panelHeader);
            this.gradientPanel1.Controls.Add(this.trackBar1);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.trackBar2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1450, 730);
            this.gradientPanel1.TabIndex = 10;
            this.gradientPanel1.topColor = System.Drawing.Color.Teal;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelHeader.Controls.Add(this.Title);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Location = new System.Drawing.Point(0, -50);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1450, 92);
            this.panelHeader.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Andy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(588, 33);
            this.Title.TabIndex = 2;
            this.Title.Text = "OOF CLICKER || Made by Raghav <--- That\'s me";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Andy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1412, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.trackBar1.Location = new System.Drawing.Point(22, 74);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1371, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Andy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 101);
            this.button1.TabIndex = 6;
            this.button1.Text = "Toggle On  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.ForestGreen;
            this.trackBar2.Location = new System.Drawing.Point(22, 640);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(1379, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Title;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 730);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MaxCPSText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinCPSText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OOF CLICKER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MinCPSText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaxCPSText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHeader;
        private DragControl dragControl1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ToolTip toggleButtonTooltip;
        private System.Windows.Forms.ToolTip minimumCPSTooltip;
        private System.Windows.Forms.ToolTip maximumCPSTooltip;
        private System.Windows.Forms.ToolTip mouseDownTooltip;
        private System.Windows.Forms.ToolTip editHotkeysTooltip;
        private System.Windows.Forms.ToolTip epicImageTooltip1;
        private System.Windows.Forms.ToolTip epicImageTooltip2;
        private DragControl dragControl2;
    }
}

