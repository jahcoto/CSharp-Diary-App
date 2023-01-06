using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DiaryApp
{
    public partial class Form1 : Form
    {
        frmAddMemo frmAddMemo = null;
        string WinState = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close();
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnShowDesktop_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getTime();

            lblVersion.Text += System.Windows.Forms.Application.ProductVersion;

            backgroundImageloader(DiaryApp.Properties.Settings.Default.selectedBackgroundImage.ToString());

            backgroundImageCombo();

            musicLoader();

            string formName = DiaryApp.Properties.Settings.Default.formOpened;
            if (DiaryApp.Properties.Settings.Default.mdiChildWinState == "") 
            {
                WinState = "Normal";
            }
            else 
            {
                WinState = DiaryApp.Properties.Settings.Default.mdiChildWinState;
            }            
            FormWindowState fws = (FormWindowState)Enum.Parse(typeof(FormWindowState), WinState);
            switch (formName)
            {
                case "frmAddMemo":
                    frmAddMemo = new frmAddMemo
                    {
                        WindowState = fws,
                        StartPosition = FormStartPosition.CenterParent,
                        MdiParent = this,
                    };
                    frmAddMemo.Show();
                    
                    foreach (Control ctrl in frmAddMemo.Controls)
                    {
                        if (ctrl.GetType().Name == "TextBox")
                        {
                            TextBox text = (TextBox)ctrl;
                            if (text.Name == "txtMemoText")
                            {
                                MessageBox.Show(DiaryApp.Properties.Settings.Default.txtMemoText);
                                text.Text = DiaryApp.Properties.Settings.Default.txtMemoText;                                
                            }
                        }
                        if (ctrl.GetType().Name == "DateTimePicker") 
                        {
                            DateTimePicker startDate = (DateTimePicker)ctrl;
                            if (startDate.Name == "dtpStartDate") 
                            {
                                if (DiaryApp.Properties.Settings.Default.dtpStartDate != "") 
                                {
                                    MessageBox.Show(DiaryApp.Properties.Settings.Default.dtpStartDate);
                                    startDate.Value = Convert.ToDateTime(DiaryApp.Properties.Settings.Default.dtpStartDate);
                                }                                
                            }
                        }
                    }
                    break;
            }
        }

        public void backgroundImageCombo() 
        {
            for (int i = 1; i <= 4; i++) 
            {
                cboLoadImage.Items.Add("Image " + i.ToString());
            }
        }

        public void musicLoader() 
        {
            cboMusic.Items.Clear();
            for (int i = 1; i <= 3; i++)
            {
                cboMusic.Items.Add("Music " + i.ToString());
            }
        }

        public void backgroundImageloader(string imgNumber) 
        {
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Data\\Pics\\" + imgNumber + ".jpg";
            //MessageBox.Show(fileName);
            this.BackgroundImage = System.Drawing.Image.FromFile(fileName);
            this.BackgroundImageLayout= ImageLayout.Stretch;
        }

        public void getTime() 
        {
            this.lblDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cboLoadImage_SelectedValueChanged(object sender, EventArgs e)
        {
            string pictureName = cboLoadImage.SelectedItem.ToString();
            backgroundImageloader(pictureName.Substring(6,1));
            //----Save the seleted Image in settings
            DiaryApp.Properties.Settings.Default.selectedBackgroundImage = int.Parse(pictureName.Substring(6, 1));
            DiaryApp.Properties.Settings.Default.Save();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmAddMemo = new frmAddMemo 
            {
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.CenterParent, 
                MdiParent= this,
            };        
            frmAddMemo.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {           
            foreach (Form frm in MdiChildren)
            {
                DiaryApp.Properties.Settings.Default.formOpened = frm.Name;
                DiaryApp.Properties.Settings.Default.mdiChildWinState = frm.WindowState.ToString();
                foreach (Control ctrl in frm.Controls)
                {
                    if (ctrl.GetType().Name == "TextBox")
                    {
                        TextBox text = (TextBox)ctrl;
                        if (text.Text != "")
                        {
                            DiaryApp.Properties.Settings.Default.txtMemoText = text.Text;
                            MessageBox.Show(text.Text);
                        }
                    }
                    if (ctrl.GetType().Name == "DateTimePicker")
                    {
                        DateTimePicker startDate = (DateTimePicker)ctrl;
                        DiaryApp.Properties.Settings.Default.dtpStartDate = startDate.Value.ToString();
                        MessageBox.Show(startDate.Text);
                    }
                }
                DiaryApp.Properties.Settings.Default.Save();                
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
