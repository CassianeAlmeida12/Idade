namespace idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            DateTime dataNasc = dateTimePicker1.Value;

            DateTime dataAtual = DateTime.Now;

            int idade = dataAtual.Year - dataNasc.Year;



            if (dataAtual.Month < dataNasc.Month || (dataAtual.Month == dataNasc.Month && dataAtual.Day < dataNasc.Day))
            {


                --idade;
            }



            label1.Text = $"{idade}";
        }
    }
}