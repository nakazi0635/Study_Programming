using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
public class Hello{
    public static void Main(){
        int count = 0;
        while(true){
            string[] a = Console.ReadLine().Split();
            int[] b = Array.ConvertAll(a, int.Parse);
            if (b[0] == 0 || b[1] == 0){
                break;
            }
            List<int> list1 = Enumerable.Range(1, b[0]).ToList();
            List<List<int>> combinations = new List<List<int>>();
            foreach (var comb in Combinations(list1, 3)) {
                combinations.Add(comb.ToList());
            }

            foreach(var comb in combinations) {
                // Console.WriteLine(comb[0]);
                if (comb[0] + comb[1] + comb[2] == b[1]){
                    count += 1;
                    // Console.WriteLine(string.Join(",", comb));
                }
            }
            Console.WriteLine(count);
            count = 0;
        }
    }
    static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> elements, int k) {
            return k == 0 ? new[] { new T[0] } :
                elements.SelectMany((e, i) =>
                    Combinations(elements.Skip(i + 1), k - 1).Select(c => (new[] { e }).Concat(c)));

    }
}