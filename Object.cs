using System;
using System.Collections.Generic;
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
        public Color Color { get; set; } = Color.White;
        public Vector3 Origin { get; set; } = new();
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
        public Object()
        {

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

        public override string ToString()
        {
            return $"{Name} ({Color.R},{Color.G},{Color.B},{Color.A}) | TrisCount: {Tris.Count}";
        }
    }
}
