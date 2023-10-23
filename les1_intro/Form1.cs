using System.Runtime.CompilerServices;

namespace les1_intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Farewell(object sender, EventArgs e)
        {
            MessageBox.Show("Farewell");
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ForeColor = Color.White;
        }
    }
}