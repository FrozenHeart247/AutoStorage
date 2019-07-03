namespace AutoStorage
{
    partial class authorizationManagers
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorizationManagers));
            this.loginBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logInBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backtoRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBox.HintForeColor = System.Drawing.Color.Empty;
            this.loginBox.HintText = "Введите логин";
            this.loginBox.isPassword = false;
            this.loginBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.loginBox.LineIdleColor = System.Drawing.Color.Gray;
            this.loginBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.loginBox.LineThickness = 3;
            this.loginBox.Location = new System.Drawing.Point(24, 80);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(307, 33);
            this.loginBox.TabIndex = 0;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginBox_KeyUp);
            // 
            // passBox
            // 
            this.passBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passBox.HintForeColor = System.Drawing.Color.Empty;
            this.passBox.HintText = "Введите пароль";
            this.passBox.isPassword = false;
            this.passBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passBox.LineIdleColor = System.Drawing.Color.Gray;
            this.passBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passBox.LineThickness = 3;
            this.passBox.Location = new System.Drawing.Point(24, 130);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(307, 33);
            this.passBox.TabIndex = 1;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyUp);
            // 
            // logInBtn
            // 
            this.logInBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logInBtn.BackColor = System.Drawing.Color.Teal;
            this.logInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInBtn.BorderRadius = 0;
            this.logInBtn.ButtonText = "Авторизоваться";
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logInBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logInBtn.Iconimage = null;
            this.logInBtn.Iconimage_right = null;
            this.logInBtn.Iconimage_right_Selected = null;
            this.logInBtn.Iconimage_Selected = null;
            this.logInBtn.IconMarginLeft = 0;
            this.logInBtn.IconMarginRight = 0;
            this.logInBtn.IconRightVisible = true;
            this.logInBtn.IconRightZoom = 0D;
            this.logInBtn.IconVisible = true;
            this.logInBtn.IconZoom = 90D;
            this.logInBtn.IsTab = false;
            this.logInBtn.Location = new System.Drawing.Point(24, 183);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Normalcolor = System.Drawing.Color.Teal;
            this.logInBtn.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.logInBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logInBtn.selected = false;
            this.logInBtn.Size = new System.Drawing.Size(308, 44);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "Авторизоваться";
            this.logInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInBtn.Textcolor = System.Drawing.Color.White;
            this.logInBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // backtoRegistration
            // 
            this.backtoRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtoRegistration.BackgroundImage")));
            this.backtoRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backtoRegistration.FlatAppearance.BorderSize = 0;
            this.backtoRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoRegistration.Location = new System.Drawing.Point(7, 21);
            this.backtoRegistration.Name = "backtoRegistration";
            this.backtoRegistration.Size = new System.Drawing.Size(32, 32);
            this.backtoRegistration.TabIndex = 36;
            this.backtoRegistration.UseVisualStyleBackColor = true;
            this.backtoRegistration.Click += new System.EventHandler(this.backtoRegistration_Click);
            // 
            // authorizationManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 245);
            this.Controls.Add(this.backtoRegistration);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Name = "authorizationManagers";
            this.Text = "  Авторизация менеджера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.authorizationManagers_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox loginBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passBox;
        private Bunifu.Framework.UI.BunifuFlatButton logInBtn;
        private System.Windows.Forms.Button backtoRegistration;

    }
}

