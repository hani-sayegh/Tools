using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static void Main (string[] args)
    {
        string input = args[0];

        var arrays = new List<string> ();
        var stack = new Stack<int> ();
        for (int i = 0; i != input.Length; ++i)
        {
            if (input[i] == '[')
            {
                stack.Push (i);
            }
            else if (input[i] == ']')
            {
                var start = stack.Pop () + 1;
                arrays.Add (input.Substring (start, i - start));
            }
        }

        arrays.RemoveAt (arrays.Count - 1);

        var variableName = "gen";
        System.Console.WriteLine ($"var {variableName} = new int[{arrays.Count}][];");
        var j = 0;
        foreach (var item in arrays)
        {
            System.Console.Write ($"{variableName}[{j}] = ");
            System.Console.WriteLine ("new int [" + (item.Count (x => x == ',') + 1) + "] {" + item + "};");
            ++j;
        }
    }
}