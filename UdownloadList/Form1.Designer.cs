namespace UdownloadList
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pid = new TextBox();
            path = new TextBox();
            Doutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(234, 62);
            label1.TabIndex = 0;
            label1.Text = "PlayList Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.1F);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(31, 203);
            label2.Name = "label2";
            label2.Size = new Size(247, 62);
            label2.TabIndex = 1;
            label2.Text = "TargetPath";
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(2507, 321);
            button1.Name = "button1";
            button1.Size = new Size(292, 90);
            button1.TabIndex = 2;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pid
            // 
            pid.Font = new Font("Segoe UI", 12F);
            pid.Location = new Point(282, 60);
            pid.Name = "pid";
            pid.Size = new Size(1519, 61);
            pid.TabIndex = 3;
            // 
            // path
            // 
            path.Font = new Font("Segoe UI", 12F);
            path.Location = new Point(284, 207);
            path.Name = "path";
            path.Size = new Size(1517, 61);
            path.TabIndex = 4;
            // 
            // Doutput
            // 
            Doutput.BackColor = SystemColors.MenuText;
            Doutput.ForeColor = SystemColors.HighlightText;
            Doutput.Location = new Point(31, 321);
            Doutput.Multiline = true;
            Doutput.Name = "Doutput";
            Doutput.ScrollBars = ScrollBars.Both;
            Doutput.Size = new Size(2443, 896);
            Doutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(2833, 1229);
            Controls.Add(Doutput);
            Controls.Add(path);
            Controls.Add(pid);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Home";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox pid;
        private TextBox path;
        private TextBox Doutput;
    }
}
