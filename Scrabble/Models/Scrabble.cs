using Microsoft.AspNetCore.Mvc;

namespace Scrabble.Models
{
  public class ScrabbleGenerator
  {
      private string _word;
      private string _wordChars;

      public ScrabbleGenerator(string word)
      {
          _word = word;
      }

      public string GetInput()
      {
          return _word;
      }
      public string BreakWord()
      {
          return _word;
      }
  }
}
