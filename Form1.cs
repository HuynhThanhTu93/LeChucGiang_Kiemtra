namespace LeChucGiang_Kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<SachGiaoKhoa> li_sgk = new List<SachGiaoKhoa>();
        private void btnThem1_Click(object sender, EventArgs e)
        {

            double giacuoicung= Convert.ToDouble(txtGiaban1.Text);

            if (cbxTinhtrang.Text == "Cũ")
            {
                giacuoicung = Convert.ToDouble(txtGiaban1.Text) * 0.8;
             
            }
            SachGiaoKhoa sgk = new SachGiaoKhoa(txtTensach1.Text, txtTacgia1.Text, giacuoicung, txtMonhoc.Text, cbxTinhtrang.Text);
           
            li_sgk.Add(sgk);
            li_sgk= li_sgk.OrderBy(s => s.GiaBan).ToList(); //Linq

            li_sgk= sapXep(li_sgk);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sgk;

           

        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            foreach (SachGiaoKhoa i in li_sgk)
            {
                if (txtTensach1.Text == i.TenSach)
                {
                    i.TacGia = txtTacgia1.Text;
                    i.GiaBan =double.Parse( txtGiaban1.Text);
                    i.MonHoc = txtMonhoc.Text;
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sgk;
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            foreach (SachGiaoKhoa i in li_sgk)
            {
                if (i.TenSach == txtTensach1.Text)
                {
                    li_sgk.Remove(i);
                    break;
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sgk;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTinhtrang.Items.Add("Mới");
            cbxTinhtrang.Items.Add("Cũ");
           

            cbxLinhvuc.Items.Add("Khoa học");
            cbxLinhvuc.Items.Add("Văn học");
            cbxLinhvuc.Items.Add("Kinh tế");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<SachThamKhao> li_stk = new List<SachThamKhao>();

        private void btnThem2_Click(object sender, EventArgs e)
        {
            SachGiaoKhoa stk = new SachGiaoKhoa(txtTensach2.Text, txtTacgia2.Text, double.Parse( txtGiaban2.Text), cbxLinhvuc.Text, txtXuatban.Text);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_stk;
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            foreach (SachThamKhao i in li_stk)
            {
                if (txtTensach2.Text == i.TenSach)
                {
                    i.TacGia = txtTacgia1.Text;
                    i.GiaBan =double.Parse( txtGiaban1.Text);
                    i.NhaXuatBan = txtXuatban.Text;

                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (SachThamKhao i in li_stk)
            {
                if (i.TenSach == txtTensach2.Text)
                {
                    li_stk.Remove(i);
                    break;
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = li_stk;
        }

        internal List<SachGiaoKhoa> sapXep(List<SachGiaoKhoa> li_sach)
        {
            for (int i = 0; i < li_sach.Count; i++) {

                for (int j = i+1; j < li_sach.Count; j++) {

                    if (li_sach[i].GiaBan > li_sach[j].GiaBan)
                    {
                        SachGiaoKhoa temp= li_sach[j];
                        li_sach[j] = li_sach[i];
                        li_sach[i] = temp;
                    }
                }
            }
            return li_sach;
        
        }


        
      
    }
}
