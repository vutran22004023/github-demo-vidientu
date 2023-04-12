using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DANHSACH
    {
        Dictionary<String, CHUYENTIEN> listStaff;
        public DANHSACH()
        {
            this.listStaff = new Dictionary<string, CHUYENTIEN>();
        }

        public void Nhap()
        {
            char c = 'y';
            while (c == 'y')
            {
                CHUYENTIEN ct = null;
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (C) Chuyen khoan (B) chuyen khoan den ban be");
                switch (loai)
                {
                    case 'C':
                        {
                            ct = new CHUYENTIENDENNGANHANG();
                            ct.nhap();
                            break;
                        }
                    case 'B':
                        {
                            ct = new CHUYENTIENSANGBANBE();
                            ct.nhap();
                            break;
                        }
                }//END SWITCH
                if (ct != null)
                    this.listStaff.Add(ct.Ten, ct);
                    Console.WriteLine("Nha ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }
        }//end nhap
        public void lichsugd ()
        {
            Console.WriteLine("Nguoi nhan |  So tien | Gioi gian nhan");
            foreach (CHUYENTIEN ct in listStaff.Values)
                Console.WriteLine("{0,2} {1,10} {2,20}", ct.Ten, ct.Sotien, DateTime.Today);
        }//end lich su gd

    }
}
