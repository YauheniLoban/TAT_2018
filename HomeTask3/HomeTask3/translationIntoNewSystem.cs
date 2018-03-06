using System;
using System.Text;

namespace DevTask3
{
    /// <summary> 
    /// translationIntoNewSystem
    /// creates a string that is a translation of a number into another number system
    /// </summary>
    public class translationIntoNewSystem
    {
        private long numberForConversion;
        private long foundationOfNewSystem;

        public translationIntoNewSystem(string[] valuesNumberAndBaseOfSystem)
        {
            numberForConversion = Convert.ToInt64(valuesNumberAndBaseOfSystem[0]);
            foundationOfNewSystem = Convert.ToInt64(valuesNumberAndBaseOfSystem[1]);
        }

        /// <summary> 
        /// Method CreateSubstringOfEvenElements
        /// A method that creates a string that is a representation of a number in the new number system
        /// </summary> 
        /// <returns>Value In New System</returns>
        public string CreatingRepresentationOfNumberInNewSystem()
        {
            StringBuilder valueInNewSystem = new StringBuilder();
            long nextNumberToAdd;
            do
            {
                nextNumberToAdd = numberForConversion % foundationOfNewSystem;
                valueInNewSystem.Append(ConvertingFigureToRepresentationInAnotherSystem(nextNumberToAdd));
                numberForConversion = numberForConversion / foundationOfNewSystem;
            } while (0 != numberForConversion);
            string ConvertedString;
            ConvertedString = valueInNewSystem.ToString();

            return reverseString(ConvertedString);
        }
        /// <summary> 
        /// ConvertingFigureToRepresentationInAnotherSystem
        /// Function for converting numbers to a new number system
        /// </summary> 
        /// <param name="digitForTranslation">number to convert to a new system</param> 
        /// <returns>Figure In New System</returns>
        private string ConvertingFigureToRepresentationInAnotherSystem (long digitForTranslation)
        {
            char figureInNewSystem;
            int index;
            index = Convert.ToInt16(digitForTranslation);
            var possibleValuesOfElementsInNewView = "0123456789ABCDEFGHIJ";
            figureInNewSystem = possibleValuesOfElementsInNewView[index];
            return Convert.ToString(figureInNewSystem);
        }
        /// <summary> 
        /// reverseString
        /// Function to create a string of characters in which go in reverse order
        /// </summary> 
        /// <param name="stringToReverse">The string you need to revers</param> 
        /// <returns>Reversed String</returns>
        private string reverseString(string stringToReverse)
           {
                char[] reversedString = stringToReverse.ToCharArray();
                Array.Reverse(reversedString);
                return new string(reversedString);
            }
    }
}



