namespace AutoStorage
{
    partial class changeManagerPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeManagerPass));
            this.logInBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.passBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newPassBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backToHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logInBtn.BackColor = System.Drawing.Color.Teal;
            this.logInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInBtn.BorderRadius = 0;
            this.logInBtn.ButtonText = "Изменить пароль";
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
            this.logInBtn.Location = new System.Drawing.Point(23, 223);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Normalcolor = System.Drawing.Color.Teal;
            this.logInBtn.OnHovercolor = System.Drawing.Color.DeepSkyBlue;
            this.logInBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logInBtn.selected = false;
            this.logInBtn.Size = new System.Drawing.Size(308, 44);
            this.logInBtn.TabIndex = 39;
            this.logInBtn.Text = "Изменить пароль";
            this.logInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInBtn.Textcolor = System.Drawing.Color.White;
            this.logInBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
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
            this.passBox.Location = new System.Drawing.Point(23, 124);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(307, 33);
            this.passBox.TabIndex = 38;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.loginBox.Location = new System.Drawing.Point(23, 74);
            this.loginBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(307, 33);
            this.loginBox.TabIndex = 37;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newPassBox
            // 
            this.newPassBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPassBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassBox.HintForeColor = System.Drawing.Color.Empty;
            this.newPassBox.HintText = "Введите новый пароль";
            this.newPassBox.isPassword = false;
            this.newPassBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.newPassBox.LineIdleColor = System.Drawing.Color.Gray;
            this.newPassBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.newPassBox.LineThickness = 3;
            this.newPassBox.Location = new System.Drawing.Point(24, 165);
            this.newPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(307, 33);
            this.newPassBox.TabIndex = 38;
            this.newPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backToHomeBtn.BackgroundImage")));
            this.backToHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backToHomeBtn.FlatAppearance.BorderSize = 0;
            this.backToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHomeBtn.Location = new System.Drawing.Point(6, 21);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(32, 32);
            this.backToHomeBtn.TabIndex = 40;
            this.backToHomeBtn.UseVisualStyleBackColor = true;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // changeManagerPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 296);
            this.Controls.Add(this.backToHomeBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Name = "changeManagerPass";
            this.Text = "  Подтверждение пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changeManagerPass_FormClosing);
            this.Load += new System.EventHandler(this.changeManagerPass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton logInBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox loginBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newPassBox;
        private System.Windows.Forms.Button backToHomeBtn;
    }
}