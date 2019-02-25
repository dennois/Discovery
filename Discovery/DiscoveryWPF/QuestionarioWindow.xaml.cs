using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DiscoveryWPF
{
    /// <summary>
    /// Interaction logic for QuestionarioWindow.xaml
    /// </summary>
    public partial class QuestionarioWindow : Window
    {

        public QuestionarioWindow()
        {
            InitializeComponent();
            this.Left = System.Windows.SystemParameters.PrimaryScreenWidth - 370;
            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight - 545;
        }

        private  void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar(txtPergunta.Text,false);
        }

        private void txtPergunta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;
           
            Pesquisar(txtPergunta.Text,false);
        }

        public async void Pesquisar(string pergunta,bool show)
        {
            string c = await QnaService.GetAnswer(pergunta);
            var respostas = JsonConvert.DeserializeObject<QnaAnswersDTO>(c);
            if (respostas.answers != null && respostas.answers.Count > 0)
            {
                if(respostas.answers[0].score != 0)
                    lstRespostas.ItemsSource = respostas.answers;
                else
                {
                    respostas.answers = new List<AnswerDTO>();
                    AnswerDTO resp = new AnswerDTO();
                    respostas.answers.Add(resp);
                    resp.answer = String.Format("Infelizmente eu não encontrei nada sobre {0}. Caso queira saber sobre outro assunto é só me informar!", pergunta);
                    lstRespostas.ItemsSource = respostas.answers;
                }
            }
            txtPergunta.Text = string.Empty;
            if (show)
                this.Show();
        }

        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
