using System;

namespace Indexers
{
    public struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float this[int index]
        {
            get
            {
                if(index == 0) return X;
                else if(index == 1) return Y;
                throw new IndexOutOfRangeException();
                
            }

            set
            {
                if(index == 0) X = value;
                else if(index == 1) Y = value;
                throw new IndexOutOfRangeException();
                
            }
        }

        public float this [string index]
        {
            get
            {
                index = index.ToLower();

                if(index == "x" || index == "a" || index == "0") return X;
                if(index == "y" || index == "b" || index == "1") return Y;
                throw new ArgumentException();
                
            }
        }
    }
}