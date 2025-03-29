
using System.Text;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL;
        public Halaman Next;
        public Halaman Prev;

        public Halaman(string url)
        {
            URL = url;
            Next = null;
            Prev = null;
        }
    }

    public class HistoryManager
    {
        public Halaman Head;
        public Halaman Tail;

        public HistoryManager()
        {
            Head = null;
            Tail = null;
        }

        public string KunjungiHalaman(string url)
        {
            Halaman newHalaman = new Halaman(url);

            if(Head == null && Tail == null)
            {
                Head = newHalaman;
                Tail = newHalaman;
            } else
            {
                Tail.Next = newHalaman;
                newHalaman.Prev = Tail;
                Tail = Tail.Next;
            }

            return Tail.URL;
        }

        public string Kembali()
        {
            if (Tail.Prev != null)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                return Tail.URL;
            }

            return "Tidak ada halaman sebelumnya.";
        }

        public string LihatHalamanSaatIni()
        {
            return Tail.URL;
        }

        public void TampilkanHistory()
        {
            Halaman curr = Head;

            while(curr != null)
            {
                Console.WriteLine(curr.URL);
                curr = curr.Next;
            }
        }
    }
}
