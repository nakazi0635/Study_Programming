using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int[,,] array3D = new int[10,3,4];
        int num_sharp = 0;
        int a = int.Parse(Console.ReadLine());
        for (int i = 0; i < a; i++){
            string[] b = Console.ReadLine().Split(" ");
            int[] c = Array.ConvertAll(b, int.Parse);
            // Console.WriteLine($"{c[0]} {c[1]} {c[2]} {c[3]}");
            array3D[c[2] - 1, c[1] - 1, c[0] - 1] += c[3];
            if (array3D[c[2] - 1, c[1] - 1, c[0] - 1] < 0){
                array3D[c[2] - 1, c[1] - 1, c[0] - 1] = 0;
            }else if(array3D[c[2] - 1, c[1] - 1, c[0] - 1] > 9){
                array3D[c[2] - 1, c[1] - 1, c[0] - 1] = 9;
            }

        }
        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 3; j++){
                for (int k = 0; k < 10; k++){
                    Console.Write($" {array3D[k, j, i]}");
                }
                Console.WriteLine();
            }
            if (num_sharp == 3){
                break;
            }
            Console.WriteLine($"####################");
            num_sharp += 1;
        }
    }
}