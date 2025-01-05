using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomRenderer
{
    public class Object
    {
        public string Name { get; set; } = "New Object";
        public List<List<Vector3>> Tris { get; set; } = new();
        public List<(int j, Color c)> CustomColors { get; set; } = new();
        public Color Color { get; set; } = Color.White;
        public Vector3 Origin { get; set; } = new();
        private Vector3 position = new();
        public Vector3 Position { get 
            { return position; } 
            set 
            {
                var diff =value - position;
                for (int i = 0; i < Tris.Count; i++)
                {
                    for (int j = 0; j < Tris[i].Count; j++)
                    {
                        Tris[i][j] += diff; 
                    }
                }
                Origin += diff;
                position = value; 
            } }
        private float scale = 1f;
        public float Scale
        {
            get
            { return scale; }
            set
            {
                ScaleMod(value);
                scale = value;
            }
        }
        public bool Visible { get; set; } = true;

        public Object(string name, List<List<Vector3>> tris, Color color, Vector3 Origin)
        {
            Name = name;
            Tris = tris;
            Color = color;
            this.Origin = Origin;
        }
        public Object(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        public Object(string objFilePath)
        {
            LoadFromOBJ(objFilePath);
        }
        public Object()
        {

        }
        public void ScaleMod(float scaleFactor)
        {
            for (int i = 0; i < Tris.Count; i++)
            {
                for (int j = 0; j < Tris[i].Count; j++)
                {
                    // Translate vertex to origin
                    Vector3 translatedVertex = Tris[i][j] - Origin;

                    // Scale the translated vertex
                    translatedVertex *= scaleFactor;

                    // Translate the vertex back to its original position
                    Tris[i][j] = translatedVertex + Origin;
                }
            }
        }

        public void Rotate(float angle, char axis)
        {
            // Create rotation matrix
            Matrix4x4 rotationMatrix = GetRotationMatrix(angle, axis);

            // Rotate each vertex around the object's origin
            for (int i = 0; i < Tris.Count; i++)
            {
                for (int j = 0; j < Tris[i].Count; j++)
                {      
                // Translate the vertex to the origin
                Vector3 translatedVertex = Tris[i][j] - Origin;

                // Apply rotation
                Vector3 rotatedVertex = Vector3.Transform(translatedVertex, rotationMatrix);

                    // Translate the vertex back
                    Tris[i][j] = rotatedVertex + Origin;
                }
            }
        }

        private Matrix4x4 GetRotationMatrix(float angle, char axis)
        {
            // Convert angle to radians
            float radians = MathF.PI * angle / 180f;

            // Create the rotation matrix based on the axis
            Matrix4x4 rotationMatrix = axis switch
            {
                'x' => new Matrix4x4(
                    1, 0, 0, 0,
                    0, MathF.Cos(radians), -MathF.Sin(radians), 0,
                    0, MathF.Sin(radians), MathF.Cos(radians), 0,
                    0, 0, 0, 1),
                'y' => new Matrix4x4(
                    MathF.Cos(radians), 0, MathF.Sin(radians), 0,
                    0, 1, 0, 0,
                    -MathF.Sin(radians), 0, MathF.Cos(radians), 0,
                    0, 0, 0, 1),
                'z' => new Matrix4x4(
                    MathF.Cos(radians), -MathF.Sin(radians), 0, 0,
                    MathF.Sin(radians), MathF.Cos(radians), 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1),
                _ => throw new ArgumentException("Invalid axis, must be 'x', 'y', or 'z'.")
            };

            return rotationMatrix;
        }

        private void LoadFromOBJ(string filePath)
        {
            List<Vector3> vertices = new(); // Temporary storage for vertices
            foreach (var line in File.ReadLines(filePath))
            {
                // Parse vertices
                if (line.StartsWith("o "))
                {
                    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Name = $"{parts[1]} (imported)";
                }
                    if (line.StartsWith("v "))
                {
                    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var vertex = new Vector3(
                        float.Parse(parts[1], CultureInfo.InvariantCulture),
                        float.Parse(parts[2], CultureInfo.InvariantCulture),
                        float.Parse(parts[3], CultureInfo.InvariantCulture)
                    );
                    vertices.Add(vertex);
                }
                // Parse faces (triangles)
                else if (line.StartsWith("f "))
                {
                    var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var v1 = vertices[int.Parse(parts[1].Split('/')[0]) - 1]; // OBJ indices start from 1
                    var v2 = vertices[int.Parse(parts[2].Split('/')[0]) - 1];
                    var v3 = vertices[int.Parse(parts[3].Split('/')[0]) - 1];

                    // Create a triangle and add it to the list
                    Tris.Add(new List<Vector3> { v1, v2, v3 });
                }
            }
        }
        public override string ToString()
        {
            return $"{Name} ({Color.R},{Color.G},{Color.B},{Color.A}) | TrisCount: {Tris.Count}";
        }
    }
}
