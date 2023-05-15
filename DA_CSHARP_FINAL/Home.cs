using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CSHARP_FINAL
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        // Tạo đối tượng form con
        private Form currentFormChild;

        // Hàm gọi form con lên from cha
        private void openFormChid(Form childForm)
        {   
            if(currentFormChild != null) {
                currentFormChild.Close();
            }

            currentFormChild= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pn_body.Controls.Add(childForm);
            pn_body.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormChid(new frm_gioHang());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormChid(new frm_nhanVien());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFormChid(new frm_quanLyTraiCay());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frm_home_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
