using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleGenerator
  {
      private string _word;
      private char[] _wordChars;
      private int _wordValue = 0;

      public ScrabbleGenerator(string word)
      {
          _word = word;
      }

      Dictionary<char, int> letterValues = new Dictionary<char, int>()
      {
         {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {'n', 1}, {'r', 1}, {'s', 1}, {'t', 1},
         {'d', 2},{'g', 2},
         {'b', 3},{'c', 3},{'m', 3},{'p', 3},
         {'f', 4},{'h', 4},{'v', 4},{'w', 4},{'y', 4},
         {'k', 5},
         {'j', 8},{'x', 8},
         {'q', 10},{'z', 10}
     };

      public string GetInput()
      {
          return _word;
      }

      public char[] BreakWord()
      {
          _wordChars = _word.ToCharArray();
          return _wordChars;
      }

      public int WordCharVal()
      {
          foreach (char letter in _wordChars)
          {
              int valueHolder = letterValues[letter];
              _wordValue += valueHolder;
          }
          return _wordValue;
      }
  }
}
