using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        while(true){
            string[] a = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(a, int.Parse);
            if (b[0] == -1 && b[1] == -1 && b[2] == -1){
                break;
            }
            if (b[0] == -1 || b[1] == -1){
                Console.WriteLine("F");
            }else if(b[0] + b[1] >= 80){
                Console.WriteLine("A");
            }else if(b[0] + b[1] >= 65){
                Console.WriteLine("B");
            }else if(b[0] + b[1] >= 50){
                Console.WriteLine("C");
            }else if(b[0] + b[1] >= 30){
                if(b[2] >= 50){
                    Console.WriteLine("C");
                }else{
                    Console.WriteLine("D");
                }
            }else{
                Console.WriteLine("F");
            }
        }
    }
}