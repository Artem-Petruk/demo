using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    /*
    Дополнительное задание 
Задание 
Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. 
Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.
*/
    class Dictionary
    {
        private string[] key = new string[10];
        private string[] value = new string[10];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";
            key[1] = "ручка"; value[1] = "pen";
            key[2] = "солнце"; value[2] = "sun";
            key[3] = "яблоко"; value[3] = "apple";
            key[4] = "стол"; value[4] = "table";
            key[5] = "книга"; value[5] = "book";
            key[6] = "ручка"; value[6] = "pen";
            key[7] = "сонце"; value[7] = "sun";
            key[8] = "яблуко"; value[8] = "apple";
            key[9] = "стіл"; value[9] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || value[i] == index)
                        return key[i] + " - " + value[i];

                return $"{index} - нет перевода для этого слова.";
                    //string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return $"Попытка обращения за пределы массива. Индекс ''{index}'' неверный. Значения по индексу {index} не существует!";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(dictionary["сонце"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["підлога"]);
            Console.WriteLine(dictionary["краватка"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
