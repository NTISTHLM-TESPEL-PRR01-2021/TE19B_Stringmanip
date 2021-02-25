using System.Linq;
using System;
using System.Collections.Generic;

namespace Stringmanip
{
  class Program
  {
    static void Main(string[] args)
    {
      // string[] names = {"Herbert", "Anna", "Eva-Lisa", "Mohammad"};

      // string nameAll = string.Join("\n* ", names);

      // Console.WriteLine(nameAll);

      // string sentence = "har fan 5 exakt likadana muggar på mitt bord";

      // string[] words = sentence.Split(" ");

      // Console.WriteLine($"Meningen har {words.Length} ord");

      // Dictionary<string, string> curseWords = new Dictionary<string, string>();

      // curseWords.Add("jävla", "j*vla");
      // curseWords.Add("röv", "r*v");
      // curseWords.Add("fan", "f*n");

      // string sentence = "har fan 5 exakt likadana jävla rövmuggar på mitt bord";

      // foreach (string curseWord in curseWords.Keys.ToArray())
      // {
      //   sentence = sentence.Replace(curseWord, curseWords[curseWord]);
      // }

      // sentence = sentence.Replace("jävla", "*****");

      // string sentence = "   har fan 5 exakt likadana jävla rövmuggar på mitt bord";

      // string answer = "             \n  ja   ";

      // answer = answer.Trim();

      // if (answer == "ja")
      // {
      //   Console.WriteLine("NEJ");
      // }

      // Console.WriteLine(sentence.Trim());

      // string answer = Console.ReadLine();

      // // answer = answer.ToLower();

      // if (answer == "ja")
      // {
      //   Console.WriteLine("nånting");
      // }

      // string sentence = "har fan 5 exakt likadana muggar på mitt bord";

      // bool lastWasSpace = true;
      // for (int i=0; i < sentence.Length; i++)
      // {
      //   if (lastWasSpace == true)
      //   {
      //     string c = sentence[i].ToString();
      //     sentence = sentence.Remove(i, 1);
      //     sentence = sentence.Insert(i, c.ToUpper());
      //     lastWasSpace = false;
      //   }

      //   if (sentence[i] == ' ')
      //   {
      //     lastWasSpace = true;
      //   }
      // }

      string sentence = "har fan 5 exakt likadana muggar på mitt bord";

      // sentence = sentence.Remove(5, 12);
      //sentence = sentence.Insert(3, " definitivt");

      int place = sentence.IndexOf("mugg");

      sentence = sentence.Insert(place - 1, " hej");


      Console.WriteLine(sentence);


      Console.ReadLine();
    }
  }
}
