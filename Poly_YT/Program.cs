namespace SexShop
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            LuckyBoy user1 = new LuckyBoy( //создаём новый объект класса c помощью конструктора
                "Atrem",
                "Barnaulskaya",
                "Male",
                10000,
                1000);           

            var aGuseDoll = new Dolls( //сздаём товар
                "Гусь",
                200,
                "GuseNCo",
                "Rezin");            

            var DitryJoe = new Condoms(
                 "Ditry Joe",
                 500,
                 "Durex",
                 10);           

            var HorsesAphro = new Aphrodisiacs(
                "Horses power",
                500,
                "Uncle Vasya Farm's",
                "Horse fart");

            var FriendAphro = new Aphrodisiacs(
                "Завали подружку",
                250,
                "Подворотня",
                "Клофелин");            

            Product[] products = new Product[] { //апкаст, продукты, но вызываем наследуемые
                aGuseDoll,
                DitryJoe,
                HorsesAphro,
                FriendAphro};

            Console.WriteLine("Список товаров:");

            foreach (var tovar in products) //пробегаем по списку товаров методом инфы
            {
                tovar.ProductInfo();
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user1.Name}, ваш абалнс равен {user1.Balance}");
                Console.WriteLine("Чтобы выйти нажмите \"\"");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter: ");

                
                string str = Console.ReadLine();
                int productNumber = Int32.Parse(str);
                
                
                

                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user1.Balance)
                    {
                        informer.Buy(user1, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }               

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }

            }

        }
    }

    

}