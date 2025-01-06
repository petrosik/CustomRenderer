using System.Numerics;
using System.Windows.Forms;
using Util = Petrosik.Utility.Utility;

namespace CustomRenderer
{
    public partial class Form1 : Form
    {
        public static List<Object> SceneCollection = new List<Object>();
        public static Camera Camera = new Camera();
        public static Color ClickColor = Color.Red;
        public static bool AllowRendering = true;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            nud_Fog.Value = (decimal)Camera.MaxRenderDistance * 10;
            Camera.Resolution = (int)num_Res.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //SceneColection.Add(new Object("tris", new() {
            //new() {new(0,0,0), new(0,1,0),new(0,0,1)}
            //}, Color.White));
            //SceneColection.Add(new Object("tris", new() {
            //new() {new(0,1,0), new(0,1,1),new(0,0,1)}
            //}, Color.Yellow));
            //var orign = new Vector3(1f, 1f, 1f);
            var orign = new Vector3(0.5f, 0.5f, 0.5f);
            //// Front face (White)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(0, 0, 0), new(1, 0, 0), new(0, 1, 0)},
            //    new() {new(1, 0, 0), new(1, 1, 0), new(0, 1, 0)}
            //}, Color.White, orign));

            //// Back face (Yellow)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(0, 0, 1), new(0, 1, 1), new(1, 0, 1)},
            //    new() {new(1, 0, 1), new(0, 1, 1), new(1, 1, 1)}
            //}, Color.Yellow, orign));

            //// Left face (Blue)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(0, 0, 0), new(0, 1, 0), new(0, 0, 1)},
            //    new() {new(0, 1, 0), new(0, 1, 1), new(0, 0, 1)}
            //}, Color.Blue, orign)
            //{ Visible = false });

            //// Right face (Red)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(1, 0, 0), new(1, 0, 1), new(1, 1, 0)},
            //    new() {new(1, 0, 1), new(1, 1, 1), new(1, 1, 0)}
            //}, Color.Red, orign)
            //{ Visible = false });

            //// Top face (Green)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(0, 1, 0), new(1, 1, 0), new(0, 1, 1)},
            //    new() {new(1, 1, 0), new(1, 1, 1), new(0, 1, 1)}
            //}, Color.Green, orign));

            //// Bottom face (Cyan)
            //SceneCollection.Add(new Object("tris", new()
            //{
            //    new() {new(0, 0, 0), new(0, 0, 1), new(1, 0, 0)},
            //    new() {new(1, 0, 0), new(0, 0, 1), new(1, 0, 1)}
            //    }, Color.Cyan, orign));

            SceneCollection.Add(new Object("tris", new()
            {
                new() {new(0, 0, 0), new(1, 0, 0), new(0, 1, 0)},
                new() {new(1, 0, 0), new(1, 1, 0), new(0, 1, 0)},
                new() {new(0, 0, 1), new(0, 1, 1), new(1, 0, 1)},
                new() {new(1, 0, 1), new(0, 1, 1), new(1, 1, 2)},
                new() {new(0, 0, 0), new(0, 1, 0), new(0, 0, 1)},
                new() {new(0, 1, 0), new(0, 1, 1), new(0, 0, 1)},
                new() {new(1, 0, 0), new(1, 0, 1), new(1, 1, 0)},
                new() {new(1, 0, 1), new(1, 1, 1), new(1, 1, 0)},
                new() {new(0, 1, 0), new(1, 1, 0), new(0, 1, 1)},
                new() {new(1, 1, 0), new(1, 1, 1), new(0, 1, 1)},
                new() {new(0, 0, 0), new(0, 0, 1), new(1, 0, 0)},
                new() {new(1, 0, 0), new(0, 0, 1), new(1, 0, 1)}
            }, Color.White, orign)
            { Visible = false });

            //SceneCollection.Add(new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "simplecube.obj")) { Origin = orign, });
            SceneCollection[0].Position = new(0.75f, 0.5f, 0.5f);
            //SceneCollection.Add(new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dragon.obj")) { Origin = orign,  });
            SceneCollection.Add(new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "complexcube.obj")) { Origin = orign, Color = Color.Pink, Visible = false });
            //SceneCollection[1].Scale = 0.5f;

            //Camera.Resolution = 500;
            //Camera.WorldBackground = new();
            //Camera.MaxRenderDistance = 2f;
            //var d = Camera.RayIntersectsTriangle(new(-1, 0.2f, 0.2f), new(0.9f, 0.1f, 0), SceneColection[0].Tris[0],out var t,out var inter);

            DrawObjectsVisibility();
        }

        public void DrawObjectsVisibility()
        {
            for (int i = 0; i < SceneCollection.Count; i++)
            {
                var checkBox = new CheckBox
                {
                    Text = $"{SceneCollection[i].Name}",
                    Checked = SceneCollection[i].Visible,
                    Location = new Point(2, i * 25),
                    AutoSize = true,
                    Tag = i
                };

                // Subscribe to CheckedChanged event
                checkBox.CheckedChanged += (sender, e) =>
                {
                    var cb = sender as CheckBox;
                    int index = (int)cb.Tag; // Retrieve the index from Tag
                    SceneCollection[index].Visible = cb.Checked;
                    Util.ConsoleLog($"Item {index + 1} toggled to: {SceneCollection[index]}", Petrosik.Enums.InfoType.Info);
                    Invalidate();
                };

                p_scene.Controls.Add(checkBox);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!AllowRendering) return;
            var g = e.Graphics;
            var frame = Camera.RenderFrame(SceneCollection);
            for (int y = 0; y < frame.GetLength(1); y++)
            {
                for (int x = 0; x < frame.GetLength(0); x++)
                {
                    using (Brush brush = new SolidBrush(frame[x, y]))
                    {
                        g.FillRectangle(brush, x + 10, y + 10, 1, 1);
                    }
                }
            }
            if (cb_Auto.Checked)
            {
                foreach (var item in SceneCollection)
                {
                    item.Rotate(-90f / 8, 'z');
                    item.Rotate(90f / 8, 'y');
                    item.Rotate(90f / 12, 'x');
                }
                Invalidate();
            }
        }

        private void button_zmin_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(-45f, 'z');
            }
            Invalidate();
        }

        private void button_zpl_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(45f, 'z');
            }
            Invalidate();
        }

        private void button_ymin_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(-45f, 'y');
            }
            Invalidate();
        }

        private void button_ypl_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(45f, 'y');
            }
            Invalidate();
        }

        private void button_xmin_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(45f, 'x');
            }
            Invalidate();
        }

        private void button_xpl_Click(object sender, EventArgs e)
        {
            foreach (var item in SceneCollection)
            {
                item.Rotate(-45f, 'x');
            }
            Invalidate();
        }

        private void cb_Auto_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void cb_rcf_CheckedChanged(object sender, EventArgs e)
        {
            Camera.RandomFaceColor = cb_rcf.Checked;
            if (cb_rcf.Checked)
            {
                var r = new Random();
                for (int i = 0; i < SceneCollection.Count; i++)
                {
                    var rr = new List<Color>();
                    for (int j = 0; j < SceneCollection[i].Tris.Count; j++)
                    {
                        rr.Add(Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
                    }
                    Camera.RFColors.Add(rr);
                }
            }
            else
            {
                Camera.RFColors.Clear();
            }
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Camera.RayHitCollection(SceneCollection, new(e.X - 10, e.Y - 10), out float t, out var inter, out var obj, out var trisi))
            {
                Util.ConsoleLog($"{e.X - 10},{e.Y - 10} {t} {inter} {obj.Name} {trisi}", Petrosik.Enums.InfoType.Info);
                if (e.Button == MouseButtons.Left)
                {
                }
                else if (e.Button == MouseButtons.Right)
                {
                    var objs = SceneCollection.Where(x => x == obj)?.First();
                    if (objs?.CustomColors.Where(x => x.j == trisi).Count() > 0)
                    {
                        objs.CustomColors.Remove(objs.CustomColors.Where(x => x.j == trisi).First());
                    }
                    objs.CustomColors.Add((trisi, ClickColor));
                }
            }
            else
            {
                Util.ConsoleLog($"no obj", Petrosik.Enums.InfoType.Info);
            }
            Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Camera.MaxRenderDistance = (float)nud_Fog.Value / 10f;
            Invalidate();
        }

        private void p_colorpicker_MouseClick(object sender, MouseEventArgs e)
        {
            AllowRendering = false;
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    p_colorpicker.BackColor = colorDialog.Color;
                    ClickColor = colorDialog.Color;
                }
                    AllowRendering = true;
            }
            Invalidate();
        }

        private void num_Res_ValueChanged(object sender, EventArgs e)
        {
            Camera.Resolution = (int)num_Res.Value;
            Invalidate();
        }

        private void p_backpick_MouseClick(object sender, MouseEventArgs e)
        {
            AllowRendering = false;
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    p_backpick.BackColor = colorDialog.Color;
                    Camera.WorldBackground = colorDialog.Color;
                }
                    AllowRendering = true;
            }
            Invalidate();
        }

        private void btn_ResetCol_Click(object sender, EventArgs e)
        {
            Camera.WorldBackground = new();
            p_backpick.BackColor = new();
            Invalidate();
        }
    }
}
