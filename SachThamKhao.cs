using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Kiemtra
{
    internal class SachThamKhao : Sach
    {
        string linhVuc;
        string nhaXuatBan;

        public string LinhVuc { get => linhVuc; set => linhVuc = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }

        public SachThamKhao():base() { }

        public SachThamKhao (string tenSach, string tacGia, double giaBan, string linhVuc, string nhaXuatBan):base(tenSach,tacGia,giaBan)
        {

            this.LinhVuc = linhVuc;
            this.NhaXuatBan = nhaXuatBan;
        }
    }
}
