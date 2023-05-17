using System;
using System.IO;
using System.Text;
using System.Linq;
public class Hello{
    public static void Main(){
        while (true){
            string a = Console.ReadLine();
            StringBuilder b = new StringBuilder(a);
            if (b[0] == '-'){
                break;
            }
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++){
                int d = int.Parse(Console.ReadLine());
                // char [] e = b[0..d];
                b.Remove(0, d);
                b.Append(a.Substring(0, d));
                a = b.ToString();
                // Console.WriteLine(b.ToString());
            }
            Console.WriteLine(b.ToString());

        }
    }
}