using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscoveryVA
{
    public partial class VA : Form
    {
        #region [ Membros ]

        bool _isVA = true;
        VADialog _vaDialog = null;

        #endregion

        #region [ Propriedades ]

        public bool IsVA { get => _isVA; set => _isVA = value; }
        public VADialog VaDialog { get => _vaDialog; set => _vaDialog = value; }

        #endregion

        public VA()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 120, Screen.PrimaryScreen.Bounds.Height - 125);
            VaDialog = new VADialog();

        }



        private void btnVA_Click(object sender, EventArgs e)
        {
            if (IsVA)
            {
                btnVA.Image = Properties.Resources.discovery_icon_fechar;
                IsVA = false;
                VaDialog.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 320, Screen.PrimaryScreen.Bounds.Height - 600);
                VaDialog.Show();
            }
            else
            {
              btnVA.Image = Properties.Resources.disco1;
                IsVA = true;
                VaDialog.Hide();
            }
        }
    }
}
