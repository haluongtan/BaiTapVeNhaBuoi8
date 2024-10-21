using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{

    public partial class Form1 : Form
    {
        private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = new BindingList<Person>()
            {
                new Person() {Id = 1, Name = "Alice", Age = 30 },
            new Person() {Id = 2, Name = "Bod", Age = 25 },
            new Person() {Id = 3, Name = "Tam", Age = 35 }
            };
            bindingSource = new BindingSource();
            bindingSource.DataSource = people;
            dataGridView1.DataSource = bindingSource;
            textBox1.DataBindings.Add("Text", bindingSource, "Name");
            textBox2.DataBindings.Add("Text", bindingSource, "Age");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }
    }
}
