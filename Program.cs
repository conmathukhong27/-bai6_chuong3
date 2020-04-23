using System;

namespace bai6_chuong3
{
    class Program
    {
        static void Main(string[] args)
        {
            danhsachsinhvien htttak21 = new danhsachsinhvien();
            htttak21.Nhap();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            htttak21.xuatsvtren8();
            Console.ReadLine();
        }
    }
}
