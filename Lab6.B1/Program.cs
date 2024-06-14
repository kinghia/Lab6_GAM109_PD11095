using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9, 280, 420 };
            /*a/ Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt*/
            var firstEvenGreaterThan5 = listInt.FirstOrDefault(list => list > 5 && list % 2 == 0);
            Console.WriteLine("Số chẵn đầu tiên và lớn hơn 5 là: " + firstEvenGreaterThan5);
            /*b/ Tìm phần tử cuối cùng trong listInt có giá trị > 200*/
            var lastGreaterThan200 = listInt.LastOrDefault(list => list > 200);
            Console.WriteLine("\nPhần tử cuối cùng có giá trị lớn hơn 200 là: " + lastGreaterThan200);

            List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
            /*c/ Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”*/
            var firstTextT = listStr.FirstOrDefault(list => list !=null && list.StartsWith("T"));
            Console.WriteLine("\nPhần tử đầu tiên có giá trị bắt đầu bằng ký tự 'T' là: " + firstTextT);
            /*d/ Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt*/
            int sumIndexle = listInt.Where((value, index) => index % 2 != 0 && value % 2 == 0).Sum();
            Console.WriteLine("\nTổng các trị tại vị trí index lẻ và số đó chia hết cho 2 là: " + sumIndexle);
            List<string> listNull = new List<string>();
        }
    }
}
