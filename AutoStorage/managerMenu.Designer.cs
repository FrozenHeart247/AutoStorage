namespace AutoStorage
{
    partial class managerMenu
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerMenu));
            this.contentAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userLoginBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contentManagersMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.contentManagersMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentAnimator
            // 
            this.contentAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.contentAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.contentAnimator.DefaultAnimation = animation1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.contentAnimator.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(452, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Вы вошли как";
            // 
            // userLoginBox
            // 
            this.userLoginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contentAnimator.SetDecoration(this.userLoginBox, BunifuAnimatorNS.DecorationType.None);
            this.userLoginBox.Enabled = false;
            this.userLoginBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userLoginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userLoginBox.HintForeColor = System.Drawing.Color.Empty;
            this.userLoginBox.HintText = "";
            this.userLoginBox.isPassword = false;
            this.userLoginBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.userLoginBox.LineIdleColor = System.Drawing.Color.Gray;
            this.userLoginBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userLoginBox.LineThickness = 3;
            this.userLoginBox.Location = new System.Drawing.Point(551, 37);
            this.userLoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(98, 25);
            this.userLoginBox.TabIndex = 10;
            this.userLoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contentManagersMenu
            // 
            this.contentManagersMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentManagersMenu.BackgroundImage")));
            this.contentManagersMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentManagersMenu.Controls.Add(this.metroTile7);
            this.contentManagersMenu.Controls.Add(this.metroTile6);
            this.contentManagersMenu.Controls.Add(this.metroTile5);
            this.contentManagersMenu.Controls.Add(this.metroTile4);
            this.contentManagersMenu.Controls.Add(this.metroTile3);
            this.contentManagersMenu.Controls.Add(this.metroTile8);
            this.contentManagersMenu.Controls.Add(this.metroTile2);
            this.contentManagersMenu.Controls.Add(this.metroTile1);
            this.contentAnimator.SetDecoration(this.contentManagersMenu, BunifuAnimatorNS.DecorationType.None);
            this.contentManagersMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.contentManagersMenu.GradientBottomRight = System.Drawing.Color.White;
            this.contentManagersMenu.GradientTopLeft = System.Drawing.Color.White;
            this.contentManagersMenu.GradientTopRight = System.Drawing.Color.White;
            this.contentManagersMenu.Location = new System.Drawing.Point(20, 60);
            this.contentManagersMenu.Name = "contentManagersMenu";
            this.contentManagersMenu.Quality = 10;
            this.contentManagersMenu.Size = new System.Drawing.Size(646, 362);
            this.contentManagersMenu.TabIndex = 0;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile7, BunifuAnimatorNS.DecorationType.None);
            this.metroTile7.Location = new System.Drawing.Point(14, 244);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(199, 110);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile7.TabIndex = 13;
            this.metroTile7.Text = "Справка";
            this.metroTile7.TileImage = global::AutoStorage.Properties.Resources.icons8_Help_64;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile6, BunifuAnimatorNS.DecorationType.None);
            this.metroTile6.Location = new System.Drawing.Point(432, 128);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(199, 110);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile6.TabIndex = 12;
            this.metroTile6.Text = "Просмотр складов";
            this.metroTile6.TileImage = global::AutoStorage.Properties.Resources.icons8_Product_64;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile5, BunifuAnimatorNS.DecorationType.None);
            this.metroTile5.Location = new System.Drawing.Point(432, 12);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(199, 110);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 11;
            this.metroTile5.Text = "Работа с накладными";
            this.metroTile5.TileImage = global::AutoStorage.Properties.Resources.icons8_Purchase_Order_64;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click_1);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile4, BunifuAnimatorNS.DecorationType.None);
            this.metroTile4.Location = new System.Drawing.Point(223, 12);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(199, 110);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 10;
            this.metroTile4.Text = "Просмотр накладных";
            this.metroTile4.TileImage = global::AutoStorage.Properties.Resources.icons8_Search_64;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click_1);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile3, BunifuAnimatorNS.DecorationType.None);
            this.metroTile3.Location = new System.Drawing.Point(14, 128);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(408, 110);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile3.TabIndex = 9;
            this.metroTile3.Text = "Перегрузочные операции";
            this.metroTile3.TileImage = global::AutoStorage.Properties.Resources.icons8_Fork_Lift_64;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile8, BunifuAnimatorNS.DecorationType.None);
            this.metroTile8.Location = new System.Drawing.Point(223, 244);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(199, 110);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile8.TabIndex = 8;
            this.metroTile8.Text = "\r\nСменить пользователя";
            this.metroTile8.TileImage = global::AutoStorage.Properties.Resources.icons8_Export_64;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile2, BunifuAnimatorNS.DecorationType.None);
            this.metroTile2.Location = new System.Drawing.Point(432, 244);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(199, 110);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Выход";
            this.metroTile2.TileImage = global::AutoStorage.Properties.Resources.icons8_Windows8_64;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.contentAnimator.SetDecoration(this.metroTile1, BunifuAnimatorNS.DecorationType.None);
            this.metroTile1.Location = new System.Drawing.Point(14, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(199, 110);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Личный кабинет";
            this.metroTile1.TileImage = global::AutoStorage.Properties.Resources.icons8_User_64;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // managerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 442);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.userLoginBox);
            this.Controls.Add(this.contentManagersMenu);
            this.contentAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "managerMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerMenu_FormClosing);
            this.Load += new System.EventHandler(this.managerMenu_Load);
            this.contentManagersMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel contentManagersMenu;
        private MetroFramework.Controls.MetroTile metroTile7;
        private BunifuAnimatorNS.BunifuTransition contentAnimator;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userLoginBox;

    }
}