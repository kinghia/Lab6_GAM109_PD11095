using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.B2
{
    public class shopLab6
    {
        public int id;
        public string city;
        public string name;

        public shopLab6(int id, string city, string name)
        {
            this.id = id;
            this.city = city;
            this.name = name;
        } 
    }
    public class phoneLab6
    {
        public int id;
        public int shop_id;
        public string name;
        public int price;
        public string des;
        
        public phoneLab6(int id, int shop_id, string name, int price, string des)
        {
            this.id = id;
            this.shop_id = shop_id;
            this.name = name;
            this.price = price;
            this.des = des;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<shopLab6> listShop = new List<shopLab6>();
            listShop.Add(new shopLab6(1, "HCM    ", "Quận 12         "));
            listShop.Add(new shopLab6(2, "Hà Nội ", "Quận Nam từ liên"));
            listShop.Add(new shopLab6(3, "Đà Nẵng", "Quận Thanh Khê  "));

            List<phoneLab6> listPhone = new List<phoneLab6>();
            listPhone.Add(new phoneLab6(1, 1, "IP 12", 100, "Độc lạ Bình Dương"));
            listPhone.Add(new phoneLab6(2, 2, "IP 13", 1000, "Độc lạ Bình Dương"));
            listPhone.Add(new phoneLab6(3, 3, "IP 14", 10000, "Độc lạ Bình Dương"));
            listPhone.Add(new phoneLab6(4, 1, "IP 15", 100000, "Độc lạ Bình Dương"));

            /*a/ Sử dụng Join Query viết chương trình để được kết quả xuất ra màn hình 
             gồm: ShopName và PhoneName*/
            var query = listShop.Join(listPhone, num1 => num1.id, num2 => num2.id, 
                (item1, item2) => new
            {
                item1 = item1.name,
                item2 = item2.name,
            });
            foreach ( var result in query)
            {
                Console.WriteLine("ShopName: " + result.item1 + " | PhoneName: " + result.item2);
            }
            /*b/ Sử dụng Group Join viết chương trình để được kết quả xuất ra màn hình như sau:*/
            var resultb = listShop.GroupJoin(listPhone, shop => shop.id, phone => phone.shop_id,
                (shop, phones) => new
                {
                    
                });
            foreach ( var item in resultb)
            {
                Console.WriteLine("ShopName: shopname");
                Console.WriteLine("-------------------");
                Console.WriteLine("phoneName: phonename");
                Console.WriteLine("phonePrice: phoneprice");
                Console.WriteLine("-------------------");
                Console.WriteLine("ShopName: shopname1");
                Console.WriteLine("-------------------");
                Console.WriteLine("phoneName: phonename");
                Console.WriteLine("phonePrice: phoneprice");
                Console.WriteLine("phoneName: phonename1");
                Console.WriteLine("phonePrice: phoneprice1");
                Console.WriteLine("-------------------");
            }

        }
    }
}
