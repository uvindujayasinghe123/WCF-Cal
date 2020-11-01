using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        //reference service
        ServerAppServiceReference.Service1Client AppClient = new ServerAppServiceReference.Service1Client();
        //ServiceReference1.ServiceClient clint = new ServiceReference1.ServiceClient();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //add btn
        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_box_result.Text = AppClient.AddValues(Convert.ToDouble(txt_box_01.Text), Convert.ToDouble(txt_box_02.Text)).ToString();
        }

        private void txt_box_result_TextChanged(object sender, EventArgs e)
        {
            
        }


        //clear btn
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_box_01.Text = "";
            txt_box_02.Text = "";
            txt_box_result.Text = "";
        }

        //multiply btn
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            txt_box_result.Text = AppClient.MultiplyValues(Convert.ToDouble(txt_box_01.Text), Convert.ToDouble(txt_box_02.Text)).ToString();
        }

        private void txt_box_01_TextChanged(object sender, EventArgs e)
        {

        }

        //divide btn
        private void btn_divide_Click(object sender, EventArgs e)
        {
            txt_box_result.Text = AppClient.DivideValues(Convert.ToDouble(txt_box_01.Text), Convert.ToDouble(txt_box_02.Text)).ToString();
        }

        //subtract btn
        private void btn_substract_Click(object sender, EventArgs e)
        {
            txt_box_result.Text = AppClient.SubstractValues(Convert.ToDouble(txt_box_01.Text), Convert.ToDouble(txt_box_02.Text)).ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
