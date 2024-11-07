using System.Formats.Asn1;

namespace Assignment_1_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 5.5;
            double result = SquareArea(squareLength);
            Console.WriteLine(result);

            double triangleBase = 8;
            double triangleHeight = 4;
            double triangleResult = TriangleArea(triangleBase, triangleHeight);
            Console.WriteLine(triangleResult);

            double rectangleLength = 9;
            double rectangleWidth = 3;
            double rectangleResult = TriangleArea(rectangleLength, rectangleWidth);
            Console.WriteLine(rectangleResult);

        }
        

        static double SquareArea(double length)
        {
            double area = length * length;

            return area;
        }

        static double TriangleArea(double length, double baset)
        {
            double area = (length * baset) / 2;

            return area;
        }

        static double RectangleArea(double length, double width)
        {
            double area = length * width;

            return area;
        }

    }

    // 1_3_2

    int[] arrayExample; 

    string [] carArray = { "Honda", "BMW", "Jeep", "Lambo"};

  arrayResult =  Console.WriteLine(carArray.Length);

        Array.Sort(carArray);

        foreach (string i in carArray)
{
  Console.WriteLine(i);
}


