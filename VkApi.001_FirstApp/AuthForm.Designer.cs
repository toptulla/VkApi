namespace VkApi._001_FirstApp
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WbAuthBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WbAuthBrowser
            // 
            this.WbAuthBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WbAuthBrowser.Location = new System.Drawing.Point(0, 0);
            this.WbAuthBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbAuthBrowser.Name = "WbAuthBrowser";
            this.WbAuthBrowser.Size = new System.Drawing.Size(780, 509);
            this.WbAuthBrowser.TabIndex = 0;
            this.WbAuthBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WbAuthBrowser_Navigated);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 509);
            this.Controls.Add(this.WbAuthBrowser);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WbAuthBrowser;
    }
}