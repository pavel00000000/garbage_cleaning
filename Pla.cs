using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pla
{
    using System;

    class Play_2 : IDisposable
    {
        private bool disposed = false;

        public string Title_of_the_play { get; set; }
        public string FIO { get; set; }
        public string Genre { get; set; }
        public int Year_of_issue { get; set; }

        public Play_2(string name, string fio, string genre, int year_of_issue)
        {
            Title_of_the_play = name;
            FIO = fio;
            Genre = genre;
            Year_of_issue = year_of_issue;
        }

        public string GetInfo()
        {
            return $"Название пьесы: {Title_of_the_play}\nФИО автора: {FIO}\nЖанр: {Genre}\nГод выпуска: {Year_of_issue}";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"очищен: {Title_of_the_play}\nочищен : {FIO}\nочищен: {Genre}\nочищен: {Year_of_issue}");
                }

                

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Play_2()
        {
            Dispose(false);
        }
    }

}
