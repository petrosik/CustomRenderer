using Petrosik.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomRenderer
{
    public static class Utility
    {
        public static Vector3 Normalize(this Vector3 v)
        {
            return Vector3.Normalize(v);
        }
        /// <summary>
        /// from v1 to v2
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector3 Direction(this Vector3 v1, Vector3 v2)
        {
            return (v2-v1).Normalize();
        }
    }
}
