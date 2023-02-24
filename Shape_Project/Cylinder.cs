namespace Shape_Project
{
    internal class Cylinder : Circle
    {
        private double volume;
        public double Height { get; set; }

        public Cylinder(double height, double radius) : base(radius)
        {
            Height = height;
        }
        /// <summary>
        /// Returns calculating of volume
        /// </summary>
        /// <param name="height"></param>
        /// <param name="radius"></param>
        /// <returns>VOLUME</returns>
        public double GetVolume(double height, double radius)
        {
            volume = Math.PI * Math.Pow(radius, 2) * height;
            return volume;
        }
        /// <summary>
        /// Returns calculating of circumference, overridden method from CIRCLE
        /// </summary>
        /// <param name="radius"></param>
        /// <returns>CIRCUMFERENCE</returns>
        public override double GetCircumference(double radius)
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }
        /// <summary>
        /// Returns calculating of area 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="radius"></param>
        /// <returns>AREA</returns>
        public double GetArea(double height, double radius)
        {
            area = (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
            return area;
        }
        /// <summary>
        /// Text represents a CYLINDER class
        /// </summary>
        /// <returns>Volume and area</returns>
        public override string ToString()
        {
            return $"This is CYLINDER CLASS:\nHeight: {Height}\nRadius: {Radius}\nVolume: {volume}\nCircumference: {circumference}\nArea: {area}\n";
        }
    }
}
