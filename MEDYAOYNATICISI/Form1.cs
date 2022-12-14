using System.Runtime.InteropServices;
using System.Windows.Forms;
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

        private Video video;
        private string[] videoPath;
        private int selectindex=0;
        private Size FormSize;
        private Size PanelSize;
        private string folderpath=@"";

            
        private void Form1_Load(object sender, EventArgs e)
        {

            FormSize = new Size(this.Width, this.Height);
            PanelSize = new Size(panelvideo.Width, panelvideo.Height);
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();

            folderpath = fd.SelectedPath;
            
            
           
            videoPath = Directory.GetFiles(folderpath, "* .mp4");
            if (videoPath != null)
            {
                foreach(string path in videoPath)
                {
                    string vid = path.Replace(folderpath, string.Empty);
                    vid = vid.Replace("* .mp4", string.Empty);
                    listBox1.Items.Add(vid);
                }
            }
            if(listBox1.SelectedItems.Count>0)
            { 
            }
            else
            {
                listBox1.SelectedIndex = selectindex;

            }
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

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch
            {

            }
            int index = listBox1.SelectedIndex;
            selectindex = index;
            video = new Video(videoPath[index], false);
            video.Owner = panelvideo;
            panelvideo.Size = PanelSize;
            video.Play();
            tmrvideo.Enabled = true;
            video.Ending += Video_Ending;
            label1.Text = listBox1.Text;
        }

        private void Video_Ending(object sender,EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextVideo();
                    }));
                }
            });
        }
        private void NextVideo()
        {
            int index = listBox1.SelectedIndex;
            index++;
            if(index>videoPath.Length)
            {
                index = 0;
                selectindex = index;
                listBox1.SelectedIndex = index;
            }
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

        private void panelvideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttononceki_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index == -1)
                index = videoPath.Length - 1;
            selectindex = index;
            listBox1.SelectedIndex = index;
        }

        private void buttonsonraki_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void buttonoynat_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
                tmrvideo.Enabled = true;
                buttonoynat.Text = "Durdur";
            }
            else if (video.Playing)
            {
                video.Pause();
                tmrvideo.Enabled = false;
            }
        }

        private void trackvolume_Scroll(object sender, EventArgs e)
        {
            video.Audio.Volume = trackvolume.Value;
        }
    }
    }
