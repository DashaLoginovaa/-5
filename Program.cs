using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИП5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n1 = "";
            string n2 = "";
            string n3 = "";
            bool n4 = true;
            
            Console.WriteLine(Anketa(n1,n2, n3,n4));
            


            Console.ReadKey();
        }
        static (string UserName, string UserSurname, string Age) Anketa(string UserName, string UserSurname, string Age, bool UserPet)
        {
            Console.WriteLine("Введите имя:");
            UserName = Console.ReadLine();
            
            Console.WriteLine("Введите Фамилию:");
            UserSurname = Console.ReadLine();

            
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                Age = Console.ReadLine();
            } while (Check(Age, out intage));

            Console.WriteLine("Есть ли у Вас питомец? Напишите Да или Нет");
            string kol;
            int intkol;
            if (Console.ReadLine() == "Да") 
            { 
                UserPet = true;
            }
            else
            {
                UserPet = false;

            }

            if (UserPet == true)
            {
                do
                {
                Console.WriteLine("Сколько у Вас питомцев?");
                kol = Console.ReadLine();
                var ArrPet = NamesOfPets(kol);
                     
                } while (Check(kol, out intkol));
               
            }
            string col;
            int intcol;
            do
            {
                Console.WriteLine("Введите количество Ваших любимых цветов");
                col = Console.ReadLine();
                FavColors(col);
                

            } while (Check(col, out intcol));

            var Result = (Name : UserName, UserSurname :  UserSurname, UserAge : Age);
            return Result;


        }
        static string[] NamesOfPets(string count) 
        {
            int newcount = Convert.ToInt32(count);
            var ArrName = new string[newcount];
            
            for (int i = 0; i < newcount; i++)
            {
                ArrName[i] = Console.ReadLine();
            }

            return ArrName;

        }
        static string[] FavColors(string count)
        {
            int newcount = Convert.ToInt32(count);
            var ArrColor = new string[newcount];
            for (int i = 0; i < newcount; i++)
            {
                ArrColor[i] = Console.ReadLine();
            }

            return ArrColor;
        }

        static bool Check(string number, out int corrnomber) 
        {
            if (int.TryParse(number, out int intnum)) 
            {
                if (intnum > 0)
                {
                    corrnomber = intnum;
                    return false;
                }

            }
            corrnomber = 0;
            return true;
        }


        
    }
}
