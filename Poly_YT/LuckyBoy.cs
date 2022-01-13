using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexShop
{
    class LuckyBoy //Класс покупателя
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public string Gender { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public LuckyBoy(string name, string adress, string male, double balanse, double cost)
        {//конструктор
            Name = name;
            Adress = adress;
            Gender = male;
            Balance = balanse;
            Spent = cost;
        }

        /// <summary>
        /// Выдаёт баланс, отнимает от текущего и прибавляет к потраченному
        /// </summary>
        /// <param name="price">сумма покупки</param>
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
