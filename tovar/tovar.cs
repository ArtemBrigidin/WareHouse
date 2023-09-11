namespace Tovar
{
    public class TOVAR
    {
        public static int st_id = 1;
        public int id = st_id;
        public int inv_num = 0;
        public string name = "car";
        public int price = 0;
        public int count = 5;

        public TOVAR(int _inv_num, string _name, int _price, int _count)
        {
            st_id++;
            if (_inv_num < 100000)
                Console.WriteLine("Инвентарный номер меньше 100000");
            if (_inv_num > 999999)
                Console.WriteLine("Инвентарный номер больше 999999");

            inv_num = _inv_num;
            name = _name;
            price = _price;
            count = _count;
        }
    }
}