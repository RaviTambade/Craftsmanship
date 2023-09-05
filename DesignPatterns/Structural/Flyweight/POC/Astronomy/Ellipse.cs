namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.Astronomy;
public class Ellipse
    {
        private readonly int height;
        private readonly int width;
        private readonly string color;
        public Ellipse(int height, int width, string color)
        {
            this.height = height;
            this.width = width;
            this.color = color;
        }
    }