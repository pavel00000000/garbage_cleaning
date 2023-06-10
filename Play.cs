
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

////Задание 1
////Создайте класс Пьеса. Класс должен хранить такую информацию:
////• Название пьесы
////• ФИО автора
////• Жанр
////Год выпуска
////Реализуйте в классе методы и свойства, необходимые для
////функционирования класса.
////Добавьте в классе деструктор. Напишите код для тестирования
////функциональности класса.
////Напишите код для вызова деструктора.
///
namespace Pla_y
{
    class Play
    {

        public string Title_of_the_play { get; set; }
        public string FIO { get; set; }
        public string Genre { get; set; }
        public int Year_of_issue { get; set; }

        public Play(string name, string fio, string genre, int year_of_issue)
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

        ~Play()
        {
            Console.WriteLine($"очищен: {Title_of_the_play}\nочищен : {FIO}\nочищен: {Genre}\nочищен: {Year_of_issue}");
        }

    }
}