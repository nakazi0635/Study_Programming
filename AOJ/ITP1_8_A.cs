using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
    string a = Console.ReadLine();

        for (var i = 0; i < a.Length; i++)
        {
            if (a.Substring(i, 1) == a.Substring(i, 1).ToLower())
            {
                Console.Write(a.Substring(i, 1).ToUpper());
            }
            else
            {
                Console.Write(a.Substring(i, 1).ToLower());
            }
        }
        Console.WriteLine();
    }
}