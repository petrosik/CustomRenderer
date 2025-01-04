namespace CustomRenderer
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
            button_zpl = new Button();
            button_zmin = new Button();
            button_ymin = new Button();
            button_ypl = new Button();
            button_xmin = new Button();
            button_xpl = new Button();
            cb_Auto = new CheckBox();
            cb_rcf = new CheckBox();
            SuspendLayout();
            // 
            // button_zpl
            // 
            button_zpl.Location = new Point(952, 12);
            button_zpl.Name = "button_zpl";
            button_zpl.Size = new Size(30, 23);
            button_zpl.TabIndex = 0;
            button_zpl.Text = "z+";
            button_zpl.UseVisualStyleBackColor = true;
            button_zpl.Click += button_zpl_Click;
            // 
            // button_zmin
            // 
            button_zmin.Location = new Point(916, 12);
            button_zmin.Name = "button_zmin";
            button_zmin.Size = new Size(30, 23);
            button_zmin.TabIndex = 1;
            button_zmin.Text = "z-";
            button_zmin.UseVisualStyleBackColor = true;
            button_zmin.Click += button_zmin_Click;
            // 
            // button_ymin
            // 
            button_ymin.Location = new Point(916, 41);
            button_ymin.Name = "button_ymin";
            button_ymin.Size = new Size(30, 23);
            button_ymin.TabIndex = 3;
            button_ymin.Text = "y-";
            button_ymin.UseVisualStyleBackColor = true;
            button_ymin.Click += button_ymin_Click;
            // 
            // button_ypl
            // 
            button_ypl.Location = new Point(952, 41);
            button_ypl.Name = "button_ypl";
            button_ypl.Size = new Size(30, 23);
            button_ypl.TabIndex = 2;
            button_ypl.Text = "y+";
            button_ypl.UseVisualStyleBackColor = true;
            button_ypl.Click += button_ypl_Click;
            // 
            // button_xmin
            // 
            button_xmin.Location = new Point(916, 70);
            button_xmin.Name = "button_xmin";
            button_xmin.Size = new Size(30, 23);
            button_xmin.TabIndex = 5;
            button_xmin.Text = "x-";
            button_xmin.UseVisualStyleBackColor = true;
            button_xmin.Click += button_xmin_Click;
            // 
            // button_xpl
            // 
            button_xpl.Location = new Point(952, 70);
            button_xpl.Name = "button_xpl";
            button_xpl.Size = new Size(30, 23);
            button_xpl.TabIndex = 4;
            button_xpl.Text = "x+";
            button_xpl.UseVisualStyleBackColor = true;
            button_xpl.Click += button_xpl_Click;
            // 
            // cb_Auto
            // 
            cb_Auto.AutoSize = true;
            cb_Auto.Location = new Point(856, 99);
            cb_Auto.Name = "cb_Auto";
            cb_Auto.Size = new Size(86, 19);
            cb_Auto.TabIndex = 6;
            cb_Auto.Text = "AutoRotate";
            cb_Auto.UseVisualStyleBackColor = true;
            cb_Auto.CheckedChanged += cb_Auto_CheckedChanged;
            // 
            // cb_rcf
            // 
            cb_rcf.AutoSize = true;
            cb_rcf.Location = new Point(856, 124);
            cb_rcf.Name = "cb_rcf";
            cb_rcf.Size = new Size(129, 19);
            cb_rcf.TabIndex = 7;
            cb_rcf.Text = "RandomColorFaces";
            cb_rcf.UseVisualStyleBackColor = true;
            cb_rcf.CheckedChanged += cb_rcf_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 971);
            Controls.Add(cb_rcf);
            Controls.Add(cb_Auto);
            Controls.Add(button_xmin);
            Controls.Add(button_xpl);
            Controls.Add(button_ymin);
            Controls.Add(button_ypl);
            Controls.Add(button_zmin);
            Controls.Add(button_zpl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_zpl;
        private Button button_zmin;
        private Button button_ymin;
        private Button button_ypl;
        private Button button_xmin;
        private Button button_xpl;
        private CheckBox cb_Auto;
        private CheckBox cb_rcf;
    }
}
