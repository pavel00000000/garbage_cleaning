using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс Магазин. Класс должен хранить такую информацию:
//Название магазина
//• Адрес магазина
//• Тип магазина
//• Продовольственный
//• Хозяйственный
//• Одежда
//• Обувь

//Реализуйте
//B
//классе
//методы
//И
//свойства,
//необходимые
//для
//функционирования класса.
//Класс должен реализовывать интерфейс IDisposable. Напишите код для
//тестирования функциональности класса.
//Напишите код для вызова метода Diѕроѕе.

namespace Magazi_n
{
    public class Magazin : IDisposable
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public Tip Tip_magazin { get; set; }
        public bool disposed = false;

        public Magazin(string name, string adres, Tip magazinType)
        {
            Name = name;
            Adres = adres;
            Tip_magazin = magazinType;
        }

        public enum Tip
        {
            Продовольственный,
            Хозяйственный,
            Одежда,
            Обувь
        }
        public string GetInfo()
        {
            return $"Магазин: {Name}\nАдрес: {Adres}\nTип: {Tip_magazin}";
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"очищен: {Name}\nочищен : {Adres}\nочищен: {Tip_magazin}\n");

                }

                disposed = true;
            }
        }
        ~Magazin()
        {
            Dispose(false);
        }
    }
}
