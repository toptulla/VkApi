using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace VkApi._001_FirstApp
{
    public partial class MainForm : Form
    {
        public string AccessToken { get; set; }
        public User User { get; set; }
        public List<Picture> Pictures { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var authForm = new AuthForm();
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                AccessToken = authForm.AccessToken;
            }
        }

        private void GetData(string accessToken)//13785518 | 26921515 | sex.drugs_rock_and_roll
        {
            //var request = (HttpWebRequest)WebRequest.Create("https://api.vk.com/method/users.get?user_ids=totmori&fields=bdate&v=5.52");
            var request = (HttpWebRequest)WebRequest.Create($"https://api.vk.com/method/photos.getAll?owner_id=26921515&access_token={accessToken}&v=5.52");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                string s = sr.ReadToEnd();
            }
        }

        private async void BtnGetUserId_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxbxUserName.Text))
            {
                var request = (HttpWebRequest)WebRequest.Create($"https://api.vk.com/method/users.get?user_ids={TxbxUserName.Text}&v=5.52");
                var response = (HttpWebResponse)await request.GetResponseAsync();

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    var userJToken = JObject.Parse(sr.ReadToEnd())["response"].Children().First();
                    User = JsonConvert.DeserializeObject<User>(userJToken.ToString());
                    TxbxUserId.Text = User.id.ToString();
                    TxbxFirstName.Text = User.first_name;
                    TxbxLastName.Text = User.last_name;
                }
            }
        }

        private async void BtnGetPictureList_Click(object sender, EventArgs e)
        {
            if (User == null)
                return;

            int offset = int.Parse(TxbxOffset.Text);
            int count = int.Parse(TxbxCount.Text);

            var request = (HttpWebRequest)WebRequest.Create($"https://api.vk.com/method/photos.getAll?owner_id={User.id}&photo_sizes=1&offset={offset}&count={count}&access_token={AccessToken}&v=5.52");
            var response = (HttpWebResponse)await request.GetResponseAsync();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                //string s = sr.ReadToEnd();

                IList<JToken> photosJToken = JObject.Parse(sr.ReadToEnd())["response"]["items"].Children().ToList();
                if (photosJToken.Count > 0)
                {
                    Pictures = new List<Picture>(photosJToken.Count);

                    foreach (JToken photoJToken in photosJToken)
                    {
                        Picture picture = JsonConvert.DeserializeObject<Picture>(photoJToken.ToString());
                        Pictures.Add(picture);
                    }

                    LbPictureList.Items.Clear();
                    foreach (var item in Pictures)
                    {
                        LbPictureList.Items.Add(item);
                    }
                }
            }
        }

        private void LbPictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pictures.Count != 0 && Pictures.Count >= LbPictureList.SelectedIndex)
            {
                if (Pictures[LbPictureList.SelectedIndex].sizes.Any())
                {
                    Size size = Pictures[LbPictureList.SelectedIndex].sizes.Last();
                    PbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    PbPicture.Load(size.src);
                }
            }
        }

        private byte[] ReadBytesStream(Stream input)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void BtnSavePictures_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class Picture
    {
        public int id { get; set; }
        public int album_id { get; set; }
        public int owner_id { get; set; }
        public List<Size> sizes { get; set; }
        public string text { get; set; }
        public ulong date { get; set; }
        public double lat { get; set; }
        public double @long { get; set; }
        public int post_id { get; set; }

        public override string ToString()
        {
            return $"id = {id} | (lat={lat} | long={@long}) Date={UnixTimeStampToDateTime(date)}";
        }

        public DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }

    public class Size
    {
        public string src { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string type { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
