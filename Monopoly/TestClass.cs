﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using Monopoly.Companies;
using NUnit.Framework;

namespace Monopoly
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void GetPlayersListReturnCorrectList()
        {
            string[] players = new string[]{ "Peter","Ekaterina","Alexander" };
            Player[] expectedPlayers = new Player[]
            {
                new Player("Peter",6000),
                new Player("Ekaterina",6000),
                new Player("Alexander",6000)
            };
            Monopoly monopoly = new Monopoly(players);
            Player[] actualPlayers = monopoly.GetPlayersList().ToArray();

            Assert.AreEqual(expectedPlayers, actualPlayers);
        }
        [Test]
        public void GetFieldsListReturnCorrectList()
        {
            Company[] expectedCompanies = 
                new Company[]{
                new Auto("Ford",0,false),
                new Food("MCDonald", 0, false),
                new Clother("Lamoda", 0, false),
                new Travel("Air Baltic",0,false),
                new Travel("Nordavia",0,false),
                new Prison("Prison",0,false),
                new Food("MCDonald",0,false),
                new Auto("TESLA",0,false)
            };
            string[] players = new string[] { "Peter", "Ekaterina", "Alexander" };
            Monopoly monopoly = new Monopoly(players);
            Company[] actualCompanies = monopoly.GetFieldsList().ToArray();
            Assert.AreEqual(expectedCompanies, actualCompanies);
        }
        [Test]
        public void PlayerBuyNoOwnedCompanies()
        {
            string[] players = new string[] { "Peter", "Ekaterina", "Alexander" };
            Monopoly monopoly = new Monopoly(players);
            var x = monopoly.GetFieldByName("Ford");
            monopoly.Buy(1, x);
            var actualPlayer = monopoly.GetPlayerInfo(1);
            var expectedPlayer = new Player("Peter", 5500);
            Assert.AreEqual(expectedPlayer, actualPlayer);
            var actualField = monopoly.GetFieldByName("Ford");
            Assert.AreEqual(1, actualField.OwnerIndex);
        }
        [Test]
        public void RentaShouldBeCorrectTransferMoney()
        {
            string[] players = new string[] { "Peter", "Ekaterina", "Alexander" };
            Monopoly monopoly = new Monopoly(players);
            var  x = monopoly.GetFieldByName("Ford");
            monopoly.Buy(1, x);
            x = monopoly.GetFieldByName("Ford");
            monopoly.Renta(2, x);
            var player1 = monopoly.GetPlayerInfo(1);
            Assert.AreEqual(5750, player1.Cash);
            var player2 = monopoly.GetPlayerInfo(2);
            Assert.AreEqual(5750, player2.Cash);
        }
    }
}
