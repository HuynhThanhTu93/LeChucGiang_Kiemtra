using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeChucGiang_Kiemtra
{
    internal class SachGiaoKhoa : Sach
    {
        string monHoc;
        string tinhTrang;

        public string MonHoc { get => monHoc; set => monHoc = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public SachGiaoKhoa () :base() { }

        public SachGiaoKhoa(string tenSach, string tacGia, double giaBan, string monHoc, string tinhTrang):base(tenSach,tacGia,giaBan)
        {

            this.MonHoc = monHoc;
            this.TinhTrang = tinhTrang;
        }
    }
}
