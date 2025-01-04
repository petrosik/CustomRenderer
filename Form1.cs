using System.Numerics;

namespace CustomRenderer
{
    public partial class Form1 : Form
    {
        public static List<Object> SceneCollection = new List<Object>();
        public static Camera Camera = new Camera();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
                new() {new(1, 0, 1), new(0, 1, 1), new(1, 1, 1)},
                new() {new(0, 0, 0), new(0, 1, 0), new(0, 0, 1)},
                new() {new(0, 1, 0), new(0, 1, 1), new(0, 0, 1)},
                new() {new(1, 0, 0), new(1, 0, 1), new(1, 1, 0)},
                new() {new(1, 0, 1), new(1, 1, 1), new(1, 1, 0)},
                new() {new(0, 1, 0), new(1, 1, 0), new(0, 1, 1)},
                new() {new(1, 1, 0), new(1, 1, 1), new(0, 1, 1)},
                new() {new(0, 0, 0), new(0, 0, 1), new(1, 0, 0)},
                new() {new(1, 0, 0), new(0, 0, 1), new(1, 0, 1)}
            }, Color.White, orign));

            Camera.Resolution = 500;
            //Camera.MaxRenderDistance = 2f;
            //var d = Camera.RayIntersectsTriangle(new(-1, 0.2f, 0.2f), new(0.9f, 0.1f, 0), SceneColection[0].Tris[0],out var t,out var inter);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
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
    }
}
