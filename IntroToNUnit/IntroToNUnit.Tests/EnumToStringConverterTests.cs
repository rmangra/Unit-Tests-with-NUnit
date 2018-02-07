using NUnit.Framework;

namespace IntroToNUnit.Tests
{
    public enum TestTypes
    {
        None,
        UnitTesting,
        IntegrationTesting,
        SmokeTesting,
        RegressionTesting,
        PrayItWorksTesting
    }

    [TestFixture]
    public class EnumToStringConverterTests
    {
        [Test]
        public void CanConvertEnumIntoMultipleWords()
        {
        }
    }

}
