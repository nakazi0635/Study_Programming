using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        string[] a = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(a, int.Parse);
        double c = Math.Sqrt(Math.Pow(b[0], 2) + Math.Pow(b[1], 2) - 2 * b[0] * b[1] * Math.Cos(b[2] * (Math.PI / 180)));
        // Console.WriteLine(c);
        double d = b[0] + b[1] + c;
        double e = d / 2;
        // Area = √(s * (s - a) * (s - b) * (s - c))
        double area = Math.Sqrt(e * (e - b[0]) * (e - b[1]) * (e - c));
        // Height = (2 * Area) / a
        double height = (2 * area) / b[0];
        Console.WriteLine($"{area.ToString("F8")}\n{d.ToString("F8")}\n{height.ToString("F8")}");
    }
}