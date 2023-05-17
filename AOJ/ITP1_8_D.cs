using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        string repeatedString = (new string('*', 2)).Replace("*", Console.ReadLine());
        string b = Console.ReadLine();

        // Console.WriteLine(repeatedString);
        if (repeatedString.Contains(b)){
            Console.WriteLine("Yes");
        }else{
            Console.WriteLine("No");
        }
    }
}