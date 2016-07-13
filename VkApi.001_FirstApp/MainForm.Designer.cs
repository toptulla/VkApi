namespace VkApi._001_FirstApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbPictureList = new System.Windows.Forms.ListBox();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.TxbxUserName = new System.Windows.Forms.TextBox();
            this.LbUserName = new System.Windows.Forms.Label();
            this.BtnGetUserId = new System.Windows.Forms.Button();
            this.TxbxUserId = new System.Windows.Forms.TextBox();
            this.LbUserId = new System.Windows.Forms.Label();
            this.LbFirstName = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.TxbxFirstName = new System.Windows.Forms.TextBox();
            this.TxbxLastName = new System.Windows.Forms.TextBox();
            this.BtnGetPictureList = new System.Windows.Forms.Button();
            this.TxbxOffset = new System.Windows.Forms.TextBox();
            this.TxbxCount = new System.Windows.Forms.TextBox();
            this.BtnSavePictures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LbPictureList
            // 
            this.LbPictureList.FormattingEnabled = true;
            this.LbPictureList.Location = new System.Drawing.Point(12, 129);
            this.LbPictureList.Name = "LbPictureList";
            this.LbPictureList.Size = new System.Drawing.Size(396, 628);
            this.LbPictureList.TabIndex = 0;
            this.LbPictureList.SelectedIndexChanged += new System.EventHandler(this.LbPictureList_SelectedIndexChanged);
            // 
            // PbPicture
            // 
            this.PbPicture.Location = new System.Drawing.Point(414, 12);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(964, 745);
            this.PbPicture.TabIndex = 1;
            this.PbPicture.TabStop = false;
            // 
            // TxbxUserName
            // 
            this.TxbxUserName.Location = new System.Drawing.Point(50, 12);
            this.TxbxUserName.Name = "TxbxUserName";
            this.TxbxUserName.Size = new System.Drawing.Size(139, 20);
            this.TxbxUserName.TabIndex = 3;
            this.TxbxUserName.Text = "ad.tsay";
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Location = new System.Drawing.Point(12, 15);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(32, 13);
            this.LbUserName.TabIndex = 4;
            this.LbUserName.Text = "User:";
            // 
            // BtnGetUserId
            // 
            this.BtnGetUserId.Location = new System.Drawing.Point(195, 10);
            this.BtnGetUserId.Name = "BtnGetUserId";
            this.BtnGetUserId.Size = new System.Drawing.Size(167, 23);
            this.BtnGetUserId.TabIndex = 5;
            this.BtnGetUserId.Text = "Получить UserId (Owner_Id)";
            this.BtnGetUserId.UseVisualStyleBackColor = true;
            this.BtnGetUserId.Click += new System.EventHandler(this.BtnGetUserId_Click);
            // 
            // TxbxUserId
            // 
            this.TxbxUserId.Location = new System.Drawing.Point(262, 39);
            this.TxbxUserId.Name = "TxbxUserId";
            this.TxbxUserId.ReadOnly = true;
            this.TxbxUserId.Size = new System.Drawing.Size(100, 20);
            this.TxbxUserId.TabIndex = 6;
            // 
            // LbUserId
            // 
            this.LbUserId.AutoSize = true;
            this.LbUserId.Location = new System.Drawing.Point(215, 42);
            this.LbUserId.Name = "LbUserId";
            this.LbUserId.Size = new System.Drawing.Size(41, 13);
            this.LbUserId.TabIndex = 7;
            this.LbUserId.Text = "UserId:";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Location = new System.Drawing.Point(224, 68);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(32, 13);
            this.LbFirstName.TabIndex = 8;
            this.LbFirstName.Text = "Имя:";
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Location = new System.Drawing.Point(197, 94);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(59, 13);
            this.LbLastName.TabIndex = 9;
            this.LbLastName.Text = "Фамилия:";
            // 
            // TxbxFirstName
            // 
            this.TxbxFirstName.Location = new System.Drawing.Point(262, 65);
            this.TxbxFirstName.Name = "TxbxFirstName";
            this.TxbxFirstName.ReadOnly = true;
            this.TxbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxbxFirstName.TabIndex = 10;
            // 
            // TxbxLastName
            // 
            this.TxbxLastName.Location = new System.Drawing.Point(262, 91);
            this.TxbxLastName.Name = "TxbxLastName";
            this.TxbxLastName.ReadOnly = true;
            this.TxbxLastName.Size = new System.Drawing.Size(100, 20);
            this.TxbxLastName.TabIndex = 11;
            // 
            // BtnGetPictureList
            // 
            this.BtnGetPictureList.Location = new System.Drawing.Point(12, 89);
            this.BtnGetPictureList.Name = "BtnGetPictureList";
            this.BtnGetPictureList.Size = new System.Drawing.Size(174, 23);
            this.BtnGetPictureList.TabIndex = 12;
            this.BtnGetPictureList.Text = "Фотографии";
            this.BtnGetPictureList.UseVisualStyleBackColor = true;
            this.BtnGetPictureList.Click += new System.EventHandler(this.BtnGetPictureList_Click);
            // 
            // TxbxOffset
            // 
            this.TxbxOffset.Location = new System.Drawing.Point(12, 39);
            this.TxbxOffset.Name = "TxbxOffset";
            this.TxbxOffset.Size = new System.Drawing.Size(32, 20);
            this.TxbxOffset.TabIndex = 13;
            this.TxbxOffset.Text = "0";
            // 
            // TxbxCount
            // 
            this.TxbxCount.Location = new System.Drawing.Point(50, 39);
            this.TxbxCount.Name = "TxbxCount";
            this.TxbxCount.Size = new System.Drawing.Size(32, 20);
            this.TxbxCount.TabIndex = 14;
            this.TxbxCount.Text = "20";
            // 
            // BtnSavePictures
            // 
            this.BtnSavePictures.Location = new System.Drawing.Point(12, 65);
            this.BtnSavePictures.Name = "BtnSavePictures";
            this.BtnSavePictures.Size = new System.Drawing.Size(174, 23);
            this.BtnSavePictures.TabIndex = 15;
            this.BtnSavePictures.Text = "Сохранить фотографии";
            this.BtnSavePictures.UseVisualStyleBackColor = true;
            this.BtnSavePictures.Click += new System.EventHandler(this.BtnSavePictures_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 776);
            this.Controls.Add(this.BtnSavePictures);
            this.Controls.Add(this.TxbxCount);
            this.Controls.Add(this.TxbxOffset);
            this.Controls.Add(this.BtnGetPictureList);
            this.Controls.Add(this.TxbxLastName);
            this.Controls.Add(this.TxbxFirstName);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.LbFirstName);
            this.Controls.Add(this.LbUserId);
            this.Controls.Add(this.TxbxUserId);
            this.Controls.Add(this.BtnGetUserId);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.TxbxUserName);
            this.Controls.Add(this.PbPicture);
            this.Controls.Add(this.LbPictureList);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbPictureList;
        private System.Windows.Forms.PictureBox PbPicture;
        private System.Windows.Forms.TextBox TxbxUserName;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Button BtnGetUserId;
        private System.Windows.Forms.TextBox TxbxUserId;
        private System.Windows.Forms.Label LbUserId;
        private System.Windows.Forms.Label LbFirstName;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.TextBox TxbxFirstName;
        private System.Windows.Forms.TextBox TxbxLastName;
        private System.Windows.Forms.Button BtnGetPictureList;
        private System.Windows.Forms.TextBox TxbxOffset;
        private System.Windows.Forms.TextBox TxbxCount;
        private System.Windows.Forms.Button BtnSavePictures;
    }
}

