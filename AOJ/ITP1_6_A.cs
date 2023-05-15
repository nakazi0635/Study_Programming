using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int a = int.Parse(Console.ReadLine());// int型
        string[] b = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(b, int.Parse);
        for (int i = c.Length - 1; i >= 0; i--){
            if (i == 0){
                Console.WriteLine($"{c[i]}");
            }else{
            Console.Write($"{c[i]} ");
            }
        }
    }
}