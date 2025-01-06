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
            num_Res = new NumericUpDown();
            label3 = new Label();
            p_backpick = new Panel();
            label4 = new Label();
            btn_ResetCol = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Fog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Res).BeginInit();
            SuspendLayout();
            // 
            // button_zpl
            // 
            button_zpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_zpl.Location = new Point(1077, 16);
            button_zpl.Margin = new Padding(3, 4, 3, 4);
            button_zpl.Name = "button_zpl";
            button_zpl.Size = new Size(34, 31);
            button_zpl.TabIndex = 0;
            button_zpl.Text = "z+";
            button_zpl.UseVisualStyleBackColor = true;
            button_zpl.Click += button_zpl_Click;
            // 
            // button_zmin
            // 
            button_zmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_zmin.Location = new Point(1035, 16);
            button_zmin.Margin = new Padding(3, 4, 3, 4);
            button_zmin.Name = "button_zmin";
            button_zmin.Size = new Size(34, 31);
            button_zmin.TabIndex = 1;
            button_zmin.Text = "z-";
            button_zmin.UseVisualStyleBackColor = true;
            button_zmin.Click += button_zmin_Click;
            // 
            // button_ymin
            // 
            button_ymin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ymin.Location = new Point(1035, 55);
            button_ymin.Margin = new Padding(3, 4, 3, 4);
            button_ymin.Name = "button_ymin";
            button_ymin.Size = new Size(34, 31);
            button_ymin.TabIndex = 3;
            button_ymin.Text = "y-";
            button_ymin.UseVisualStyleBackColor = true;
            button_ymin.Click += button_ymin_Click;
            // 
            // button_ypl
            // 
            button_ypl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_ypl.Location = new Point(1077, 55);
            button_ypl.Margin = new Padding(3, 4, 3, 4);
            button_ypl.Name = "button_ypl";
            button_ypl.Size = new Size(34, 31);
            button_ypl.TabIndex = 2;
            button_ypl.Text = "y+";
            button_ypl.UseVisualStyleBackColor = true;
            button_ypl.Click += button_ypl_Click;
            // 
            // button_xmin
            // 
            button_xmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_xmin.Location = new Point(1035, 93);
            button_xmin.Margin = new Padding(3, 4, 3, 4);
            button_xmin.Name = "button_xmin";
            button_xmin.Size = new Size(34, 31);
            button_xmin.TabIndex = 5;
            button_xmin.Text = "x-";
            button_xmin.UseVisualStyleBackColor = true;
            button_xmin.Click += button_xmin_Click;
            // 
            // button_xpl
            // 
            button_xpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_xpl.Location = new Point(1077, 93);
            button_xpl.Margin = new Padding(3, 4, 3, 4);
            button_xpl.Name = "button_xpl";
            button_xpl.Size = new Size(34, 31);
            button_xpl.TabIndex = 4;
            button_xpl.Text = "x+";
            button_xpl.UseVisualStyleBackColor = true;
            button_xpl.Click += button_xpl_Click;
            // 
            // cb_Auto
            // 
            cb_Auto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_Auto.AutoSize = true;
            cb_Auto.Location = new Point(958, 132);
            cb_Auto.Margin = new Padding(3, 4, 3, 4);
            cb_Auto.Name = "cb_Auto";
            cb_Auto.Size = new Size(107, 24);
            cb_Auto.TabIndex = 6;
            cb_Auto.Text = "AutoRotate";
            cb_Auto.UseVisualStyleBackColor = true;
            cb_Auto.CheckedChanged += cb_Auto_CheckedChanged;
            // 
            // cb_rcf
            // 
            cb_rcf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_rcf.AutoSize = true;
            cb_rcf.Location = new Point(956, 165);
            cb_rcf.Margin = new Padding(3, 4, 3, 4);
            cb_rcf.Name = "cb_rcf";
            cb_rcf.Size = new Size(158, 24);
            cb_rcf.TabIndex = 7;
            cb_rcf.Text = "RandomColorFaces";
            cb_rcf.UseVisualStyleBackColor = true;
            cb_rcf.CheckedChanged += cb_rcf_CheckedChanged;
            // 
            // nud_Fog
            // 
            nud_Fog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nud_Fog.Location = new Point(967, 16);
            nud_Fog.Margin = new Padding(3, 4, 3, 4);
            nud_Fog.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Fog.Name = "nud_Fog";
            nud_Fog.Size = new Size(62, 27);
            nud_Fog.TabIndex = 8;
            nud_Fog.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(874, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 9;
            label1.Text = "Max RD";
            // 
            // p_scene
            // 
            p_scene.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            p_scene.AutoScroll = true;
            p_scene.BorderStyle = BorderStyle.FixedSingle;
            p_scene.Location = new Point(639, 16);
            p_scene.Margin = new Padding(3, 4, 3, 4);
            p_scene.Name = "p_scene";
            p_scene.Size = new Size(228, 982);
            p_scene.TabIndex = 10;
            // 
            // p_colorpicker
            // 
            p_colorpicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            p_colorpicker.BackColor = Color.Red;
            p_colorpicker.Location = new Point(1054, 211);
            p_colorpicker.Margin = new Padding(3, 4, 3, 4);
            p_colorpicker.Name = "p_colorpicker";
            p_colorpicker.Size = new Size(57, 67);
            p_colorpicker.TabIndex = 11;
            p_colorpicker.MouseClick += p_colorpicker_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(969, 211);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Click Color:";
            // 
            // num_Res
            // 
            num_Res.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            num_Res.Location = new Point(967, 51);
            num_Res.Margin = new Padding(3, 4, 3, 4);
            num_Res.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            num_Res.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            num_Res.Name = "num_Res";
            num_Res.Size = new Size(62, 27);
            num_Res.TabIndex = 13;
            num_Res.Value = new decimal(new int[] { 500, 0, 0, 0 });
            num_Res.ValueChanged += num_Res_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(873, 53);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 14;
            label3.Text = "Resolution";
            // 
            // p_backpick
            // 
            p_backpick.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            p_backpick.BackColor = Color.Black;
            p_backpick.Location = new Point(1054, 286);
            p_backpick.Margin = new Padding(3, 4, 3, 4);
            p_backpick.Name = "p_backpick";
            p_backpick.Size = new Size(57, 67);
            p_backpick.TabIndex = 12;
            p_backpick.MouseClick += p_backpick_MouseClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(917, 286);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 15;
            label4.Text = "Background Color:";
            // 
            // btn_ResetCol
            // 
            btn_ResetCol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ResetCol.Location = new Point(977, 309);
            btn_ResetCol.Name = "btn_ResetCol";
            btn_ResetCol.Size = new Size(71, 40);
            btn_ResetCol.TabIndex = 16;
            btn_ResetCol.Text = "Reset";
            btn_ResetCol.UseVisualStyleBackColor = true;
            btn_ResetCol.Click += btn_ResetCol_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 1015);
            Controls.Add(btn_ResetCol);
            Controls.Add(label4);
            Controls.Add(p_backpick);
            Controls.Add(label3);
            Controls.Add(num_Res);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Custom Renderer";
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)nud_Fog).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Res).EndInit();
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
        private NumericUpDown num_Res;
        private Label label3;
        private Panel p_backpick;
        private Label label4;
        private Button btn_ResetCol;
    }
}
