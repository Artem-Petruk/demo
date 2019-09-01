using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
Задание 4 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Article, содержащий следующие закрытые поля: 
• название товара; 
• название магазина, в котором продается товар; 
• стоимость товара в гривнах. 
Создать класс Store, содержащий закрытый массив элементов типа Article.  
Обеспечить следующие возможности: 
• вывод информации о товаре по номеру с помощью индекса; 
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
Написать программу, вывода на экран информацию о товаре. 
*/

    class Article
    {
        private string productName, shop;
        private double cost;

        public string ProductName { get => productName; set { if (value is string) productName = value; } }
        public string Shop { get => shop; set { if (value is string) shop = value; } }
        public double Cost { get => cost; set { if (value is double) cost = value; } }
    }

    class Store
    {
        public Article instArticle = new Article();
        private Article[] articles;

        public Store()
        {
            articles = new Article[10];
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
            }
        }

        public Article this[string name]
        {
            get
            {

                Article article = null;
                foreach (var item in articles)
                {
                    if(item != null)
                    {
                        if (item.ProductName.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                        {
                            article = item;
                            break;
                        }
                    }
                }
                return article;
            }
            set
            {
                Article article = null;
                foreach (var item in articles)
                {
                    if (item?.ProductName == name)
                    {
                        article = item;
                        break;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==> Enjoy with Indexers! <==");

            Store store = new Store();
            store[0] = new Article { ProductName = "IPhone 8", Shop = "Apple Store", Cost = 686 };
            store[1] = new Article { ProductName = "IPhone X", Shop = "Apple Store", Cost = 820 };
            store[2] = new Article { ProductName = "IPhone XS", Shop = "Citrus", Cost = 900 };

            Console.Write("Please, enter number way how do you want to find interesting article (1 - by index, 2 - by name): ");
            int way = int.Parse(Console.ReadLine());

            switch (way)
            {
                case 1:
                    Console.Write("Please, enter the index of interesting article: ");
                    int index = int.Parse(Console.ReadLine());

                    if (store[index] != null)
                    {
                        Console.WriteLine($"\nArticle in index {index}. Shop: {store[index].Shop}; Product: {store[index].ProductName}; " +
                            $"Cost: {store[index].Cost}");
                    }
                    else
                    {
                        Console.WriteLine("Such index doesn't exist!");
                    }
                    break;
                case 2:
                    Console.Write("\nPlease, enter the name of interesting article: ");
                    string name = Console.ReadLine().ToUpper();
                    if (store[name] != null)
                    {
                        Console.WriteLine($"\nArticle with name ''{name}''. Shop: {store[name].Shop}; " +
                            $"Product: {store[name].ProductName}; Cost: {store[name].Cost}");
                    }
                    else
                    {
                        Console.WriteLine("Such name doesn't exist!");
                    }
                    break;
                default:
                    Console.WriteLine("The work of the program is complited!");
                    break;
            }
            Console.Write("Press any key to close program...");
            Console.ReadKey();
        }
    }
}