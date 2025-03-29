
namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public char[] Bracket;

        public BracketValidator()
        {
            Bracket = new char[12];
        }

        public bool ValidasiEkspresi(string expression)
        {
            char[] ekspresi = expression.ToCharArray();
            int index = -1;

            for (int i = 0, n = ekspresi.Length; i < n; i++)
            {
                if (ekspresi[i] == '(' || ekspresi[i] == '[' || ekspresi[i] == '{')
                {
                    Bracket[++index] = ekspresi[i];
                }
                else
                {
                    if (index < 0) return false;
                    char top = Bracket[index];
                    index--;

                    if (ekspresi[i] == ')' && top != '(' ||
                        ekspresi[i] == ']' && top != '[' ||
                        ekspresi[i] == '}' && top != '{')
                    {
                        return false;
                    }
                }
            }

            if (index < 0) return true;
            else return false;
        }
    }
}
