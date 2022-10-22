using BT_NhanCong.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_NhanCong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CNhancong cNhancong = new CNhancong("nv01", "Timmo Nguyen", LoaiNhanCong.CoTayNgheCao, 15);
            System.Console.WriteLine(cNhancong.tiencong());

            Console.ReadKey();
        }
    }
}
