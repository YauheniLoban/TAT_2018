using System.Text;

namespace DevTask2
{
    /// <summary> 
    /// EntryPointObject
    /// Сreates a substring of elements with even indices to the console
    /// </summary> 
    class SubstringOfCharactersWithEvenIndices
    {
        /// <summary> 
        /// Method CreateSubstringOfEvenElements
        /// Function to create a string consisting of even elements of the transmitted string
        /// </summary> 
        /// <param name="stringForSelectingSubstring">String, which was inputed</param> 
        /// <returns>Created substring</returns>
        public string CreateSubstringOfEvenElements(string stringForSelectingSubstring)
        {
            StringBuilder allocatedSubstring = new StringBuilder();

            for (int i = 0; i < stringForSelectingSubstring.Length; i += 2)
            {
                allocatedSubstring.Append(stringForSelectingSubstring[i]); // Add an element to the selected row
            }

            return allocatedSubstring.ToString();
        }
    }
}

