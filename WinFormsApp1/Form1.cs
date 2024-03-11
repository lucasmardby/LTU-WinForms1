namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private Calculator calculator = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            txtPrize.Text = string.Empty;
            txtPayment.Text = string.Empty;

            listboxChange.Items.Clear();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool ok = ReadInput();

            if (ok)
            {
                DisplayResults();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ReadInput()
        {
            bool prizeOK = ReadPrize();
            bool paymentOK = ReadPayment();

            return prizeOK && paymentOK;
        }
        private bool ReadPrize()
        {
            bool ok = int.TryParse(txtPrize.Text.Trim(), out int prize);

            if (prize > 0)
            {
                calculator.SetPrize(prize);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid prize value!", "Error!");
            }

            return ok;

        }
        private bool ReadPayment()
        {
            bool ok = int.TryParse(txtPayment.Text.Trim(), out int payment);

            if (payment > 0)
            {
                calculator.SetPayment(payment);
            }
            else
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Invalid payment value!", "Error!");
            }

            return ok;
        }

        private void DisplayResults()
        {
            calculator.CalculateChange();

            listboxChange.Items.Clear();
            listboxChange.Items.Add("Your change:");
            listboxChange.Items.Add("");

            if (calculator.GetFiveHundreds() > 0)
                listboxChange.Items.Add($"{calculator.GetFiveHundreds()} 500-bill{calculator.MoneyTypePlural(calculator.GetFiveHundreds())}");
            if (calculator.GetTwoHundreds() > 0)
                listboxChange.Items.Add($"{calculator.GetTwoHundreds()} 200-bill{calculator.MoneyTypePlural(calculator.GetTwoHundreds())}");
            if (calculator.GetOneHundreds() > 0)
                listboxChange.Items.Add($"{calculator.GetOneHundreds()} 100-bill{calculator.MoneyTypePlural(calculator.GetOneHundreds())}");
            if (calculator.GetFifties() > 0)
                listboxChange.Items.Add($"{calculator.GetFifties()} 50-bill{calculator.MoneyTypePlural(calculator.GetFifties())}");
            if (calculator.GetTwenties() > 0)
                listboxChange.Items.Add($"{calculator.GetTwenties()} 20-bill{calculator.MoneyTypePlural(calculator.GetFives())}");
            if (calculator.GetTens() > 0)
                listboxChange.Items.Add($"{calculator.GetTens()} 10-coin{calculator.MoneyTypePlural(calculator.GetTens())}");
            if (calculator.GetFives() > 0)
                listboxChange.Items.Add($"{calculator.GetFives()} 5-coin{calculator.MoneyTypePlural(calculator.GetFives())}");
            if (calculator.GetOnes() > 0)
                listboxChange.Items.Add($"{calculator.GetOnes()} 1-coin{calculator.MoneyTypePlural(calculator.GetOnes())}");
        }
    }
}
