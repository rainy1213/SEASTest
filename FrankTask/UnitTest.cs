using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FrankTask
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase(6, 2, 3, ExpectedResult = "FizzBuzz")]
        [TestCase(6, 7, 3, ExpectedResult = "Buzz")]
        [TestCase(6, 2, 4, ExpectedResult = "Fizz")]
        [TestCase(6, 8, 4, ExpectedResult = "value:6,fizz:8,buzz:4")]
        public string FizzBuzzTest(int value, int fizz, int buzz)
        {
            string result = FrankTask.Task.FizzBuzz(value, fizz, buzz);

            return result;
        }

        [TestCase(1, 1, 1 , ExpectedResult = -0.9836)]
        [TestCase(1, 2, 3, ExpectedResult = -0.9017)]
        public decimal WhoPutsWaterInBoxesTest(decimal length, decimal width, decimal height)
        {
            decimal result = FrankTask.Task.WhoPutsWaterInBoxes(length, width, height);

            return result;
        }


    }
}
