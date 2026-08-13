namespace Ejercicio2_ErickRamirez_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 1;i<= 50; i++);
            progressBar1.Value=i;
            Application.DoEvents();
            Thread.Sleep(50);  

        }
    }
}
