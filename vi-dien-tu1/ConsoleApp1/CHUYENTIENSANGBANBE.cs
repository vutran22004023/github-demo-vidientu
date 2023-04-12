using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CHUYENTIENSANGBANBE : CHUYEN_TIEN
    {
        private string banbe;

        public string Banbe { get => this.banbe; set => this.banbe = value; }

        public CHUYENTIENSANGBANBE() : base() { }

        public CHUYENTIENSANGBANBE(string banbe,string nganhang,int stk,string ten, float sotien,string loinhan)
                                   : base(nganhang,stk,ten,sotien,loinhan) 
        {
            this.banbe = banbe;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap ten ban be: ");
            this.banbe = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Ban be" + this.banbe);
        }
    }
}
