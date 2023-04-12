using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CHUYENTIENSANGBANBE : CHUYENTIEN
    {
        private string banbe;
        private string nganhang;

        public string Banbe { get => this.banbe; set => this.banbe = value; }
        public string Nganhang { get => this.nganhang; set => this.nganhang = value; }

        public CHUYENTIENSANGBANBE() : base() { }

        public CHUYENTIENSANGBANBE(string banbe,string nganhang,int stk,string ten, float sotien,string loinhan)
                                   : base(stk,ten,sotien,loinhan) 
        {
            this.banbe = banbe;
        }

        public override void nhap()
        {
            Console.Write("Nhap ten ban be: ");
            this.banbe = Console.ReadLine();
            Console.Write("Nhap ngan hang: ");
            this.nganhang = Console.ReadLine();
            base.nhap();
        }

        public override void Xuat()
        {
            Console.Write("Ban be" + this.banbe);
            Console.Write("Ngan hang" + this.nganhang);
            base.Xuat();
            
        }
    }
}
