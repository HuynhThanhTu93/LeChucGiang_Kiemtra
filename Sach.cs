using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Kiemtra
{
    internal class Sach
    {
        string tenSach;
        string tacGia;
        double giaBan;

        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        public Sach () { }

        public Sach (string tenSach, string tacGia, double giaBan)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            GiaBan = giaBan;
        }
    }
}
