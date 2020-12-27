using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace hack
{
    public partial class Form1 : Form
    {
        Memory.Mem memory = new Memory.Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among US").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01C555C8,5C,14,14", "float", textBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among US").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+01C4B4B8,5C,24,18", "float", textBox2.Text);
            memory.WriteMemory("GameAssembly.dll+01C68F58,5C,E4,1C", "float", textBox2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Deepacks/ShipToaster");
        }
    }
}
