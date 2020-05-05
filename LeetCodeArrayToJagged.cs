using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static void Main (string[] args)
    {
        System.Console.WriteLine ("How to use: Pass in array of the following format (NO SPACE):  [[1,2,3],[2,3,3],[3]], to turn it into c# jagges array.");
        string input = args[0];
        System.Console.WriteLine ("My input: " + input);
        var arrays = new List<string> ();
        var startIdx = -1;

        for (int i = 0; i != input.Length - 1; ++i)
        {
            if (input[i] == '[')
            {
                startIdx = i + 1;
            }
            else if (input[i] == ']')
            {
                arrays.Add (input.Substring (startIdx, i - startIdx));
            }
        }

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