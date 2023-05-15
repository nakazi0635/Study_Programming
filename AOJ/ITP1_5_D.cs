using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int b = int.Parse(Console.ReadLine());// int型
        for (int i = 1; i <= b; i++){
            if (i % 3 == 0){
                Console.Write($"{i} ");
            }else if (i.ToString().Contains("3")){
                Console.Write($"{i} ");
            }
            Console.Write($"");
        }
    }
}