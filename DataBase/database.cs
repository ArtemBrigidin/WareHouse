using Tovar;
using System;

namespace DataBase
{
    public class DATABASE
    {
        static private int SizeList = 2;
        private TOVAR[] tovarList = new TOVAR[SizeList];

        private void ResizeList()
        {
            SizeList += 2;
            Array.Resize(ref tovarList, SizeList); // Увеличение размера массива
        }

        public void Add(TOVAR t)
        {
            if (t.id >= SizeList)
            {
                ResizeList();
            }
            tovarList[t.id] = t;
        }

        public void Select()
        {
            foreach (var list in tovarList)
            {
                if (list != null)
                {
                    Console.WriteLine($"Название товара : {list.name}");
                    Console.WriteLine($"\tID : {list.id}");
                    Console.WriteLine($"\tИнвентарный номер : {list.inv_num}");
                    Console.WriteLine($"\tЦена товара : {list.price}");
                    Console.WriteLine($"\tКоличество на складе : {list.count}");
                }
            }
        }
    }
}
