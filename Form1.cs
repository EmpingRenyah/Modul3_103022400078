namespace Modul3_103022400078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string[] suhu = { "Celcius", "Fahrenheit", "Kelvin", "Reamur" };

        private int[] type = new int[2];
        private string[] input = new string[2];

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type[0] = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            type[1] = comboBox2.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input[0] = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type[0] == null || type[1] == null)
            {
                DialogResult res = MessageBox.Show("Pilih satuan terlebih dahulu!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else if (input[0] == null)
            {
                DialogResult res = MessageBox.Show("Masukan angka yang valid!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (type[0])
                {
                    case 0:
                        switch (type[1])
                        {
                            case 1:
                                input[1] = ((Convert.ToDouble(input[0]) * 9 / 5) + 32).ToString();
                                break;
                            case 2:
                                input[1] = (Convert.ToDouble(input[0]) + 273).ToString();
                                break;
                            case 3:
                                input[1] = (Convert.ToDouble(input[0]) * 4 / 5).ToString();
                                break;
                            default:
                                input[1] = input[0];
                                break;
                        }
                        break;
                    case 2:
                        switch (type[1])
                        {
                            case 1:
                                input[1] = ((Convert.ToDouble(input[0]) - 32) * 5 / 9).ToString();
                                break;
                            case 3:
                                input[1] = (((Convert.ToDouble(input[0]) - 32) * 5 / 9) + 273).ToString();
                                break;
                            case 4:
                                input[1] = ((Convert.ToDouble(input[0]) - 32) * 4 / 9).ToString();
                                break;
                            default:
                                input[1] = input[0];
                                break;
                        }
                        break;
                    case 3:
                        switch (type[1])
                        {
                            case 1:
                                input[1] = (Convert.ToDouble(input[0]) - 273).ToString();
                                break;
                            case 2:
                                input[1] = (((Convert.ToDouble(input[0]) - 273) * 9 / 5) + 32).ToString();
                                break;
                            case 4:
                                input[1] = ((Convert.ToDouble(input[0]) - 273) * 4 / 5).ToString();
                                break;
                            default:
                                input[1] = input[0];
                                break;
                        }
                        break;
                    case 4:
                        switch (type[1])
                        {
                            case 1:
                                input[1] = (Convert.ToDouble(input[0]) * 5 / 4).ToString();
                                break;
                            case 2:
                                input[1] = (((Convert.ToDouble(input[0]) * 5 / 4) * 9 / 5) + 32).ToString();
                                break;
                            case 3:
                                input[1] = ((Convert.ToDouble(input[0]) * 5 / 4) + 273).ToString();
                                break;
                            default:
                                input[1] = input[0];
                                break;
                        }
                        break;
                }

                textBox2.Text = input[1];
            }
        }
    }
}
