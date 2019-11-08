using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadTrackRepeat.Tests
{
  [TestClass]
  public class RtrApiTests
  {
    [TestMethod]
    public void ChallengeExists()
    {
      // Arrange


      // Act 
      var actual = new Challenge();

      // Assert
      Assert.IsInstanceOfType(actual, typeof(Challenge));
    }
  }
}
