namespace wednesdayeveningwork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(TriangleMumboJumbo.TwoSidesAndAngle(3,8,44));

            //TriangleMumboDumbo triangle = new TriangleMumboDumbo(3, 8);
            //Console.WriteLine(triangle.SideTimesBase());

            //TriangleAngle angleTriangle = new TriangleAngle(44, 10, 3);
            //Console.WriteLine(angleTriangle.TwoSidesAndAngle());

            TriangleWithThreeSides threeSides = new TriangleWithThreeSides(5, 7, 6);
            Console.WriteLine(threeSides.ThreeSides());

            Console.WriteLine(threeSides.SideC);
            Console.WriteLine(threeSides.SideB);
            Console.WriteLine(threeSides.SideA);
            Console.WriteLine(threeSides.SideTimesBase());           

            //NewTriangle baseTimesHeight = new NewTriangle();
            //Console.WriteLine(baseTimesHeight.SideTimesBase(2, 5)); 
        }
    }
    /// <summary>
    /// no inheritance in the first, just some static classes on how to calculcate I hope correctly
    /// of a triangle... my trigonometry is rusty...
    /// </summary>
    public class TriangleMumboJumbo
    {
        public static int SideTimesBase(int SideA, int SideB)
        {
            return SideA * SideB / 2;
        }

        public static double ThreeSides(double SideA, double SideB, double SideC)
        {
            double sum = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(sum * (sum - SideA) * (sum - SideB) * (sum - SideC));
        }

        public static double TwoSidesAndAngle(double SideA, double SideB, double angle)
        {
            double angleRadiance = angle * Math.PI / 180;
            return 0.5 * SideA * SideB * Math.Sin(angleRadiance);
        }
    }
    public class TriangleMumboDumbo
    {
        private double sideA;
        private double sideB;

        public TriangleMumboDumbo(double a, double b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double SideTimesBase()
        {
            return sideA * sideB / 2;
        }

    }
    /// <summary>
    /// in C#, base is a keyword that refers to the base class of the current class. 
    /// It is used to access members of the base class, including constructors, properties, and methods.
    /// When a class is derived from another class using inheritance, 
    /// the derived class inherits all the members of the base class, including its constructors.
    /// In such a case, the base keyword is used to call the constructor of the base class from the constructor of the derived class.
    /// </summary>
    public class TriangleAngle : TriangleMumboDumbo
    {
        private double angle;
        public TriangleAngle(double angle, double a, double b) : base(a, b)
        {
            this.angle = angle;
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public double TwoSidesAndAngle()
        {
            double angleRadiance = angle * Math.PI / 180;
            return 0.5 * SideA * SideB * Math.Sin(angleRadiance);
        }
    }
    public class TriangleWithThreeSides : TriangleMumboDumbo
    {
        private double sideC;
        public TriangleWithThreeSides(double c, double a, double b) : base(a, b)
        {
            this.sideC = c;
        }
        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        public double ThreeSides()
        {
            double sum = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(sum * (sum - SideA) * (sum - SideB) * (sum - SideC));
        }
    }
    public interface Triangle
    {
        double SideTripleA { get; set; }
        double SideTripleB { get; set; }

        double SideTimesBase(double sideTripleA, double sideTripleB);
    }
    public class NewTriangle : Triangle
    {
        public double SideTripleA { get; set; }
        public double SideTripleB { get; set; }     
       
        public double SideTimesBase(double sideTripleA, double sideTripleB)
        {
            return sideTripleA * sideTripleB / 2;
        }
    }
}  