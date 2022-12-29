using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bt2
{
    internal class KhachHangNN : KhachHang
    {
        public string quocTich;
        public KhachHangNN(int Code, string FullName, string Date, int Quantity, string quocTich) : base(Code, FullName, Date, Quantity)
        {
            this.quocTich = quocTich;
        }
        public int ThanhTien()
        {
            return quantity * 2000;
        }
    }
}
