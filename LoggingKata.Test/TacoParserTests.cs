using System;
using Xunit; 

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
         {
            // TODO: Complete Something, if anything

            //Arrange
            TacoParser parserInstance = new TacoParser(); // new instance of class that contains Parse method so we can access Parse
            var str = "34.280205,-86.217115,Taco Bell Albertvill...";

            //Act
            var actual = parserInstance.Parse(str);

            //Assert
            Assert.NotNull(actual);
        }

        [Theory] 
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", "Taco Bell Albertvill...")]
        public void ShouldParse(string str, string expected)
        {
            // TODO: Complete Should Parse

            //Arrange
            TacoParser parserInstance = new TacoParser();

            //Act
            var actual = parserInstance.Parse(str);

            //Assert
            Assert.Equal(expected, actual.Name);

        }
           
        [Theory]
        [InlineData("34280205,86.217115")]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse

            //Arrange
            TacoParser parserInstance = new TacoParser();

            //Act
            var actual = parserInstance.Parse(str);

            //Assert
            Assert.Null(actual);
            
        }
    }
}
