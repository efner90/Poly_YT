using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    class Product : IForProduct //класс продуктов
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

        /// <summary>
        /// Цена товара со скидкой
        /// </summary>
        /// <param name="user">Клиент</param>
        /// <returns>Размер скидки</returns>
        public virtual double GetDiscountPrice(LuckyBoy user) //витруал говорит о том, что 
        {                           //в дочерних классах этот метод может быть переопределён
            if (user.Spent < 300)
            {
                return Price * 0.9;
            }

            if (user.Spent > 1000)
            {
                return Price * 0.8;
            }

            if (user.Spent >= 5000)
            {
                return Price * 0.6;
            }

            return Price;
        }

        /// <summary>
        /// Выводит инормацию о товаре\классе
        /// </summary>
        public virtual void ProductInfo()
        {
            Console.WriteLine(ToString()+":");
            Console.WriteLine("Название : " + Name);
            Console.WriteLine("Цена : " + Price);
            Console.WriteLine("Производитель : " + Company);
            
        }
    }

    interface IForProduct //интерфейс, полям которого должен соответствовать класс
    {
        public string Name { get;}
        public double Price { get;}
        public string Company { get;}

        double GetDiscountPrice(LuckyBoy user);
        void ProductInfo();
    }

    
}
