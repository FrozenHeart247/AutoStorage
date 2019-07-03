namespace AutoStorage
{
    partial class finansersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finansersMenu));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.contentFinansersMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.userLoginBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contentFinansersMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentFinansersMenu
            // 
            this.contentFinansersMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentFinansersMenu.BackgroundImage")));
            this.contentFinansersMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentFinansersMenu.Controls.Add(this.metroTile3);
            this.contentFinansersMenu.Controls.Add(this.userLoginBox);
            this.contentFinansersMenu.Controls.Add(this.metroTile4);
            this.contentFinansersMenu.Controls.Add(this.metroLabel1);
            this.contentFinansersMenu.Controls.Add(this.metroTile2);
            this.contentFinansersMenu.Controls.Add(this.metroTile1);
            this.panelAnimator.SetDecoration(this.contentFinansersMenu, BunifuAnimatorNS.DecorationType.None);
            this.contentFinansersMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentFinansersMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.contentFinansersMenu.GradientBottomRight = System.Drawing.Color.White;
            this.contentFinansersMenu.GradientTopLeft = System.Drawing.Color.White;
            this.contentFinansersMenu.GradientTopRight = System.Drawing.Color.White;
            this.contentFinansersMenu.Location = new System.Drawing.Point(20, 60);
            this.contentFinansersMenu.Name = "contentFinansersMenu";
            this.contentFinansersMenu.Quality = 10;
            this.contentFinansersMenu.Size = new System.Drawing.Size(500, 383);
            this.contentFinansersMenu.TabIndex = 0;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile3, BunifuAnimatorNS.DecorationType.None);
            this.metroTile3.Location = new System.Drawing.Point(239, 33);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(218, 108);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "Сменить пользователя";
            this.metroTile3.TileImage = global::AutoStorage.Properties.Resources.icons8_Export_64;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // userLoginBox
            // 
            this.userLoginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator.SetDecoration(this.userLoginBox, BunifuAnimatorNS.DecorationType.None);
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
            this.userLoginBox.Location = new System.Drawing.Point(333, 0);
            this.userLoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(124, 26);
            this.userLoginBox.TabIndex = 2;
            this.userLoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile4, BunifuAnimatorNS.DecorationType.None);
            this.metroTile4.Location = new System.Drawing.Point(15, 261);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(218, 108);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile4.TabIndex = 2;
            this.metroTile4.Text = "Выход";
            this.metroTile4.TileImage = global::AutoStorage.Properties.Resources.icons8_Windows8_64;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.panelAnimator.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(239, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Вы вошли как";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile2, BunifuAnimatorNS.DecorationType.None);
            this.metroTile2.Location = new System.Drawing.Point(15, 147);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(442, 108);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Просмотр накладных и создание отчетов";
            this.metroTile2.TileImage = global::AutoStorage.Properties.Resources.icons8_Search_64;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile1, BunifuAnimatorNS.DecorationType.None);
            this.metroTile1.Location = new System.Drawing.Point(15, 33);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(218, 108);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Личный кабинет";
            this.metroTile1.TileImage = global::AutoStorage.Properties.Resources.icons8_User_64;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
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
            this.panelAnimator.DefaultAnimation = animation1;
            // 
            // finansersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 463);
            this.Controls.Add(this.contentFinansersMenu);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "finansersMenu";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.finansersMenu_FormClosing);
            this.Load += new System.EventHandler(this.finansersMenu_Load);
            this.contentFinansersMenu.ResumeLayout(false);
            this.contentFinansersMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel contentFinansersMenu;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userLoginBox;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}