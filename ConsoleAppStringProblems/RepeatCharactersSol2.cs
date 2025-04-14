using System.Text;

namespace ConsoleAppProblems
{
    public class RepeatCharactersSol2
    {
        public void Code()
        {
            //Problem
            //Input: ab3c0d10
            //Output: abababdddddddddd

            //string s = "ab3c0d10";
            string s = "ab3c500d5";
            StringBuilder r = new StringBuilder(); ;

            StringBuilder a = new StringBuilder();
            int c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var resp = CheckForDigits(s, i);
                c = resp.Item1;
                i = resp.Item2;
                if (c > 0)
                {
                    Console.WriteLine(c);
                    for (int j = 1; j <= c; j++)
                    {
                        r.Append(a);
                    }
                    a.Clear();
                }
                else if (c == 0)
                {
                    a.Clear();
                }
                else
                {
                    a.Append(s[i]);
                }
            }
            Console.WriteLine(r);

            (int, int) CheckForDigits(string s, int i)
            {
                int d = 0;
                bool stop = false;
                int index = i;
                bool isDigit = false;

                while (!stop && index < s.Length)
                {
                    if (char.IsDigit(s[index]))
                    {
                        d = d * 10 + (s[index] - '0');
                        index++;
                        isDigit = true;
                    }
                    else
                    {
                        stop = true;
                        //if (isDigit && d == 0) index--;
                    }
                }
                if (d == 0) return (-1, index);

                return (d, index);
            }
        }
    }
}
