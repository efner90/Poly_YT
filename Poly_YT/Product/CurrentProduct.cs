using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    class Dolls : Product //новый класс кукол унаследованный от класса продуктов
    {
        public string Material { get; private set; } //новое поле метериала

        public Dolls(string name, double price, string company, string matrial) //конструктор
        {
            Name = name; //инициализируем поля
            Company = company;
            Price = price;
            Material = matrial;
        }

        public override string ToString() //перезаписываем метод тусринг на слово
        {
            return "Куклы";
        }

        public override void ProductInfo() //к родительскому методу добавляем инфу,
        {                   //характерную только для дочернего
            base.ProductInfo();
            Console.WriteLine("Материал: " + Material);
            Console.WriteLine(new String('-',25));
        }
    }

    class Aphrodisiacs : Product
    {
        public string Composition { get; set; } //состав

        public Aphrodisiacs (string name, int price, string company, string composition)
        {
            Name=name;
            Price = price;
            Company = company;
            Composition = composition;
        }

        public override double GetDiscountPrice(LuckyBoy user) //скидка только для класса наследника
        {//ключевым словом оверрайд мы переопределяем родитеский метод наследуемому классу
            return Price / 2;
        }

        public override string ToString()
        {
            return "Афродизиаки";
        }

        public override void ProductInfo()
        {
            base.ProductInfo();
            Console.WriteLine("Состав: " + Composition);
            Console.WriteLine(new String('-', 25));
        }
    }

    class Condoms : Product
    {
        public int Size { get; set; }

        public Condoms(string name, int price, string company, int size)
        {
            Name=name;
            Company = company;
            Price = price;
            Size = size;

        }

        public override string ToString()
        {
            return "Кондомы";
        }

        public override void ProductInfo()
        {
            base.ProductInfo();
            Console.WriteLine("Размер: " + Size);
            Console.WriteLine(new String('-', 25));
        }
    }
}
