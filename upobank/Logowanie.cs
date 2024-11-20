using upobank;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upobank
{
    public partial class Logowanie : Form
    {
        Form1 MainForm;
        public Logowanie(Form1 p)
        {
            MainForm = p;
            InitializeComponent();
        }

        private void LoginButtonPressed(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/login/";
            var data = new { login = login, password = password };
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            Token t = JsonConvert.DeserializeObject<Token>(json);
            MainForm.token = t.token;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExitButtonPressed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}