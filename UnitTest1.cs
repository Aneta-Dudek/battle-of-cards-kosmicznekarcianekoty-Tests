using System;
using Xunit;
using Card_Game;
using System.Collections.Generic;

namespace battle_of_cards_kosmicznekarcianekoty_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            List<string> expectedValue = new List<string>(){
                "A,A,1,1,1,1",
                "B,B,2,2,2,2",
                "C,C,3,3,3,3",
                "D,D,4,4,4,4"
            };

            //Act
            List<string> actualValue = FileHandler.GetFileContentAsList("../../../files/tests.csv");

            //Assert
            Assert.Equal(expectedValue, actualValue);

        }
        
    }
}
