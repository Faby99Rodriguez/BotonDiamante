using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonDiamante
{
    public partial class UCDiamantee: UserControl
    {
        public UCDiamantee()
        {
            InitializeComponent();
        }

        private void btnDiamant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOY UN DIAMANTE");
        }
    }
}
