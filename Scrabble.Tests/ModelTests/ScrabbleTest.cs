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
  }
}
