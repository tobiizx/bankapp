using Newtonsoft.Json;
using System.Net.Http.Json;

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
            //to jest blibioteka do wysy�ania zapyta� http
            //i przetwarzania odpowiedzi otrzymanych z API
            HttpClient client = new HttpClient();
            //adres API - endpoint zwraca szczeg�y rachunku na podstawie tokenu
            string url = "http://localhost/bankAPI/account/details/";
            //tworzymy obiekt zawieraj�cy token
            var data = new { token = token };
            //wysy�amy zapytanie POST do API zawieraj�ce token
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            //wyci�gnij z odpowiedzi dane w formacie JSON
            string json = response.Content.ReadAsStringAsync().Result;
            Account account = JsonConvert.DeserializeObject<Account>(json);
            //wypisz dane na formularzu
            AccountNameTextBox.Text = account.name;
            AccountNumberTextBox.Text = account.accountNo.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();

        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                //je�li zalogowano poprawnie to poka� formularz
                this.Show();
                tokenTextBox.Text = token;
            }
            else
            {
                //je�li nie to zamknij aplikacj�
                Application.Exit();
            }
        }

        private void newTransferButton_Click(object sender, EventArgs e)
        {
            //otw�rz formularz nowego przelewu
            NewTransfer newTransfer = new NewTransfer();
            
            newTransfer.token = token;
            newTransfer.source = AccountNumberTextBox.Text;

            newTransfer.ShowDialog();
            //TODO: poka� zaktualizowany stan konta po wykonaniu przelewu
        }
    }
}
