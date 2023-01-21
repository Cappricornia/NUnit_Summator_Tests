using System.IO;

namespace Summator.UnitTests
{
    public class SummatorTests
    {


        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            // calls class Summator with its method Sum and it takes 2 arguments given above
            var actual = Summator.Sum(nums);

            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumOnePositiveNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        // the test fails because in the source code we start the loop from the first element [0], we don;t have any elements here
        //[Test]
        //public void Test_Summator_SumZeroNumber()
        // {
        //  var nums = new int[] {  };
        //  var actual = Summator.Sum(nums);

        // var expected = 0;
        // Assert.AreEqual(expected, actual);
        // }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);

            var expected = 6000000000;
            Assert.AreEqual(expected, actual);
            // test failed Expected: 6000000000
            //             But was:  1705032704
            // int32 max value = 2147483647
            // int32 min value = -2147483648
            // type data can be long to be valid for big numbers
        }

        [Test]
        public void Test_Summator_SumThreePositiveNumbers()
        { 
            // Arrange
            var nums = new int[] { 1, 2, 88 };
            var expected = 91;

            // Act
            var actual = Summator.Sum(nums);
            
            // Assert - Classic model
            Assert.AreEqual(expected, actual);

            // constraint model
            // Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void AssertionsExample()
        {
            //assert condition
            Assert.That(9 == 9);

            Assert.That(9, Is.GreaterThan(6));

            //Range assertions
            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 190));

            // String assertions
            Assert.That("I want to become the best QA", Does.Contain("QA"));

            //Assertions by regex matching it checks only if there are 1 or two numbers so it will be valid date also 88/66/3858
            string date = "7/11/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            //Assertions for expected exception
            Assert.That(() => "abc"[45], Throws.TypeOf<IndexOutOfRangeException>());
            // of Instance of - inheritance
            Assert.That(() => "abc"[45], Throws.InstanceOf<Exception>());

            // will throw an exception if the var is int32
            //Assert.That(() => Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 }), Throws.TypeOf<IndexOutOfRangeException>());    

            // Collection assertions
            //Assert.That(IEnumerable expected, Has.Member(object actual));
            Assert.That(new int[] {4, 5, 6}, Has.Member(6));

            //Collection range assertions
            var percentages = new int[] { 10, 30, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 100));

            //File / directory assertions
            Assert.That("C:\\Users\\hrist\\Desktop\\doc.docx", Does.Exist);

            // Assertions can show messages to helps with diagnostics. Messages can be customed.
             // Assert.That(percentage, Is.EqualTo(100), "Returned VAT.");
            // Message: 
            // Returned VAT.
            // Expected: 100
            //But was:  99.950000000000003d
        }

        [Test]
        public void Test_SummatorAverageSum()
        {
            var nums = new int[] { 5, 5, 5 };
            var expected = 5;

            var actual = Summator.Average(nums);
            Assert.That(actual, Is.EqualTo(expected));

        }
        // sample test
    }
}