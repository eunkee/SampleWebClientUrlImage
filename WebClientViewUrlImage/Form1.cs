using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientViewUrlImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async static Task<Image> GetUrlImage(string url)
        {
            Image img = null;
            try
            {
                using WebClient client = new();
                Uri uri = new(url);
                byte[] imgArray = await client.DownloadDataTaskAsync(uri);
                using MemoryStream memstr = new(imgArray);
                img = Image.FromStream(memstr);
            }
            catch { }
            return img;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            //sample
            //url = "https://www.10wallpaper.com/wallpaper/3840x2400/2111/Mountain_Lake_2021_National_Forest_Park_4K_Photo_3840x2400.jpg";
            string url = TextBoxUrl.Text;
            if (url.Length <= 0)
            {
                MessageBox.Show("Requires Url input.");
                return;
            }

            PictureBoxView.BackgroundImage = null;
            PictureBoxLoading.Visible = true;
            var task0 = Task.Run(() => GetUrlImage(url));
            task0.ContinueWith(x =>
            {
                PictureBoxLoading.Visible = false;
                Image data = x.Result;
                if (data != null)
                {
                    PictureBoxView.BackgroundImage = data;
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
