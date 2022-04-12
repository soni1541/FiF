using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FuF
{
    public partial class menu : Form
    {
        private int id_user;
        private int now_level;

        Database_Query dq;

        public menu(int id)
        {
            InitializeComponent();

            pictureBox_nut.Load("nut.png");

            id_user = id;

            dq = new Database_Query();

            update_menu();
        }

        public void update_menu()
        {
            string zam = "zamochek.png";
            picture_z2.Load(zam);
            picture_z3.Load(zam);
            picture_z4.Load(zam);
            picture_z5.Load(zam);
            picture_z6.Load(zam);
            picture_z7.Load(zam);

            now_level = dq.get_level(id_user);

            if (now_level > 1)
            {
                picture_z2.Hide();
            }
            if (now_level > 2)
            {
                picture_z3.Hide();
            }
            if (now_level > 3)
            {
                picture_z4.Hide();
            }
            if (now_level > 4)
            {
                picture_z5.Hide();
            }
            if (now_level > 5)
            {
                picture_z6.Hide();
            }
            if (now_level > 6)
            {
                picture_z7.Hide();
            }

            label_count_nuts.Text = "x" + dq.get_count_nuts(id_user).ToString();
        }

        public int get_id()
        {
            return id_user;
        }

        private void Xback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sver_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kn1_Click(object sender, EventArgs e)
        {
            level_1 l1 = new level_1(this);
            l1.Show();
            this.Hide();
        }

        private void kn2_Click(object sender, EventArgs e)
        {
            if(now_level > 1) 
            {
                level_2 l2 = new level_2(this);
                l2.Show();
                this.Hide();
            }
                  
        }

        private void kn3_Click(object sender, EventArgs e)
        {
            if (now_level > 2)
            {
                level_3 l3 = new level_3(this);
                l3.Show();
                this.Hide();
            }
        }

        private void kn4_Click(object sender, EventArgs e)
        {
            if (now_level > 3)
            {
                level_4 l4 = new level_4(this);
                l4.Show();
                this.Hide();
            }
        }

        private void kn5_Click(object sender, EventArgs e)
        {
            if (now_level > 4)
            {
                level_5 l5 = new level_5(this);
                l5.Show();
                this.Hide();
            }
        }

        private void kn6_Click(object sender, EventArgs e)
        {
            if (now_level > 5)
            {
                level_6 l6 = new level_6(this);
                l6.Show();
                this.Hide();
            }
        }

        private void kn7_Click(object sender, EventArgs e)
        {
            if (now_level > 6)
            {
                level_7 l7 = new level_7(this);
                l7.Show();
                this.Hide();
            }
        }
    }
}
