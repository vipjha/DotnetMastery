namespace Basic
{
    public class StringReverse
    {
        public void StringReverseMethod(string input)
        {
            //string input = "This is my input";
            string reverseString = "";
            for(int i = input.Length - 1; i >= 0; i--)
            {
                reverseString += input[i];
            }
            Console.WriteLine(reverseString);
        }

        public Dictionary<char, int> CountStringsCharacters(string intput)
        {
            Dictionary<char, int> countChar = new Dictionary<char, int>();
            foreach(char c in intput)
            {
                if(countChar.ContainsKey(c))
                {
                    countChar[c]++;
                }
                else
                {
                    countChar[c] = 1;
                }
            }
            return countChar;
        }
    }
}