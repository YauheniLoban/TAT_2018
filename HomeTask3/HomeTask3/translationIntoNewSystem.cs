using System;
using System.Text;

namespace DevTask3
{
    /// <summary> 
    /// This class creates a string that is a translation of a number into another number system
    /// </summary>
    public class NumberInNewSystem
    {
        private int numberForConversion;
        private int foundationOfNewSystem;

        public NumberInNewSystem(int valueNumber, int valueBaseOfSystem)
        {
            numberForConversion = valueNumber;
            foundationOfNewSystem = valueBaseOfSystem;
        }

        /// <summary> 
        /// Method CreateSubstringOfEvenElements
        /// A method that creates a string that is a representation of a number in the new number system
        /// </summary> 
        /// <returns>Value In New System</returns>
        public string CreatingRepresentationOfNumberInNewSystem()
        {
            StringBuilder valueInNewSystem = new StringBuilder();
            int nextNumberToAdd;
            do
            {
                nextNumberToAdd = numberForConversion % foundationOfNewSystem;
                valueInNewSystem.Append(FigureConverter(nextNumberToAdd));
                numberForConversion = numberForConversion / foundationOfNewSystem;
            } while (0 != numberForConversion);
            string ConvertedString;
            ConvertedString = valueInNewSystem.ToString();

            return ReverseString(ConvertedString);
        }

        private string FigureConverter(int digitForTranslation)
        {
            char figureInNewSystem;
            string possibleValues = "0123456789ABCDEFGHIJ";
            figureInNewSystem = possibleValues[digitForTranslation];
            return Convert.ToString(figureInNewSystem);
        }

        private string ReverseString(string stringToReverse)
        {
            char[] reversedString = stringToReverse.ToCharArray();
            Array.Reverse(reversedString);
            return new string(reversedString);
        }
    }
}



