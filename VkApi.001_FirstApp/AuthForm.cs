using System;
using System.Web;
using System.Windows.Forms;

namespace VkApi._001_FirstApp
{
    public partial class AuthForm : Form
    {
        public string AccessToken { get; set; }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            WbAuthBrowser.Navigate(new Uri("https://oauth.vk.com/authorize?client_id=5544143&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,photos&response_type=token&v=5.52&state=1"));
        }

        private void WbAuthBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var urlParams = HttpUtility.ParseQueryString(e.Url.Fragment.Substring(1));
            AccessToken = urlParams.Get("access_token");

            DialogResult = DialogResult.OK;
        }
    }
}
