using Microsoft.AspNetCore.SignalR.Client;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiscoveryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region [ Membros ]

        HubConnection connection;
        QuestionarioWindow window = new QuestionarioWindow();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            this.Left = System.Windows.SystemParameters.PrimaryScreenWidth - 120;
            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight - 130;
            Go();
        }

        private async void Go()
        {
            connection = new HubConnectionBuilder()
              .WithUrl("http://localhost:60164/DiscoveryHub")
              .Build();

            #region snippet_ClosedRestart
            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };
            #endregion

            await connection.StartAsync();

            #region snippet_ConnectionOn
            connection.On<string, int>("ReceiveAction", (user, idAction) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    //MessageBox.Show(user);
                    //  lblTexto.Content = user;
                    //var newMessage = $"{user}: {message}";
                    window.Pesquisar(user,true);
                });
            });
            #endregion

            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAV_Click(object sender, RoutedEventArgs e)
        {
            window.Show();
        }
    }
}
