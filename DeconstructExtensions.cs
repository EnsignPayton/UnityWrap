using UnityEngine;

namespace UnityWrap
{
    public static class DeconstructExtensions
    {
        public static void Deconstruct(this Vector2 vector, out float x, out float y)
        {
            x = vector.x;
            y = vector.y;
        }

        public static void Deconstruct(this Vector2Int vector, out int x, out int y)
        {
            x = vector.x;
            y = vector.y;
        }

        public static void Deconstruct(this Vector3 vector, out float x, out float y, out float z)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public static void Deconstruct(this Vector3Int vector, out int x, out int y, out int z)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public static void Deconstruct(this Vector4 vector, out float x, out float y, out float z, out float w)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
            w = vector.w;
        }

        public static void Deconstruct(this Quaternion quat, out float x, out float y, out float z, out float w)
        {
            x = quat.x;
            y = quat.y;
            z = quat.z;
            w = quat.w;
        }
    }
}
