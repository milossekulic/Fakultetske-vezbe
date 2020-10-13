namespace Drugi_cas_WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelGames = new System.Windows.Forms.Panel();
            this.btnOwnedG = new System.Windows.Forms.Button();
            this.btnShopG = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnOwnedA = new System.Windows.Forms.Button();
            this.btnShopA = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabAppShop = new System.Windows.Forms.TabPage();
            this.tabAppOwned = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.buttonTW = new System.Windows.Forms.Button();
            this.buttonIG = new System.Windows.Forms.Button();
            this.buttonFB = new System.Windows.Forms.Button();
            this.panelSide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelGames.SuspendLayout();
            this.panelApp.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(843, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(792, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 45);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Black;
            this.panelSide.Controls.Add(this.labelLogo);
            this.panelSide.Controls.Add(this.panelMenu);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(230, 550);
            this.panelSide.TabIndex = 2;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("OCR A Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(34, 23);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(157, 78);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Shop \r\n  App";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelUser);
            this.panelMenu.Controls.Add(this.btnSign);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.panelGames);
            this.panelMenu.Controls.Add(this.btnGames);
            this.panelMenu.Controls.Add(this.panelApp);
            this.panelMenu.Controls.Add(this.btnApplication);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 126);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 424);
            this.panelMenu.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(47, 354);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(138, 17);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Not Signed In";
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.White;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(50, 374);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(131, 29);
            this.btnSign.TabIndex = 6;
            this.btnSign.Text = "SIGN IN";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(0, 228);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(230, 36);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelGames
            // 
            this.panelGames.Controls.Add(this.btnOwnedG);
            this.panelGames.Controls.Add(this.btnShopG);
            this.panelGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGames.Location = new System.Drawing.Point(0, 168);
            this.panelGames.Name = "panelGames";
            this.panelGames.Size = new System.Drawing.Size(230, 60);
            this.panelGames.TabIndex = 4;
            this.panelGames.Visible = false;
            // 
            // btnOwnedG
            // 
            this.btnOwnedG.BackColor = System.Drawing.Color.Gray;
            this.btnOwnedG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOwnedG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnedG.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnedG.Location = new System.Drawing.Point(0, 30);
            this.btnOwnedG.Name = "btnOwnedG";
            this.btnOwnedG.Size = new System.Drawing.Size(230, 30);
            this.btnOwnedG.TabIndex = 2;
            this.btnOwnedG.Text = "OWNED";
            this.btnOwnedG.UseVisualStyleBackColor = false;
            // 
            // btnShopG
            // 
            this.btnShopG.BackColor = System.Drawing.Color.Gray;
            this.btnShopG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShopG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopG.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopG.Location = new System.Drawing.Point(0, 0);
            this.btnShopG.Name = "btnShopG";
            this.btnShopG.Size = new System.Drawing.Size(230, 30);
            this.btnShopG.TabIndex = 1;
            this.btnShopG.Text = "SHOP";
            this.btnShopG.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.White;
            this.btnGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Location = new System.Drawing.Point(0, 132);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(230, 36);
            this.btnGames.TabIndex = 3;
            this.btnGames.Text = "GAMES";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // panelApp
            // 
            this.panelApp.Controls.Add(this.btnOwnedA);
            this.panelApp.Controls.Add(this.btnShopA);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 72);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(230, 60);
            this.panelApp.TabIndex = 2;
            this.panelApp.Visible = false;
            // 
            // btnOwnedA
            // 
            this.btnOwnedA.BackColor = System.Drawing.Color.Gray;
            this.btnOwnedA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOwnedA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnedA.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnedA.Location = new System.Drawing.Point(0, 30);
            this.btnOwnedA.Name = "btnOwnedA";
            this.btnOwnedA.Size = new System.Drawing.Size(230, 30);
            this.btnOwnedA.TabIndex = 2;
            this.btnOwnedA.Text = "OWNED";
            this.btnOwnedA.UseVisualStyleBackColor = false;
            this.btnOwnedA.Click += new System.EventHandler(this.btnOwnedA_Click);
            // 
            // btnShopA
            // 
            this.btnShopA.BackColor = System.Drawing.Color.Gray;
            this.btnShopA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShopA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopA.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopA.Location = new System.Drawing.Point(0, 0);
            this.btnShopA.Name = "btnShopA";
            this.btnShopA.Size = new System.Drawing.Size(230, 30);
            this.btnShopA.TabIndex = 1;
            this.btnShopA.Text = "SHOP";
            this.btnShopA.UseVisualStyleBackColor = false;
            this.btnShopA.Click += new System.EventHandler(this.btnShopA_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.White;
            this.btnApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Location = new System.Drawing.Point(0, 36);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(230, 36);
            this.btnApplication.TabIndex = 1;
            this.btnApplication.Text = "APPLICATION";
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 36);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabHome);
            this.tabControlMain.Controls.Add(this.tabAppShop);
            this.tabControlMain.Controls.Add(this.tabAppOwned);
            this.tabControlMain.Controls.Add(this.tabInfo);
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlMain.Location = new System.Drawing.Point(236, 63);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(663, 487);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 3;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.SystemColors.Control;
            this.tabHome.Location = new System.Drawing.Point(4, 5);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(655, 478);
            this.tabHome.TabIndex = 0;
            // 
            // tabAppShop
            // 
            this.tabAppShop.BackColor = System.Drawing.SystemColors.Control;
            this.tabAppShop.Location = new System.Drawing.Point(4, 5);
            this.tabAppShop.Name = "tabAppShop";
            this.tabAppShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppShop.Size = new System.Drawing.Size(655, 478);
            this.tabAppShop.TabIndex = 1;
            // 
            // tabAppOwned
            // 
            this.tabAppOwned.BackColor = System.Drawing.SystemColors.Control;
            this.tabAppOwned.Location = new System.Drawing.Point(4, 5);
            this.tabAppOwned.Name = "tabAppOwned";
            this.tabAppOwned.Size = new System.Drawing.Size(655, 478);
            this.tabAppOwned.TabIndex = 2;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo.Controls.Add(this.buttonTW);
            this.tabInfo.Controls.Add(this.buttonIG);
            this.tabInfo.Controls.Add(this.buttonFB);
            this.tabInfo.Location = new System.Drawing.Point(4, 5);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(655, 478);
            this.tabInfo.TabIndex = 3;
            // 
            // buttonTW
            // 
            this.buttonTW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTW.BackgroundImage")));
            this.buttonTW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTW.FlatAppearance.BorderSize = 0;
            this.buttonTW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTW.Location = new System.Drawing.Point(292, 68);
            this.buttonTW.Name = "buttonTW";
            this.buttonTW.Size = new System.Drawing.Size(45, 45);
            this.buttonTW.TabIndex = 3;
            this.buttonTW.UseVisualStyleBackColor = true;
            // 
            // buttonIG
            // 
            this.buttonIG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIG.BackgroundImage")));
            this.buttonIG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIG.FlatAppearance.BorderSize = 0;
            this.buttonIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIG.Location = new System.Drawing.Point(486, 68);
            this.buttonIG.Name = "buttonIG";
            this.buttonIG.Size = new System.Drawing.Size(45, 45);
            this.buttonIG.TabIndex = 2;
            this.buttonIG.UseVisualStyleBackColor = true;
            // 
            // buttonFB
            // 
            this.buttonFB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFB.BackgroundImage")));
            this.buttonFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFB.FlatAppearance.BorderSize = 0;
            this.buttonFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFB.Location = new System.Drawing.Point(98, 68);
            this.buttonFB.Name = "buttonFB";
            this.buttonFB.Size = new System.Drawing.Size(45, 45);
            this.buttonFB.TabIndex = 1;
            this.buttonFB.UseVisualStyleBackColor = true;
            this.buttonFB.Click += new System.EventHandler(this.buttonFB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopApp";
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGames.ResumeLayout(false);
            this.panelApp.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Button btnOwnedA;
        private System.Windows.Forms.Button btnShopA;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Panel panelGames;
        private System.Windows.Forms.Button btnOwnedG;
        private System.Windows.Forms.Button btnShopG;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAppShop;
        private System.Windows.Forms.TabPage tabAppOwned;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Button buttonTW;
        private System.Windows.Forms.Button buttonIG;
        private System.Windows.Forms.Button buttonFB;
    }
}

