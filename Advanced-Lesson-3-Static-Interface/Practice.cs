using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing.Imagine;

namespace Advanced_Lesson_3_Static_Interface
{

    public partial class Practice
    {
        public class PracticeId
        {
            private static int _id;
            public string Name;

            public static int Id
            {
                get
                {
                    return _id;
                }
            }
            static PracticeId()
            {
                _id = 1000;
            }

            public PracticeId()
            {
                _id++;
            }
        }
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
            for (int i = 0; i < 100; i++)
            {
                PracticeId a = new PracticeId();
            }
            Console.WriteLine(PracticeId.Id);
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }

        public static void GuessType<T>(T item)
        {
            switch (item)
            {
                case string str:
                    Console.WriteLine($"string :  {str} ");
                    break;
                case int i:
                    Console.WriteLine($"int : {i} ");
                    break;
                case double d:
                    Console.WriteLine($"double : {d}");
                    break;
                case DateTime dateTime:
                    Console.WriteLine($"datetime :  {dateTime}");
                    break;
                default:
                    Console.WriteLine("Type is not valid");
                    break;
            }
        }

        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
            string text = "ssasvsdgvsa";
            GuessType(text);
            GuessType(5);
            GuessType(7.45);
            DateTime dateTime = DateTime.Now;
            GuessType(dateTime);
            PracticeId practice = null;
            GuessType(practice);
        }

    }    
}
