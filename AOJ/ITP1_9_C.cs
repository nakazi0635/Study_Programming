using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int point_1 = 0;
        int point_2 = 0;
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < a; i++){
            string[] tango = Console.ReadLine().Split();
            if (tango[0] == tango[1]){
                point_1++;
                point_2++;
            }else if (tango[0].CompareTo(tango[1]) > 0){
                point_1 += 3;
            }else{
                point_2 += 3;
            }
        }
        Console.Write($"{point_1} {point_2}\n");
    }
}