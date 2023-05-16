using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        while(true){
            string a = Console.ReadLine();
            if(a == "0"){
                break;
            }
            int sum = 0;
            char[] b = a.ToCharArray();
            for (int i = 0; i < b.Length; i++){
                // sum += int.Parse(b[i]);
                sum += (int)Char.GetNumericValue(b[i]);
                // Console.WriteLine(b[i]);
            }
            Console.WriteLine(sum);
        }
    }
}