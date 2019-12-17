using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace HangMan2
{
    public partial class Form1 : Form
    {
        string line;
        string stars;
        int count;
        string name = "";
        List<Panel> listpanels = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count = 10;
            label6.Text = "0";
            
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            button6.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button7.BackColor = Color.LightGray;
            button11.BackColor = Color.LightGray;
            button12.BackColor = Color.LightGray;
            button13.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
            button18.BackColor = Color.LightGray;
            button19.BackColor = Color.LightGray;
            button23.BackColor = Color.LightGray;
            button20.BackColor = Color.LightGray;
            button21.BackColor = Color.LightGray;
            button22.BackColor = Color.LightGray;
            button14.BackColor = Color.LightGray;
            button15.BackColor = Color.LightGray;
            button16.BackColor = Color.LightGray;
            button17.BackColor = Color.LightGray;
            button33.BackColor = Color.LightGray;
            button32.BackColor = Color.LightGray;
            button30.BackColor = Color.LightGray;
            button31.BackColor = Color.LightGray;
            button9.BackColor = Color.LightGray;
            button10.BackColor = Color.LightGray;
            textBox2.Text = "";
            var lines = File.ReadAllLines("Words.txt");
            var r = new Random();
            var randomLineNumber = r.Next(0, lines.Length - 1);
            line = lines[randomLineNumber];
            int length = line.Length;
            stars = "";
            for (int i = 0; i < length; i++)
            {
                stars = stars + "*";
            }
            textBox1.Text = stars;
            textBox3.Text = count.ToString();
        }

        
        private void Button2_Click_1(object sender, EventArgs e)
        {
            string starcomp = stars;
            button2.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'A' || lines[i] == 'a')
                {
                    starss[i] = 'a';
                }


            }
            
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
                if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button3.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'B' || lines[i] == 'b')
                {
                    starss[i] = 'b';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button5.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'C' || lines[i] == 'c')
                {
                    starss[i] = 'c';
                }
               
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button6.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'E' || lines[i] == 'e')
                {
                    starss[i] = 'e';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button4.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'D' || lines[i] == 'd')
                {
                    starss[i] = 'd';
                }

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button7.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'F' || lines[i] == 'f')
                {
                    starss[i] = 'f';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button13.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'G' || lines[i] == 'g')
                {
                    starss[i] = 'g';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button12.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'H' || lines[i] == 'h')
                {
                    starss[i] = 'h';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button11.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'I' || lines[i] == 'i')
                {
                    starss[i] = 'i';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                label6.Text = (count + 10).ToString();

                textBox2.Text = "You have won";
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button8.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'J' || lines[i] == 'j')
                {
                    starss[i] = 'j';
                }
                
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button23.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'K' || lines[i] == 'k')
                {
                    starss[i] = 'k';
                }
               
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button22.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'L' || lines[i] == 'l')
                {
                    starss[i] = 'l';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button20.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'M' || lines[i] == 'm')
                {
                    starss[i] = 'm';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button21.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'N' || lines[i] == 'n')
                {
                    starss[i] = 'n';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                label6.Text = (count + 10).ToString();

                textBox2.Text = "You have won";
            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button19.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'O' || lines[i] == 'o')
                {
                    starss[i] = 'o';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button18.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'P' || lines[i] == 'p')
                {
                    starss[i] = 'p';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button14.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'Q' || lines[i] == 'q')
                {
                    starss[i] = 'q';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button15.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'R' || lines[i] == 'r')
                {
                    starss[i] = 'r';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button16.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'S' || lines[i] == 's')
                {
                    starss[i] = 's';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button17.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'T' || lines[i] == 't')
                {
                    starss[i] = 't';
                }
                
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button33.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'U' || lines[i] == 'u')
                {
                    starss[i] = 'u';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button32.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'V' || lines[i] == 'v')
                {
                    starss[i] = 'v';
                }
                

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button30.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'W' || lines[i] == 'w')
                {
                    starss[i] = 'w';
                }
                
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button31.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'X' || lines[i] == 'x')
                {
                    starss[i] = 'x';
                }
               

            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button9.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'Y' || lines[i] == 'y')
                {
                    starss[i] = 'y';
                }
                
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string starcomp = stars;
            button10.BackColor = Color.Gray;
            char[] lines = line.ToCharArray();
            char[] starss = stars.ToCharArray();
            for (int i = 0; i < line.Length; i++)
            {
                if (lines[i] == 'Z' || lines[i] == 'z')
                {
                    starss[i] = 'z';
                }
                
            }
            stars = new String(starss);
            textBox1.Text = stars;
            if (starcomp.Equals(stars))
            {
                count--;
                textBox3.Text = count.ToString();
            }
            if (stars.Equals(line))
            {
                textBox2.Text = "You have won";
                label6.Text = (count + 10).ToString();

            }
            if (count < 1)
            {
                textBox1.Text = "You have lost";
                textBox2.Text = line;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listpanels.Add(panel2);
            listpanels.Add(panel1);
            listpanels[0].BringToFront();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(" Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library_Dev;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into HangMan(Name,Score) values('" + name +"','"+ label6.Text+ "')", sqlConnection);
            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            SqlDataAdapter cmd1 = new SqlDataAdapter("SELECT * FROM HangMan ORDER BY Score DESC", sqlConnection);
            DataTable datatable = new DataTable();
            cmd1.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if(textBox5.Text.Length == 0)
            {
                MessageBox.Show("Please Enter your Name");
               // panel2.BringToFront();
            }
            else
            {
                name = textBox5.Text;
                //   lis  panel1.BringToFront();
                listpanels[1].BringToFront();
                label8.Text = "Let's Play " + name;
            }
        }

        
        private void Button26_Click_1(object sender, EventArgs e)
        {
            label8.Text = "Thank you " + name + " for playing";
            listpanels[0].BringToFront();
            textBox5.Text = "";

        }
    }
}

