using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        string a = Console.ReadLine();
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        int count = 0;
        while (true){
            string[] c = Console.ReadLine().Split();
            if (c[0] == "END_OF_TEXT"){
                break;
            }
            for (int i = 0; i < c.Length; i++){
                if (c[i].ToUpper() == a.ToUpper()){
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}