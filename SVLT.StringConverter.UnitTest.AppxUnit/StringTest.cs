using SVLT.Temperatura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVLT.StringConverter.UnitTest.AppxUnit
{
    public class StringTest
    {
        [Fact]
        public void Reverse_ShouldReturn()
        {
            StringManipulator stringMap = new StringManipulator();

            string word = "Pelicula";

            string result = stringMap.ReverseString(word);

            Assert.Equal("alucileP", result);
        }

        [Fact]
        public void Space_ShouldReturn()
        {
            StringManipulator stringWhite = new StringManipulator();

            string word = "Hay una nueva pelicula";

            string result = stringWhite.RemoveSpaces(word);

            Assert.Equal("Hayunanuevapelicula", result);
        }
    }
}
