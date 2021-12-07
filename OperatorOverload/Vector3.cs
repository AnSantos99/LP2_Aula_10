using System;

namespace OperatorOverload
{
    public struct Vector3
    {
        // Vector coordinates X, Y, Z
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        public float Magnitude => (float)Math.Sqrt(X*X, Y*Y, Z*Z);

        // Constructor
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator >(Vector3 v1, Vector3 v2) => 
            new Vector3 (v1.Magnitude > v2.Magnitude);

        public static bool operator <(Vector3 v1, Vector3 v2) => 
            new Vector3 (v1.Magnitude < v2.Magnitude);
    }
}
