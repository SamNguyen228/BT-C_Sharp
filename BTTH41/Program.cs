using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<List<string>> myList = new List<List<string>>();
        myList.Add(new List<string> {"a", "b"});
        myList.Add(new List<string>{"c", "d", "e"});
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });

        //To iterate over it
        for (int i = 0; i < myList.Count; i++)
        {
            for(int j = 0; j < myList[i].Count; j++)
            {
                Console.WriteLine(myList[i][j]);
            }
        }
    }
}