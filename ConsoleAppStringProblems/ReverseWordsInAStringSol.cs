using System.Text;

namespace ConsoleAppStringProblems
{
    public class ReverseWordsInAStringSol
    {
        public void Code()
        {
            //Reverse words in a string
            //Given an input string s, reverse the order of the words.
            //Input: s = "the sky is blue"
            //Output: "blue is sky the"

            string s = "the sky is blue";
            Console.WriteLine($"Reversed string: {ReverseWords(s)}");
        }

        private string ReverseWords(string s)
        {
            var words = s.Split(' ');

            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] != "")
                    sb.Append($"{words[i]} ");
            }

            return sb.ToString().Trim();
        }
    }
}
