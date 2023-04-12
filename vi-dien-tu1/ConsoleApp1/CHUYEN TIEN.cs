using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     abstract class CHUYEN_TIEN
    {
        protected string nganhang;
        protected int stk;
        protected string ten;
        protected float sotien;
        protected string loinhan;
        protected float khoandu = 500000;

        protected string Nganhang { get => this.nganhang; set => this.nganhang = value; }
        protected int Stk { get => this.stk; set => this.stk = value; }
        protected string Ten { get => this.ten; set => this.ten = value; }
        protected float Sotien { get => this.sotien; set => this.sotien = value; }
        protected string Loinhan { get => this.loinhan; set => this.loinhan = value; }

        public CHUYEN_TIEN() { }

        public CHUYEN_TIEN(string nganhang, int stk, string ten, float sotien, string loinhan)
        {
            this.Nganhang = nganhang;
            this.Stk = stk;
            this.Ten = ten;
            this.Sotien = sotien;
            this.Loinhan = loinhan;
        }
        public virtual void nhap ()
        {
            Console.WriteLine("Nhap ngan hang: ");
            this.nganhang = Console.ReadLine();
            Console.WriteLine("Nhap so tai khoan");
            this.stk = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap so tien");
            this.sotien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap loi nhan: ");
            this.loinhan = Console.ReadLine();
        }
        public virtual void Xuat ()
        {
            Console.WriteLine("Ngan hang" + this.nganhang);
            Console.WriteLine("so tai khoan" + this.stk);
            Console.WriteLine("Ten chu tai khoan" + this.ten);
            Console.WriteLine("So tien" + this.sotien);
            Console.WriteLine("Loi nhan" + this.loinhan);
        }

    }
}
