using Microsoft.AspNetCore.Mvc;
using System;

namespace Scrabble.Models
{
  public class ScrabbleGenerator
  {
      private string _word;
      private char[] _wordChars;

      public ScrabbleGenerator(string word)
      {
          _word = word;
      }

      public string GetInput()
      {
          return _word;
      }
      public char[] BreakWord()
      {
          _wordChars = _word.ToCharArray();
          return _wordChars;
      }
  }
}
