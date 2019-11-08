using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadTrackRepeat.Data;
using System;

namespace ReadTrackRepeat.Tests
{
  [TestClass]
  public class RtrApiTests
  {
    [TestMethod]
    public void ChallengeExists()
    {
      // Arrange
      var expected = 2019;

      // Act 
      var challenge = new Challenge(2019);
      var actual = challenge.Year;

      // Assert
      Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void ChallengeEmptyCtorSetsCurrentYear()
    {
      var expected = DateTime.Now.Year;

      var challenge = new Challenge();
      var actual = challenge.Year;

      Assert.AreEqual(expected, actual);
    }
  }
}
