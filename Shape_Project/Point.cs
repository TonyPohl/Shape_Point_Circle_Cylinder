namespace Shape_Project
{
    internal class Point : Shape
    {
        private int u, v;
        public int U { get; set; }
        public int V { get; set; }

        public Point(int u, int v)
        {
            U = u;
            V = v;
        }

        public Point()
        {
            //We don´t need variables U and V for inheritance, therefore an empty constructor
        }
        /// <summary>
        /// Text represents a POINT class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format($"This is POINT CLASS:\nPoint u: {U} and Point v: {V}\n");

        }
    }
}
