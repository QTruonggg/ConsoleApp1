using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2203E_CSharp.house.cm
{
    class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;

        public House()
        {
            soNha = "";
            diaChi = "";
            loaiNha = "";
        }

        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }
        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string LoaiNha
        {
            get { return loaiNha; }
            set { loaiNha = value; }
        }
        public void input()
        {
            Console.WriteLine("Nhập số nhà: ");
            soNha = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhập loại nhà: ");
            loaiNha = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Số nhà: " + soNha);
            Console.WriteLine("Địa chỉ: " + diaChi);
            Console.WriteLine("Loại nhà: " + loaiNha);
        }

    }
}
