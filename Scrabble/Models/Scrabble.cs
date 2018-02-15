using Microsoft.AspNetCore.Mvc;

namespace Scrabble.Models
{
  public class ScrabbleGenerator
  {
      private string _word;

      public ScrabbleGenerator(string word)
      {
          _word = word;
      }

      public string GetInput()
      {
          return "fuck";
      }
  }
}
