using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class frmAddMemo : Form
    {
        public frmAddMemo()
        {
            InitializeComponent();
        }

        private void frmAddMemo_Load(object sender, EventArgs e)
        {
            
        }

        private void frmAddMemo_FormClosed(object sender, FormClosedEventArgs e)
        {
            DiaryApp.Properties.Settings.Default.formOpened = null;
            DiaryApp.Properties.Settings.Default.Save();
        }
    }
}
