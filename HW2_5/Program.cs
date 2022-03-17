using System;

namespace HW2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            //    Например при вводе “25” в консоль будет выведено “двадцать пять”.

            int number = Convert.ToInt32(Console.ReadLine());
            string Numbers = "";

            if (number == 11)
            {
                Numbers += "Одинадцать";
            }

            if (number == 12)
            {
                Numbers += "Двенадцать";
            }

            if (number == 13)
            {
                Numbers += "Тринадцать";
            }
            if (number == 14)
            {
                Numbers += "Четырнадцать";
            }

            if (number == 15)
            {
                Numbers += "Пятнадцать";
            }

            if (number == 16)
            {
                Numbers += "Шестнадцать";
            }

            if (number == 17)
            {
                Numbers += "Семнадцать";
            }

            if (number == 18)
            {
                Numbers += "Восемнадцать";
            }
            if (number == 19)
            {
                Numbers += "Девятнадцать";
            }

            int decade = number / 10;
            int unit = number % 10;


            if (number >= 20)
            {
                switch (decade)
                {
                    case 2:
                        Numbers += "Двадцать";
                        break;
                    case 3:
                        Numbers += "Тридцать";
                        break;
                    case 4:
                        Numbers += "Сорок";
                        break;
                    case 5:
                        Numbers += "Пятьдесят";
                        break;
                    case 6:
                        Numbers += "Щестьдесят";
                        break;
                    case 7:
                        Numbers += "Семьдесят";
                        break;
                    case 8:
                        Numbers += "Восемьдесят";
                        break;
                    case 9:
                        Numbers += "Девяносто";
                        break;
                }

                switch (unit)
                {
                    case 1:
                        Numbers += " один";
                        break;
                    case 2:
                        Numbers += " два";
                        break;
                    case 3:
                        Numbers += " три";
                        break;
                    case 4:
                        Numbers += " четыре";
                        break;
                    case 5:
                        Numbers += " пять";
                        break;
                    case 6:
                        Numbers += " шесть";
                        break;
                    case 7:
                        Numbers += " семь";
                        break;
                    case 8:
                        Numbers += " восемь";
                        break;
                    case 9:
                        Numbers += " девять";
                        break;

                }
            }
            Console.WriteLine(Numbers);


        }
    }
}

