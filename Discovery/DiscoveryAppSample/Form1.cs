using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoveryAppSample
{
    public partial class Form1 : Form
    {
        #region [ Membros ]

        List<KeyValuePair<int, string>> _produtos;
        List<KeyValuePair<int, string>> _ofertas;
        List<KeyValuePair<int, string>> _linhasProdutos;
        bool _isVA = true;

        HubConnection _connection;

        #endregion

        #region [ Propriedades ]


        public List<KeyValuePair<int, string>> Produtos { get => _produtos; set => _produtos = value; }
        public List<KeyValuePair<int, string>> Ofertas { get => _ofertas; set => _ofertas = value; }
        public List<KeyValuePair<int, string>> LinhasProdutos { get => _linhasProdutos; set => _linhasProdutos = value; }
        public bool IsVA { get => _isVA; set => _isVA = value; }

        #endregion

        public Form1()
        {
            InitializeComponent();
            Inicializar();
            Go();
        }

        private void EnviarAcao(string acao)
        {

        }

        private void Inicializar()
        {
            LinhasProdutos = new List<KeyValuePair<int, string>>();
            LinhasProdutos.Add(new KeyValuePair<int, string>(0, "Selecione uma opção"));
            LinhasProdutos.Add(new KeyValuePair<int, string>(1, "Móvel"));
            LinhasProdutos.Add(new KeyValuePair<int, string>(2, "Internet"));
            LinhasProdutos.Add(new KeyValuePair<int, string>(3, "Fixo"));
            LinhasProdutos.Add(new KeyValuePair<int, string>(4, "TV"));
            
            Produtos = new List<KeyValuePair<int, string>>();
            Produtos.Add(new KeyValuePair<int, string>(10, "Selecione uma opção"));
            Produtos.Add(new KeyValuePair<int, string>(10, "Pós 30GB"));
            Produtos.Add(new KeyValuePair<int, string>(11, "Pós 40GB"));
            Produtos.Add(new KeyValuePair<int, string>(12, "Pós 50GB"));
            Produtos.Add(new KeyValuePair<int, string>(13, "Pós 70GB"));
            Produtos.Add(new KeyValuePair<int, string>(14, "Pré Pago"));

            Produtos.Add(new KeyValuePair<int, string>(20, "Selecione uma opção"));
            Produtos.Add(new KeyValuePair<int, string>(20, "50 Mega"));
            Produtos.Add(new KeyValuePair<int, string>(21, "100 Mega"));
            Produtos.Add(new KeyValuePair<int, string>(22, "300 Mega"));

            Produtos.Add(new KeyValuePair<int, string>(30, "Selecione uma opção"));
            Produtos.Add(new KeyValuePair<int, string>(30, "Vivo Fixo Ilimitado Local"));
            Produtos.Add(new KeyValuePair<int, string>(31, "Vivo Fixo Ilimitado Brasil"));

            Produtos.Add(new KeyValuePair<int, string>(49, "Selecione uma opção"));
            Produtos.Add(new KeyValuePair<int, string>(40, "Super HD"));
            Produtos.Add(new KeyValuePair<int, string>(41, "Ultra HD"));
            Produtos.Add(new KeyValuePair<int, string>(42, "Ultimate HD"));
            Produtos.Add(new KeyValuePair<int, string>(43, "Full HD"));

            Ofertas = new List<KeyValuePair<int, string>>();
            Ofertas.Add(new KeyValuePair<int, string>(14, "Selecione uma opção"));
            Ofertas.Add(new KeyValuePair<int, string>(14,"Recarga R$20,00"));
            Ofertas.Add(new KeyValuePair<int, string>(14, "Recarga R$50,00"));
            Ofertas.Add(new KeyValuePair<int, string>(14, "Recarga R$100,00"));

            Ofertas.Add(new KeyValuePair<int, string>(41, "Selecione uma opção"));
            Ofertas.Add(new KeyValuePair<int, string>(41, "Canal Combate"));
            Ofertas.Add(new KeyValuePair<int, string>(43, "Selecione uma opção"));
            Ofertas.Add(new KeyValuePair<int, string>(43, "Ultra HD desconto especial"));
            Ofertas.Add(new KeyValuePair<int, string>(40, "Selecione uma opção"));
            Ofertas.Add(new KeyValuePair<int, string>(40, "Ultra HD desconto especial"));

            cboLinha.DataSource = LinhasProdutos;
        }

        private async void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                #region snippet_ErrorHandling
                try
                {
                    #region snippet_InvokeAsync
                    await _connection.InvokeAsync("SendAction", "Física", 1);
                    #endregion
                }
                catch (Exception ex)
                {

                }
            }
            #endregion
        }

        async static Task GetAnswer(string question)
        {
            string endpoint_host = "https://discoveryqna.azurewebsites.net/qnamaker";
            //var uri = endpoint_host + endpointService + baseRoute + "/" + kbid + "/generateAnswer";
            var uri = endpoint_host + "/knowledgebases/3411861a-c73c-49e5-9d2e-9d50e68c1be4/generateAnswer";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(uri);
                request.Content = new StringContent("{question:'" + question + "'}", Encoding.UTF8, "application/json");

                // NOTE: The value of the header contains the string/text 'EndpointKey ' with the trailing space
                request.Headers.Add("Authorization", "EndpointKey " + "3a227369-2646-47ff-9af2-98ab8eae446c");

                var response = await client.SendAsync(request);
                var responseBody = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(PrettyPrint(responseBody));

            }


        }

        private async void Go()
        {
            _connection = new HubConnectionBuilder()
              .WithUrl("http://localhost:60164/DiscoveryHub")
              .Build();

            #region snippet_ClosedRestart
            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
            };
            #endregion

            await _connection.StartAsync();
        }

        private async void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                #region snippet_ErrorHandling
                try
                {
                    #region snippet_InvokeAsync
                    await _connection.InvokeAsync("SendAction", "Jurídica", 2);
                    #endregion
                }
                catch (Exception ex)
                {

                }
                #endregion
            }
        }

        private void CarregarOfertas(int idProduto)
        {
            var ofertas = Ofertas.Where(x => x.Key == idProduto).ToList();
            if(ofertas != null && ofertas.Count > 0)
            {
                lblOfertas.Visible = true;
                cboOfertas.Visible = true;
                cboOfertas.DataSource = ofertas;
            }
            else
            {
                lblOfertas.Visible = false;
                cboOfertas.Visible = false;
            }
        }

        private void cboLinha_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboLinha.SelectedValue);
            var produtos = Produtos.Where(p => p.Key >= id * 10 && p.Key < ((id+1) * 10) - 1).ToList();
            cboProdutos.DataSource = produtos;
        }

        private async void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboProdutos.SelectedValue);
            CarregarOfertas(id);
            if (id == 14)
            {
                await _connection.InvokeAsync("SendAction", "Prépago", 2);
            }
        }
    }
}
