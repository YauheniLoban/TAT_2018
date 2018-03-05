using System.Text;

namespace DevTask2
{
    /// <summary> 
    /// SubstringOfCharactersWithEvenIndices
    /// Сreates a substring of elements with even indices to the console
    /// </summary> 
    class SubstringOfEvenElements
    {
        /// <summary> 
        /// Method CreateSubstringOfEvenElements
        /// Function to create a string consisting of even elements of the transmitted string
        /// </summary> 
        /// <param name="stringForSelectingSubstring">The string from which you need to select a substring consisting of even elements</param> 
        /// <returns>Created substring</returns>
        public string CreateSubstringOfEvenElements(string stringForSelectingSubstring)
        {
            StringBuilder allocatedSubstring = new StringBuilder();

            for (int i = 0; i < stringForSelectingSubstring.Length; i += 2)
            {
                allocatedSubstring.Append(stringForSelectingSubstring[i]); 
            }

            return allocatedSubstring.ToString();
        }
    }
}

