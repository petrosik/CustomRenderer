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
            nud_Fog = new NumericUpDown();
            label1 = new Label();
            p_scene = new Panel();
            p_colorpicker = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Fog).BeginInit();
            SuspendLayout();
            // 
            // button_zpl
            // 
            button_zpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_zpl.Location = new Point(942, 12);
            button_zpl.Name = "button_zpl";
            button_zpl.Size = new Size(30, 23);
            button_zpl.TabIndex = 0;
            button_zpl.Text = "z+";
            button_zpl.UseVisualStyleBackColor = true;
            button_zpl.Click += button_zpl_Click;
            // 
            // button_zmin
            // 
            button_zmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_zmin.Location = new Point(906, 12);
            button_zmin.Name = "button_zmin";
            button_zmin.Size = new Size(30, 23);
            button_zmin.TabIndex = 1;
            button_zmin.Text = "z-";
            button_zmin.UseVisualStyleBackColor = true;
            button_zmin.Click += button_zmin_Click;
            // 
            // button_ymin
            // 
            button_ymin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ymin.Location = new Point(906, 41);
            button_ymin.Name = "button_ymin";
            button_ymin.Size = new Size(30, 23);
            button_ymin.TabIndex = 3;
            button_ymin.Text = "y-";
            button_ymin.UseVisualStyleBackColor = true;
            button_ymin.Click += button_ymin_Click;
            // 
            // button_ypl
            // 
            button_ypl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ypl.Location = new Point(942, 41);
            button_ypl.Name = "button_ypl";
            button_ypl.Size = new Size(30, 23);
            button_ypl.TabIndex = 2;
            button_ypl.Text = "y+";
            button_ypl.UseVisualStyleBackColor = true;
            button_ypl.Click += button_ypl_Click;
            // 
            // button_xmin
            // 
            button_xmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_xmin.Location = new Point(906, 70);
            button_xmin.Name = "button_xmin";
            button_xmin.Size = new Size(30, 23);
            button_xmin.TabIndex = 5;
            button_xmin.Text = "x-";
            button_xmin.UseVisualStyleBackColor = true;
            button_xmin.Click += button_xmin_Click;
            // 
            // button_xpl
            // 
            button_xpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_xpl.Location = new Point(942, 70);
            button_xpl.Name = "button_xpl";
            button_xpl.Size = new Size(30, 23);
            button_xpl.TabIndex = 4;
            button_xpl.Text = "x+";
            button_xpl.UseVisualStyleBackColor = true;
            button_xpl.Click += button_xpl_Click;
            // 
            // cb_Auto
            // 
            cb_Auto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_Auto.AutoSize = true;
            cb_Auto.Location = new Point(846, 99);
            cb_Auto.Name = "cb_Auto";
            cb_Auto.Size = new Size(86, 19);
            cb_Auto.TabIndex = 6;
            cb_Auto.Text = "AutoRotate";
            cb_Auto.UseVisualStyleBackColor = true;
            cb_Auto.CheckedChanged += cb_Auto_CheckedChanged;
            // 
            // cb_rcf
            // 
            cb_rcf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_rcf.AutoSize = true;
            cb_rcf.Location = new Point(846, 124);
            cb_rcf.Name = "cb_rcf";
            cb_rcf.Size = new Size(129, 19);
            cb_rcf.TabIndex = 7;
            cb_rcf.Text = "RandomColorFaces";
            cb_rcf.UseVisualStyleBackColor = true;
            cb_rcf.CheckedChanged += cb_rcf_CheckedChanged;
            // 
            // nud_Fog
            // 
            nud_Fog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nud_Fog.Location = new Point(846, 12);
            nud_Fog.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Fog.Name = "nud_Fog";
            nud_Fog.Size = new Size(54, 23);
            nud_Fog.TabIndex = 8;
            nud_Fog.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(765, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 9;
            label1.Text = "Fog Distance";
            // 
            // p_scene
            // 
            p_scene.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            p_scene.AutoScroll = true;
            p_scene.BorderStyle = BorderStyle.FixedSingle;
            p_scene.Location = new Point(559, 12);
            p_scene.Name = "p_scene";
            p_scene.Size = new Size(200, 737);
            p_scene.TabIndex = 10;
            // 
            // p_colorpicker
            // 
            p_colorpicker.BackColor = Color.Red;
            p_colorpicker.Location = new Point(922, 158);
            p_colorpicker.Name = "p_colorpicker";
            p_colorpicker.Size = new Size(50, 50);
            p_colorpicker.TabIndex = 11;
            p_colorpicker.MouseClick += p_colorpicker_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(848, 158);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 12;
            label2.Text = "Click Color:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(label2);
            Controls.Add(p_colorpicker);
            Controls.Add(p_scene);
            Controls.Add(label1);
            Controls.Add(nud_Fog);
            Controls.Add(cb_rcf);
            Controls.Add(cb_Auto);
            Controls.Add(button_xmin);
            Controls.Add(button_xpl);
            Controls.Add(button_ymin);
            Controls.Add(button_ypl);
            Controls.Add(button_zmin);
            Controls.Add(button_zpl);
            Name = "Form1";
            Text = "Custom Renderer";
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)nud_Fog).EndInit();
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
        private NumericUpDown nud_Fog;
        private Label label1;
        private Panel p_scene;
        private Panel p_colorpicker;
        private Label label2;
    }
}
