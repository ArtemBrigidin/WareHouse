using DataBase;
using Tovar;

namespace Program
{
    internal class warehouse
    {
        static void Main(string[] args)
        {
            DATABASE T;
            DATABASE DataBase = new DATABASE();
            int inv_num = 0;
            string name;
            int price = 0;
            int count = 0;
            string input;
            while (true)
            { 
            Console.WriteLine("Введите команду : ADD(Инвентарный номер,Название товара,Цена,Количество) или SELECT * >>");
            input = Console.ReadLine();
            if (input == "SELECT *")
            {
                DataBase.Select();
            }
            else
            {
                string[] add = input.Split('(', ')', ',');
                inv_num = Convert.ToInt32(add[1]);
                name = add[2];
                price = Convert.ToInt32(add[3]);
                count = Convert.ToInt32(add[4]);
                TOVAR t = new TOVAR(inv_num, name, price, count);
                DataBase.Add(t);
            }
            }
        }
    }
}