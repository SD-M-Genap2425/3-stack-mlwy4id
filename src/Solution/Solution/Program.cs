using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();

        Console.WriteLine(history.KunjungiHalaman("google.com"));  // google.com
        Console.WriteLine(history.KunjungiHalaman("example.com")); // example.com
        Console.WriteLine(history.KunjungiHalaman("github.com"));  // github.com

        Console.WriteLine(history.Kembali()); // example.com
        Console.WriteLine(history.Kembali()); // google.com
        Console.WriteLine(history.KunjungiHalaman("stackoverflow.com")); // stackoverflow.com

        Console.WriteLine(history.LihatHalamanSaatIni()); // stackoverflow.com

        history.TampilkanHistory();
        /* Output:
        google.com
        stackoverflow.com
        */

        // Bracket validator
        BracketValidator validator = new BracketValidator();

        Console.WriteLine(validator.ValidasiEkspresi("(){}[]"));      // true
        Console.WriteLine(validator.ValidasiEkspresi("({[]})"));      // true
        Console.WriteLine(validator.ValidasiEkspresi("(]"));          // false
        Console.WriteLine(validator.ValidasiEkspresi("({[})"));       // false
        Console.WriteLine(validator.ValidasiEkspresi("{{[[(())]]}}")); // true

        //Palindrome Checker
        var input = "A man, a plan, a canal: Panama";
        var result = PalindromeChecker.CekPalindrom(input);
        Console.WriteLine(result);
    }
}
