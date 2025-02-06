using Petrosik.Utility;
using System.Numerics;

namespace CustomRenderer
{
    public class Camera
    {
        public Vector3 Origin = new(-2, 0.5f, 0.5f);
        public Vector3 Rotation = new(1, 0, 0);
        /// <summary>
        /// size of the display in world units
        /// </summary>
        public Vector2 ScreenSize = new(0.5f, 0.5f);
        /// <summary>
        /// how many pixels in one world unit
        /// </summary>
        public int Resolution = 1000;
        public float ClipPlaneDistance = 0.5f;
        public float MaxRenderDistance = 4f;
        public Color WorldBackground = Color.Black;

        public bool RandomFaceColor = false;
        public List<List<Color>> RFColors = new();
        public Camera(Vector3 position, Vector3 rotation)
        {
            Origin = position;
            Rotation = rotation;
        }
        public Camera() { }


        public Color[,] RenderFrame(List<Object> SceneCollection)
        {
            var dd = Origin + Rotation * ClipPlaneDistance;
            var columnCorner = dd + new Vector3(0, ScreenSize.X / 2f, -(ScreenSize.Y / 2f));

            var frame = new Color[(int)(ScreenSize.X * Resolution), (int)(ScreenSize.Y * Resolution)];

            for (int y = 0; y < frame.GetLength(1); y++)
            {
                for (int x = 0; x < frame.GetLength(0); x++)
                {
                    frame[x, y] = WorldBackground;
                    var closest = MaxRenderDistance;
                    for (int i = 0; i < SceneCollection.Count; i++)
                    {
                        if (!SceneCollection[i].Visible) continue;

                        Color? targetcolor = null;
                        var multiplier = -1f;
                        for (int j = 0; j < SceneCollection[i].Tris.Count; j++)
                        {
                            var columnrel = new Vector3(columnCorner.X, columnCorner.Y - y * (ScreenSize.Y / (float)Resolution) * 2, columnCorner.Z + x * (ScreenSize.X / (float)Resolution) * 2);
                            if (RayIntersectsTriangle(columnrel, Origin.Direction(columnrel), SceneCollection[i].Tris[j], out var dis, out var inters) && dis < closest)
                            {
                                multiplier = 1 - dis.Normalize(0, MaxRenderDistance);
                                if (!RandomFaceColor)
                                {
                                    var cust = SceneCollection[i].CustomColors.Where(x => x.j == j);
                                    if (cust.Count() > 0)
                                    {
                                        var c = cust.First().c;
                                        targetcolor = c;
                                    }
                                    else
                                    {
                                        targetcolor = SceneCollection[i].Color;
                                    }
                                }
                                else
                                {
                                    targetcolor = RFColors[i][j];
                                }
                                closest = dis;
                            }
                        }
                        if (targetcolor != null)
                        {
                            frame[x, y] = Color.FromArgb((int)(targetcolor.Value.A * multiplier + WorldBackground.A * (1 - multiplier)), (int)(targetcolor.Value.R * multiplier + WorldBackground.R * (1 - multiplier)), (int)(targetcolor.Value.G * multiplier + WorldBackground.G * (1 - multiplier)), (int)(targetcolor.Value.B * multiplier + WorldBackground.B * (1 - multiplier)));
                        }
                    }
                }
            }

            return frame;
        }
        public bool RayHitCollection(List<Object> SceneCollection, Vector2 ScreenPixel, out float t, out Vector3 intersectionPoint, out Object Obj, out int trisIndex)
        {
            t = -1;
            intersectionPoint = new();
            trisIndex = 0;
            Obj = null;
            var closest = float.MaxValue;
            foreach (var obj in SceneCollection)
            {
                if (obj.Visible && RayHit(obj, ScreenPixel, out var t1, out intersectionPoint, out var trisIndex1) && t1 < closest)
                {
                    Obj = obj;
                    closest = t1;
                    t = t1;
                    trisIndex = trisIndex1;
                }
            }
            if (t == -1)
            {
                return false;
            }
            return true;
        }
        public bool RayHit(Object Obj, Vector2 ScreenPixel, out float t, out Vector3 intersectionPoint, out int trisIndex)
        {
            var dd = Origin + Rotation * ClipPlaneDistance;
            var columnCorner = dd + new Vector3(0, ScreenSize.X / 2f, -(ScreenSize.Y / 2f));
            var columnrel = new Vector3(columnCorner.X, columnCorner.Y - ScreenPixel.Y * (ScreenSize.Y / (float)Resolution) * 2, columnCorner.Z + ScreenPixel.X * (ScreenSize.X / (float)Resolution) * 2);
            var closest = float.MaxValue;
            t = -1;
            intersectionPoint = new();
            trisIndex = 0;
            for (int i = 0; i < Obj.Tris.Count; i++)
            {
                if (RayIntersectsTriangle(columnrel, Origin.Direction(columnrel), Obj.Tris[i], out var t1, out var intersectionPoint1) && t1 < closest)
                {
                    trisIndex = i;
                    closest = t1;
                    t = t1;
                    intersectionPoint = intersectionPoint1;
                }
            }
            if (t == -1)
            {
                return false;
            }
            return true;
        }
        public bool RayIntersectsTriangle(Vector3 rayOrigin, Vector3 rayDirection, List<Vector3> tri, out float t, out Vector3 intersectionPoint)
        {
            t = 0;
            intersectionPoint = Vector3.Zero;

            Vector3 edge1 = tri[1] - tri[0];
            Vector3 edge2 = tri[2] - tri[0];

            Vector3 h = Vector3.Cross(rayDirection, edge2);
            float a = Vector3.Dot(edge1, h);

            if (Math.Abs(a) < 1e-6) // Parallel
                return false;

            float f = 1.0f / a;
            Vector3 s = rayOrigin - tri[0];
            float u = f * Vector3.Dot(s, h);

            if (u < 0.0f || u > 1.0f)
                return false;

            Vector3 q = Vector3.Cross(s, edge1);
            float v = f * Vector3.Dot(rayDirection, q);

            if (v < 0.0f || u + v > 1.0f)
                return false;

            t = f * Vector3.Dot(edge2, q);

            if (t > 1e-6) // Intersection point is in front of the ray origin
            {
                intersectionPoint = rayOrigin + t * rayDirection;
                return true;
            }

            return false;
        }
    }
}
