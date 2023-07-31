using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial_robot_PSM
{
    public partial class Form1 : Form
    {
       
        string left2 = ""; 
        string right2 = "";
        string height2 = "";
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            string[] ports = SerialPort.GetPortNames(); 
            port_select.Items.AddRange(ports); // introducerea acestora intr-un ComboBox pentru a putea alege portul dorit
  

         
        }

        private void button_connect_Click(object sender, EventArgs e) // evenimentul in momentul apasarii butonului "Connect"
        {
            serialPort.PortName = port_select.Text;  // serialPortul creat pentru comunicarea cu aplicatia C# primeste portul selectat de noi
            serialPort.Open(); // deschidem comunicarea intre serialPort si aplicatia C#
            button_connect.Enabled = false; // butonul "Connect" este "inghetat" astfel nu il mai putem apasa odata conectat
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
            if (control_scroll.Checked && serialPort.IsOpen) // verificam daca CheckButton-ul de la controlul Scroll si serialul este pornit
            {
                ScrollBar_left.Enabled = true;               //activam folosirea scrollbar-ului 
                ScrollBar_right.Enabled = true;              //activam folosirea scrollbar-ului 
                ScrollBar_height.Enabled = true;             //activam folosirea scrollbar-ului 


                
                var left = Convert.ToString(2270 - ScrollBar_left.Value); 
                var right = Convert.ToString(ScrollBar_right.Value); 
                var height = Convert.ToString(ScrollBar_height.Value); 

                label_valoare_left.Text = left; 
                label_valoare_right.Text = right; // se afiseaza pozitia scrollbar-ului
                label_valoare_height.Text = height; // se afiseaza pozitia scrollbar-ului


                if (height != height2) 
                {
                    serialPort.WriteLine(Convert.ToString(ScrollBar_height.Value) + "1"); 
                    istoric_comenzi.Items.Add(Convert.ToString(ScrollBar_height.Value) + " - height");
                }

                if (left != left2) //verificam sa nu fie aceeasi pozitie
                {

                    serialPort.WriteLine(Convert.ToString(2270 - ScrollBar_left.Value) + "2");
                    istoric_comenzi.Items.Add(Convert.ToString(2270 - ScrollBar_left.Value) + " - left");
                }

                if (right != right2) //verificam sa nu fie aceeasi pozitie
                {
                    serialPort.WriteLine(Convert.ToString(ScrollBar_right.Value) + "3");
                    istoric_comenzi.Items.Add(Convert.ToString(ScrollBar_right.Value) + " - right");
                }
                
              


                 left2 = Convert.ToString(2270 - ScrollBar_left.Value);
                 right2 = Convert.ToString(ScrollBar_right.Value);
                 height2 = Convert.ToString(ScrollBar_height.Value);
        }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (radioButton_height.Checked)
            {
                serialPort.Write(textBox_send.Text + "1");
                istoric_comenzi.Items.Add(textBox_send.Text + " - height");
            }

            if (radioButton_left.Checked)
            {
                serialPort.Write(textBox_send.Text + "2");
                istoric_comenzi.Items.Add(textBox_send.Text + " - stanga");
            }

            if(radioButton_right.Checked)
            {
                serialPort.Write(textBox_send.Text + "3");
                istoric_comenzi.Items.Add(textBox_send.Text + " - dreapta");
            }
           
        }
        
       

    }
}
