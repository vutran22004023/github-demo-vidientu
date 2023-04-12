using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class CHUYENTIENDENNGANHANG:CHUYENTIEN
    {
        private string nganhang;

        public string Nganhang { get => this.nganhang; set => this.nganhang = value; }

        public CHUYENTIENDENNGANHANG() : base()
        {

        }

        public CHUYENTIENDENNGANHANG(string nganhang, int stk, string ten, float sotien, string loinhan)
                               :base (stk,ten,sotien,loinhan)
        {
            this.nganhang = nganhang;
        }

        public override void nhap()
        {
            Console.Write("Nhap ngan hang: ");
            this.nganhang = Console.ReadLine();
            base.nhap();
        }

        public override void Xuat()
        {
            Console.Write("Ngan hang" + this.nganhang);
            base.Xuat();

        }
    }
}
