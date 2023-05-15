using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int[,] array = new int[4, 13];
            // Console.WriteLine(array[1, 0]);
            int a = int.Parse(Console.ReadLine());
            int card1 = 0;
            int card = 52;
            int row = 4;
            int col = 13;
            for (int i = 0; i < a; i++){
                string[] b = Console.ReadLine().Split();
                // Console.WriteLine($"{b[0]}, {b[1]}");
                if (b[0] == "S"){
                    card1 = 0;
                    array[card1, int.Parse(b[1])- 1] = 1;
                }else if (b[0] == "H"){
                    card1 = 1;
                    array[card1, int.Parse(b[1])- 1] = 1;
                }else if (b[0] == "C"){
                    card1 = 2;
                    array[card1, int.Parse(b[1])- 1] = 1;
                }else{
                    card1 = 3;
                    array[card1, int.Parse(b[1])- 1] = 1;
                }
            }
            for (int j = 0; j < row; j++){
                for (int k = 0; k < col; k++){
                    if (array[j, k] == 0){
                        if (j == 0){
                            Console.WriteLine($"S {k+1}");
                        }else if (j == 1){
                            Console.WriteLine($"H {k+1}");
                        }else if (j == 2){
                            Console.WriteLine($"C {k+1}");
                        }else{
                            Console.WriteLine($"D {k+1}");
                        }
                    }
                }
            }
    }
}