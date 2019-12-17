using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CoinLogic;

namespace CoinTung.Tests
{
  [TestClass]
  public class CoinLogicy
  {
    
    [TestMethod]
    public void ChangeCalculator_ReturnsQuarterQuantity_3()
    {
        CoinTactics user = new CoinTactics(0.92);
        user.ChangeCalculator();
        Assert.AreEqual(3,user.GetQuarter());
    }
    [TestMethod]
    public void ChangeCalculator_ReturnsDimeQuantity_1()
    {
        CoinTactics user = new CoinTactics(0.92);
        user.ChangeCalculator();
        Assert.AreEqual(1,user.GetDime());
    }
    [TestMethod]
    public void ChangeCalculator_ReturnsNickelQuantity_1()
    {
        CoinTactics user = new CoinTactics(0.92);
        user.ChangeCalculator();
        Assert.AreEqual(1,user.GetNickel());
    }
    [TestMethod]
    public void ChangeCalculator_ReturnsPennyQuantity_3()
    {
        CoinTactics user = new CoinTactics(0.92);
        user.ChangeCalculator();
        Assert.AreEqual(3,user.GetPenny());
    }
  }
}