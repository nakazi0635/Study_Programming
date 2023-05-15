using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        while(true){
            string[] a = Console.ReadLine().Split(" ");
            int[] b = Array.ConvertAll(a, int.Parse);
            if(b[0] == 0 &&b[1] == 0){
                break;
            }
            for (int i = 0; i < b[0]; i++){
                for(int j = 0; j < b[1]; j++){
                    if (i == 0 || j == 0 || i == b[0] - 1 || j == b[1] - 1){
                        Console.Write("#");
                    }else{
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}