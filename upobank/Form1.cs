using Newtonsoft.Json;
using System.Net.Http.Json;
using BankApp;

namespace BankApp
{


    public partial class Form1 : Form
    {
        public string token;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetAccountData(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/account/details/";
            var data = new { token = token };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            AccountDetailsResponse accountDetailsResponse = JsonConvert.DeserializeObject<AccountDetailsResponse>(json);
            Account account = accountDetailsResponse.account;
            AccountNameTextBox.Text = account.name;
            AccountNumberTextBox.Text = account.accountNo.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();
        }

        private void GetTransfers(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/transfers";
            var data = new { token = token };

            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token is not set.");
                return;
            }

            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;

            // Wyświetl odpowiedź JSON w oknie dialogowym
            MessageBox.Show("Response JSON: " + json);

            TransfersResponse transfersResponse = JsonConvert.DeserializeObject<TransfersResponse>(json);

            if (!string.IsNullOrEmpty(transfersResponse.Error))
            {
                MessageBox.Show("Error: " + transfersResponse.Error);
                return;
            }

            // Wyświetl liczbę pobranych przelewów w oknie dialogowym
            MessageBox.Show("Number of transfers: " + transfersResponse.Transfers.Length);

            TransfersListBox.Items.Clear();
            foreach (var transfer in transfersResponse.Transfers)
            {
                TransfersListBox.Items.Add($"From: {transfer.Source}, To: {transfer.Target}, Amount: {transfer.Amount}, Date: {transfer.Timestamp}");
            }
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
                tokenTextBox.Text = token;
            }
            else
            {
                Application.Exit();
            }
        }

        private void newTransferButton_Click(object sender, EventArgs e)
        {
            NewTransfer newTransfer = new NewTransfer();
            newTransfer.token = token;
            newTransfer.source = AccountNumberTextBox.Text;
            newTransfer.ShowDialog();
        }
    }
}
