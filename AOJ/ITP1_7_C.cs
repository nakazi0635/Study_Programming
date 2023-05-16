using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        string[] a = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(a, int.Parse);
        int row = b[0];
        int col = b[1];
        // 二次元配列の作成
        // 二次元配列の作成
        int[,] array = new int[row, col];
        // 二次元配列の作成と入力
        for (int i = 0; i < row; i++){
            string[] input1 = Console.ReadLine().Split(' ');
            for (int j = 0; j < col; j++){
                array[i, j] = int.Parse(input1[j]);
            }
        }
        int sum1 = 0;
        int sum2 = 0;
        // 二次元配列の内容
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                Console.Write(array[i, j] + " ");
                sum1 += array[i, j];
            }
            Console.Write(sum1);
            sum2 += sum1;
            sum1 = 0;
            Console.WriteLine();
        }
        for (int i = 0; i < col; i++){
            for (int j = 0; j < row; j++){
                sum1 += array[j, i];
            }
            Console.Write($"{sum1} ");
            sum1 = 0;
        }
        Console.Write(sum2);
        Console.WriteLine();
    }
}