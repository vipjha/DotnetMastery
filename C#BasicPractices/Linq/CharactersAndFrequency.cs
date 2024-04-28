namespace Linq
{
    public class CharactersAndFrequency
    {
        public void CharactersAndFrequencyMethod()
        {
            string inputString;
            Console.Write("Input the string : ");
            inputString = Console.ReadLine();
            Console.Write("\n");
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach(var c in inputString) 
            {
                if(keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c]++;
                }
                else
                {
                    keyValuePairs[c] = 1;
                }
            }

            foreach(var charCount in keyValuePairs)
            {
                Console.WriteLine(charCount.Key + " : " + charCount.Value);    
            }

            var query = from x in inputString group x by x into y select y;

            foreach (var x in query) 
            {
                Console.WriteLine("Charcter " + x.Key + " : " + x.Count() + " times");
            }

        }
    }
}
