using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\amazon";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder created");
                }
                 catch(Exception ex)
                {
                    MessageBox.Show(Exception.Message)
                }
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }

    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new
                FileStream(@"D:\amazon\emp.dat", FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToDouble(txtSalary.Text));
                MessageBox.Show("Data added to file");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bw.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\amazon\sample.txt";
                if(File.Exists(path))
                {
                    MessageBox.Show("File exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new
                FileStream(@"D:\amazon\emp.dat", FileMode.Open, FileAccess.Read);
                br=new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtSalary.Text = br.ReadDouble().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                br.Close();
                fs.Close();
            }
        }
    }
}
