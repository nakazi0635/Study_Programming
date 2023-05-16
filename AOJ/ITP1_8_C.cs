using System;
using System.IO;
using System.Linq;
public class Hello{
    public static void Main(){
        int[] a = new int[500];
        while (true){
            string s = Console.ReadLine();
            if (s == null) break;
            s = s.ToLower();
            for(int i = 0; i < s.Length; i++){
                a[s[i]]++;
            }
        }
        for(int i = 'a'; i <= 'z'; i++){
            Console.WriteLine((char)i + " : " + a[i]);
        }

    }
}