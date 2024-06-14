using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int>() { 5, 6, 7, 8, 1};

            /*a) Sử dụng Union cho nguồn dữ liệu và xuẩt ra màn hình theo giá trị giảm dần*/
            var unionlist = list1.Union(list2).OrderByDescending(x => x).ToList();
            Console.WriteLine("Union theo giá trị giảm dần là: ");
            unionlist.ForEach(x => Console.WriteLine(x + " "));

            /*b) Sử dụng Intersect cho nguồn dữ liệu để xuất ra màn hình*/
            var intersectList = list1.Intersect(list2).ToList();
            Console.WriteLine("\nIntersect: ");
            intersectList.ForEach(x => Console.WriteLine(x + " "));

            /*c) Sử dụng Concat cho nguồn dữ liệu để xuất ra màn hình theo giá trị tăng dần*/
            var concacList = list1.Concat(list2).OrderBy(x => x).ToList();
            Console.WriteLine("\nConcat theo giá trị tăng dần là: ");
            foreach (var item in concacList)
            {
                Console.WriteLine(item + " ");
            }

            /*d) Sử dụng Except cho nguồn dữ liệu để xuất ra màn hình */
            var exceptList = list1.Except(list2).ToList();
            Console.WriteLine("\nExcept: ");
            exceptList.ForEach(x => Console.WriteLine(x + " "));
        }
    }
}
