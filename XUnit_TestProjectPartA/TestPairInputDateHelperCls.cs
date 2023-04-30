using ProjectPartA.HelperClasses.PairInputDates;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnit_TestProjectPartA
{
    public class TestPairInputDateHelperCls
    {
        public class TestDataGeneratorUsingTheoryData : TheoryData<DateTime,List<int>>
        {
            public TestDataGeneratorUsingTheoryData()
            {
                Add(new DateTime(1992, 07, 18), new List<int> { 195, 196, 197, 198, 199 });
                Add(new DateTime(2021, 12, 25), new List<int> { 354, 355, 356, 357, 358 });
                Add(new DateTime(2021, 12, 31), new List<int> { 361, 362, 363, 364, 365 });
                Add(new DateTime(2022, 01, 04), new List<int> { 3, 4, 5, 6, 7 });
                Add(new DateTime(2022, 01, 01), new List<int> { 361, 362, 363, 364, 365 });
                Add(new DateTime(2005, 01, 01), new List<int> { 362, 363, 364, 365, 366 });
                Add(new DateTime(2022, 05, 01), new List<int> { 115, 116, 117, 118, 119 });
                Add(new DateTime(2024, 03, 01), new List<int> { 57, 58, 59, 60, 61 });
                Add(new DateTime(2022, 02, 28), new List<int> { 59, 60, 61, 62, 63 });
                Add(new DateTime(2022, 01, 02), new List<int> { 361, 362, 363, 364, 365 });
                Add(new DateTime(2025, 01, 03), new List<int> { 365, 366, 1, 2, 3 });
                Add(new DateTime(2025, 01, 05), new List<int> { 365, 366, 1, 2, 3 });
                Add(new DateTime(2021, 01, 02), new List<int> { 363, 364, 365, 366, 1 });
            }
        }

        [Theory]
        [ClassData(typeof(TestDataGeneratorUsingTheoryData))]
        public void Find_Calendar_Week_Test_Valid(DateTime date, List<int> expected)
        {
            //--Act
            var actual = PairInputDateHelperCls.MatchInputDateTime(date);

            //--Assert
            Assert.Equal(expected, actual);
        }
    }
}
