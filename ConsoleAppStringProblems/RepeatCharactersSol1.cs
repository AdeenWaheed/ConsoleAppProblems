namespace ConsoleAppApaleo
{
    public class RepeatCharactersSol1
    {
        public void Code()
        {
            //Problem
            //Input: ab3c0d10
            //Output: abababdddddddddd

            string s = "ab3c0d10";
            //string s = "ab3c500d5";
            string r = "";

            string a = "";
            int c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                c = CheckForDigits(s, ref i);
                if (c > 0)
                {
                    Console.WriteLine(c);
                    for (int j = 1; j <= c; j++)
                    {
                        r = r + a;
                    }
                    a = "";
                }
                else if (c == 0)
                {
                    a = string.Empty;
                }
                else
                {
                    a += s[i];
                }
            }
            Console.WriteLine(r);

            int CheckForDigits(string s, ref int i)
            {
                string d = string.Empty;
                bool stop = false;

                while (!stop && i < s.Length)
                {
                    if (char.IsDigit(s[i]))
                    {
                        d += s[i];
                        i++;
                    }
                    else
                    {
                        stop = true;
                        if (d.Length > 0) i--;
                    }
                }
                if (string.IsNullOrEmpty(d)) return -1;

                return Convert.ToInt32(d);
            }
        }
    }
}
