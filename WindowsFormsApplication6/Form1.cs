using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
                        DateTime tarih = DateTime.Now;
                       // label6.Text = tarih.ToString("dd-MM-yyyy"); ;
                        label6.Text = DateTime.Now.ToShortDateString();
                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            listBox1.Items .Add (dateTimePicker1 .Text +"  " + comboBox2.Text +":"+comboBox3 .Text +"  Saatindeki  "+comboBox1 .Text +" Randevusu var." +"    Açıklama=("+richTextBox1 .Text +")");
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime tarih2 = DateTime.Now;
            string takvim = dateTimePicker1.Text;
            int hour = DateTime.Now.Hour;
            int dk = DateTime.Now.Minute;
            
            if (label6 .Text  == takvim)
            {
                Console.WriteLine("{0} = {1}", label6.Text , takvim );
                if (comboBox2.Text == hour.ToString() & comboBox3.Text == dk.ToString())
                {
                    timer2.Stop();
                    MessageBox.Show(dateTimePicker1.Text + "  " + comboBox2.Text + ":" + comboBox3.Text + "  Saatindeki  " + comboBox1.Text + " Randevusu Vakti Geldi.", "Randevu Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
         
        }
       
                         

            }
    }
