namespace AutoStorage
{
    partial class workWithBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workWithBills));
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userLoginBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contentMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.backToManagersMenu = new System.Windows.Forms.Button();
            this.contentMenu.SuspendLayout();
            this.SuspendLayout();
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.panelAnimator.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(463, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Вы вошли как";
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
            this.userLoginBox.Location = new System.Drawing.Point(562, 37);
            this.userLoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(98, 25);
            this.userLoginBox.TabIndex = 20;
            this.userLoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contentMenu
            // 
            this.contentMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentMenu.BackgroundImage")));
            this.contentMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentMenu.Controls.Add(this.metroTile1);
            this.contentMenu.Controls.Add(this.metroTile6);
            this.contentMenu.Controls.Add(this.metroTile7);
            this.contentMenu.Controls.Add(this.metroTile2);
            this.contentMenu.Controls.Add(this.metroTile3);
            this.contentMenu.Controls.Add(this.metroTile4);
            this.contentMenu.Controls.Add(this.metroTile5);
            this.panelAnimator.SetDecoration(this.contentMenu, BunifuAnimatorNS.DecorationType.None);
            this.contentMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.contentMenu.GradientBottomRight = System.Drawing.Color.White;
            this.contentMenu.GradientTopLeft = System.Drawing.Color.White;
            this.contentMenu.GradientTopRight = System.Drawing.Color.White;
            this.contentMenu.Location = new System.Drawing.Point(20, 60);
            this.contentMenu.Name = "contentMenu";
            this.contentMenu.Quality = 10;
            this.contentMenu.Size = new System.Drawing.Size(661, 357);
            this.contentMenu.TabIndex = 19;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile1, BunifuAnimatorNS.DecorationType.None);
            this.metroTile1.Location = new System.Drawing.Point(25, 123);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(203, 108);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Добавить \r\nприходную накладную";
            this.metroTile1.TileImage = global::AutoStorage.Properties.Resources.icons8_Add_File_64;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile6, BunifuAnimatorNS.DecorationType.None);
            this.metroTile6.Location = new System.Drawing.Point(234, 123);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(203, 108);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile6.TabIndex = 6;
            this.metroTile6.Text = "Редактировать \r\nприходную накладную";
            this.metroTile6.TileImage = global::AutoStorage.Properties.Resources.icons8_Edit_Property_64;
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile7, BunifuAnimatorNS.DecorationType.None);
            this.metroTile7.Location = new System.Drawing.Point(443, 123);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(203, 108);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile7.TabIndex = 7;
            this.metroTile7.Text = "Удалить \r\nприходную накладную";
            this.metroTile7.TileImage = global::AutoStorage.Properties.Resources.icons8_Delete_641;
            this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.UseTileImage = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile2, BunifuAnimatorNS.DecorationType.None);
            this.metroTile2.Location = new System.Drawing.Point(25, 9);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(203, 108);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Добавить \r\nрасходную накладную";
            this.metroTile2.TileImage = global::AutoStorage.Properties.Resources.icons8_Add_File_64;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile3, BunifuAnimatorNS.DecorationType.None);
            this.metroTile3.Location = new System.Drawing.Point(234, 9);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(203, 108);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Редактировать \r\nрасходную накладную";
            this.metroTile3.TileImage = global::AutoStorage.Properties.Resources.icons8_Edit_Property_64;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click_1);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile4, BunifuAnimatorNS.DecorationType.None);
            this.metroTile4.Location = new System.Drawing.Point(443, 9);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(203, 108);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "Удалить \r\nрасходную накладную";
            this.metroTile4.TileImage = global::AutoStorage.Properties.Resources.icons8_Delete_64;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.panelAnimator.SetDecoration(this.metroTile5, BunifuAnimatorNS.DecorationType.None);
            this.metroTile5.Location = new System.Drawing.Point(25, 237);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(412, 98);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "Просмотр всех накладных";
            this.metroTile5.TileImage = global::AutoStorage.Properties.Resources.icons8_Search_64;
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // backToManagersMenu
            // 
            this.backToManagersMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backToManagersMenu.BackgroundImage")));
            this.backToManagersMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAnimator.SetDecoration(this.backToManagersMenu, BunifuAnimatorNS.DecorationType.None);
            this.backToManagersMenu.FlatAppearance.BorderSize = 0;
            this.backToManagersMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToManagersMenu.Location = new System.Drawing.Point(10, 21);
            this.backToManagersMenu.Name = "backToManagersMenu";
            this.backToManagersMenu.Size = new System.Drawing.Size(32, 32);
            this.backToManagersMenu.TabIndex = 18;
            this.backToManagersMenu.UseVisualStyleBackColor = true;
            this.backToManagersMenu.Click += new System.EventHandler(this.backToManagersMenu_Click);
            // 
            // workWithBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 437);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.userLoginBox);
            this.Controls.Add(this.contentMenu);
            this.Controls.Add(this.backToManagersMenu);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "workWithBills";
            this.Text = "   Работа с накладными";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.workWithBills_FormClosing);
            this.Load += new System.EventHandler(this.workWithBills_Load);
            this.contentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToManagersMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel contentMenu;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userLoginBox;
    }
}