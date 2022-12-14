using System.Runtime.InteropServices;
using Microsoft.DirectX.AudioVideoPlayback;


namespace MEDYAOYNATICISI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
            [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

            [DllImport("user32.dll", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int ýparam);
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panellist_Click(object sender, EventArgs e)
        {

                if(panelsag.Width==249)
            {
                panelsag.Width = 35;
            }
            else 
            {
                panelsag.Width = 249;
            }
        }

        private void panelbas_DoubleClick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if (FormWindowState.Normal==frm.WindowState)
            {
                WindowState = WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal : FormWindowState.Maximized;
            }
            if(FormWindowState.Maximized==frm.WindowState)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnekrankucult.Visible = true;


            btnkpt.Location = new Point(1885, -2);
            btnekrankucult.Location = new Point(1840, -2);
            btnmax.Location = new Point(1840, -2);
            btnmin.Location = new Point(1795, -2);

            buttonsonraki.Location = new Point(590,10);
            buttononceki.Location = new Point(490,10);
            buttonoynat.Location = new Point(540,10);

            panelsag.Width = 249;  
          
        }

        private void MF()
        {
            //Form1 frm = new Form1();
            if(this.WindowState==FormWindowState.Maximized)

            {
                this.WindowState = FormWindowState.Normal;
                this.btnmax.Visible = false;
                this.btnekrankucult.Visible = true;
            }
            else if(this.WindowState == FormWindowState.Minimized)
            {

                this.WindowState = FormWindowState.Normal;
                this.btnmax.Visible = false;
                this.btnekrankucult.Visible = true;
            }
           
        }

        private void btnekrankucult_Click(object sender, EventArgs e)
        {


            btnkpt.Location = new Point(1237,- 2);
            btnekrankucult.Location = new Point(1194, -2);
            btnmax.Location = new Point(1194, -2);
            btnmin.Location = new Point(1148, -2);


            this.WindowState = FormWindowState.Normal;
            this.btnmax.Visible = true;
            this.btnekrankucult.Visible = false;

        }

        private void panelliste_Click(object sender, EventArgs e)
        {
            if (panelsag.Width ==249)
            {
                panelsag.Width = 35;

                panel6.Location = new Point(0,36);
                panel7.Location = new Point(0,651);
                panelvideo.Location = new Point(26,8);

            }
        else
            {
                panelsag.Width = 249;   ;
            }
        
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
