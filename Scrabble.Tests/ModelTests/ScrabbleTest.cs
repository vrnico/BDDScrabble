using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void GetInput_ReturnInput()
    {
        //arrange
        ScrabbleGenerator newScrabbleGenerator = new ScrabbleGenerator("");
        string testInput = "";
        //act
        string testString = newScrabbleGenerator.GetInput();

        //assert
        Assert.AreEqual(testInput, testString);
    }

    [TestMethod]
    public void BreakWordIntoChars_ReturnCharArray()
    {
        //arrange
        ScrabbleGenerator newScrabbleGenerator = new ScrabbleGenerator("word");
        char[] testInput = { 'w', 'o', 'r', 'd' };
        //act
        char[] testString = newScrabbleGenerator.BreakWord();
        //assert
        Assert.AreEqual(testString[0], testInput[0]);
    }
  }
}
