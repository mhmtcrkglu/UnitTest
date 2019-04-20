using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Clear_Begin_End_Spaces()
        {
            //Arrange
            var input = "        Happy  New Year    ";
            var waitingResult = "Happy New Year";

            //Act
            var comingResult = StringHelper.ClearSpaces(input);

            //Assert
            Assert.AreEqual(waitingResult, comingResult);

        }

        [TestMethod]
        public void Clear_Relative_Space()
        {
            //Arrange
            var input = "We          have    to  go        there.";
            var waitingResult = "We have to go there.";

            //Act
            var comingResult = StringHelper.ClearSpaces(input);

            //Assert
            Assert.AreEqual(waitingResult, comingResult);
        }

    }
}
