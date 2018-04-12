namespace Simple_Internet_Browser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.il_workpanel = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_HomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_bookmark1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_bookmark2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_address = new System.Windows.Forms.ComboBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_google = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_GoForward = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.ts_star = new System.Windows.Forms.ToolStrip();
            this.tsb_bookmarkStar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_forButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteCurr_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_bookmarkStar = new System.Windows.Forms.FlowLayoutPanel();
            this.cms_flow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearAll_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p_pages = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ts_star.SuspendLayout();
            this.cms_forButton.SuspendLayout();
            this.cms_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // il_workpanel
            // 
            this.il_workpanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_workpanel.ImageStream")));
            this.il_workpanel.TransparentColor = System.Drawing.Color.Transparent;
            this.il_workpanel.Images.SetKeyName(0, "monotone_arrow_left.ico");
            this.il_workpanel.Images.SetKeyName(1, "monotone_arrow_right_next.ico");
            this.il_workpanel.Images.SetKeyName(2, "0613_01759.ico");
            this.il_workpanel.Images.SetKeyName(3, "Black_Home.ico");
            this.il_workpanel.Images.SetKeyName(4, "arrow_left.ico");
            this.il_workpanel.Images.SetKeyName(5, "star (3).ico");
            this.il_workpanel.Images.SetKeyName(6, "google-logo-square.ico");
            this.il_workpanel.Images.SetKeyName(7, "grid-small-dot (1).ico");
            this.il_workpanel.Images.SetKeyName(8, "1297_04356.ico");
            this.il_workpanel.Images.SetKeyName(9, "0502_01088.ico");
            this.il_workpanel.Images.SetKeyName(10, "0731_02087.ico");
            this.il_workpanel.Images.SetKeyName(11, "Gnome-Window-Close-32.ico");
            this.il_workpanel.Images.SetKeyName(12, "2339_09712.ico");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPageToolStripMenuItem,
            this.DeletePageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmi_HomePage,
            this.HistoryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsmi_bookmark1,
            this.tsmi_bookmark2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 154);
            // 
            // NewPageToolStripMenuItem
            // 
            this.NewPageToolStripMenuItem.Image = global::Simple_Internet_Browser.Properties.Resources._000_206113825289482096;
            this.NewPageToolStripMenuItem.Name = "NewPageToolStripMenuItem";
            this.NewPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewPageToolStripMenuItem.Text = "Створити вклдадку";
            this.NewPageToolStripMenuItem.Click += new System.EventHandler(this.NewPageToolStripMenuItem_Click);
            // 
            // DeletePageToolStripMenuItem
            // 
            this.DeletePageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeletePageToolStripMenuItem.Image")));
            this.DeletePageToolStripMenuItem.Name = "DeletePageToolStripMenuItem";
            this.DeletePageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeletePageToolStripMenuItem.Text = "Видалити вкладку";
            this.DeletePageToolStripMenuItem.Click += new System.EventHandler(this.DeletePageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_HomePage
            // 
            this.tsmi_HomePage.Name = "tsmi_HomePage";
            this.tsmi_HomePage.Size = new System.Drawing.Size(180, 22);
            this.tsmi_HomePage.Text = "Домашня сторінка";
            this.tsmi_HomePage.Click += new System.EventHandler(this.tsmi_HomePage_Click);
            // 
            // HistoryToolStripMenuItem
            // 
            this.HistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HistoryToolStripMenuItem.Image")));
            this.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            this.HistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HistoryToolStripMenuItem.Text = "Історія";
            this.HistoryToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_bookmark1
            // 
            this.tsmi_bookmark1.Checked = true;
            this.tsmi_bookmark1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_bookmark1.Name = "tsmi_bookmark1";
            this.tsmi_bookmark1.Size = new System.Drawing.Size(180, 22);
            this.tsmi_bookmark1.Text = "Панель обране №1";
            this.tsmi_bookmark1.Click += new System.EventHandler(this.панельОбране1ToolStripMenuItem_Click);
            // 
            // tsmi_bookmark2
            // 
            this.tsmi_bookmark2.Name = "tsmi_bookmark2";
            this.tsmi_bookmark2.Size = new System.Drawing.Size(180, 22);
            this.tsmi_bookmark2.Text = "Панель обране №2";
            this.tsmi_bookmark2.Click += new System.EventHandler(this.tsmi_bookmark2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_address);
            this.panel2.Controls.Add(this.btn_run);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Controls.Add(this.btn_google);
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Controls.Add(this.btn_reload);
            this.panel2.Controls.Add(this.btn_GoForward);
            this.panel2.Controls.Add(this.btn_GoBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(557, 25);
            this.panel2.TabIndex = 11;
            // 
            // cb_address
            // 
            this.cb_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_address.FormattingEnabled = true;
            this.cb_address.Location = new System.Drawing.Point(101, 1);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(253, 21);
            this.cb_address.TabIndex = 19;
            this.cb_address.SelectionChangeCommitted += new System.EventHandler(this.cb_address_SelectionChangeCommitted);
            this.cb_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_address_KeyDown);
            // 
            // btn_run
            // 
            this.btn_run.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_run.ImageIndex = 4;
            this.btn_run.ImageList = this.il_workpanel;
            this.btn_run.Location = new System.Drawing.Point(354, 1);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(25, 21);
            this.btn_run.TabIndex = 18;
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_home.ImageIndex = 3;
            this.btn_home.ImageList = this.il_workpanel;
            this.btn_home.Location = new System.Drawing.Point(76, 1);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(25, 21);
            this.btn_home.TabIndex = 17;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.ImageIndex = 5;
            this.btn_add.ImageList = this.il_workpanel;
            this.btn_add.Location = new System.Drawing.Point(379, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(25, 21);
            this.btn_add.TabIndex = 16;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_search
            // 
            this.tb_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_search.Location = new System.Drawing.Point(404, 1);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 15;
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // btn_google
            // 
            this.btn_google.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_google.ImageIndex = 6;
            this.btn_google.ImageList = this.il_workpanel;
            this.btn_google.Location = new System.Drawing.Point(504, 1);
            this.btn_google.Name = "btn_google";
            this.btn_google.Size = new System.Drawing.Size(25, 21);
            this.btn_google.TabIndex = 14;
            this.btn_google.UseVisualStyleBackColor = true;
            this.btn_google.Click += new System.EventHandler(this.btn_google_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_menu.ImageIndex = 7;
            this.btn_menu.ImageList = this.il_workpanel;
            this.btn_menu.Location = new System.Drawing.Point(529, 1);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(25, 21);
            this.btn_menu.TabIndex = 13;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reload.ImageIndex = 2;
            this.btn_reload.ImageList = this.il_workpanel;
            this.btn_reload.Location = new System.Drawing.Point(51, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(25, 21);
            this.btn_reload.TabIndex = 12;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_GoForward
            // 
            this.btn_GoForward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GoForward.ImageIndex = 1;
            this.btn_GoForward.ImageList = this.il_workpanel;
            this.btn_GoForward.Location = new System.Drawing.Point(26, 1);
            this.btn_GoForward.Name = "btn_GoForward";
            this.btn_GoForward.Size = new System.Drawing.Size(25, 21);
            this.btn_GoForward.TabIndex = 11;
            this.btn_GoForward.UseVisualStyleBackColor = true;
            this.btn_GoForward.Click += new System.EventHandler(this.btn_GoForward_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GoBack.ImageIndex = 0;
            this.btn_GoBack.ImageList = this.il_workpanel;
            this.btn_GoBack.Location = new System.Drawing.Point(1, 1);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(25, 21);
            this.btn_GoBack.TabIndex = 10;
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // ts_star
            // 
            this.ts_star.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_bookmarkStar,
            this.toolStripSeparator1});
            this.ts_star.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_star.Location = new System.Drawing.Point(0, 25);
            this.ts_star.Name = "ts_star";
            this.ts_star.Size = new System.Drawing.Size(557, 23);
            this.ts_star.TabIndex = 12;
            this.ts_star.Text = "toolStrip1";
            // 
            // tsb_bookmarkStar
            // 
            this.tsb_bookmarkStar.CheckOnClick = true;
            this.tsb_bookmarkStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_bookmarkStar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_bookmarkStar.Image")));
            this.tsb_bookmarkStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_bookmarkStar.Name = "tsb_bookmarkStar";
            this.tsb_bookmarkStar.Size = new System.Drawing.Size(23, 20);
            this.tsb_bookmarkStar.Text = "toolStripButton1";
            this.tsb_bookmarkStar.ToolTipText = "Обране";
            this.tsb_bookmarkStar.CheckedChanged += new System.EventHandler(this.toolStripButton1_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // cms_forButton
            // 
            this.cms_forButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteCurr_ToolStripMenuItem});
            this.cms_forButton.Name = "cms_forButton";
            this.cms_forButton.Size = new System.Drawing.Size(178, 26);
            // 
            // DeleteCurr_ToolStripMenuItem
            // 
            this.DeleteCurr_ToolStripMenuItem.Name = "DeleteCurr_ToolStripMenuItem";
            this.DeleteCurr_ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.DeleteCurr_ToolStripMenuItem.Text = "Видалити закладку";
            this.DeleteCurr_ToolStripMenuItem.Click += new System.EventHandler(this.DeleteCurr_ToolStripMenuItem_Click);
            // 
            // flp_bookmarkStar
            // 
            this.flp_bookmarkStar.AllowDrop = true;
            this.flp_bookmarkStar.AutoScroll = true;
            this.flp_bookmarkStar.ContextMenuStrip = this.cms_flow;
            this.flp_bookmarkStar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_bookmarkStar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_bookmarkStar.Location = new System.Drawing.Point(0, 48);
            this.flp_bookmarkStar.Name = "flp_bookmarkStar";
            this.flp_bookmarkStar.Size = new System.Drawing.Size(123, 274);
            this.flp_bookmarkStar.TabIndex = 14;
            this.flp_bookmarkStar.Visible = false;
            this.flp_bookmarkStar.WrapContents = false;
            this.flp_bookmarkStar.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_bookmarkStar_DragDrop);
            this.flp_bookmarkStar.DragEnter += new System.Windows.Forms.DragEventHandler(this.flp_bookmarkStar_DragEnter);
            // 
            // cms_flow
            // 
            this.cms_flow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAll_ToolStripMenuItem});
            this.cms_flow.Name = "cms_flow";
            this.cms_flow.Size = new System.Drawing.Size(149, 26);
            // 
            // ClearAll_ToolStripMenuItem
            // 
            this.ClearAll_ToolStripMenuItem.Name = "ClearAll_ToolStripMenuItem";
            this.ClearAll_ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ClearAll_ToolStripMenuItem.Text = "Очистити все";
            this.ClearAll_ToolStripMenuItem.Click += new System.EventHandler(this.ClearAll_ToolStripMenuItem_Click);
            // 
            // p_pages
            // 
            this.p_pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_pages.Location = new System.Drawing.Point(123, 48);
            this.p_pages.Name = "p_pages";
            this.p_pages.Size = new System.Drawing.Size(434, 274);
            this.p_pages.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 322);
            this.Controls.Add(this.p_pages);
            this.Controls.Add(this.flp_bookmarkStar);
            this.Controls.Add(this.ts_star);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Internet Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ts_star.ResumeLayout(false);
            this.ts_star.PerformLayout();
            this.cms_forButton.ResumeLayout(false);
            this.cms_flow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList il_workpanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewPageToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_google;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.ToolStrip ts_star;
        private System.Windows.Forms.ToolStripMenuItem DeletePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HistoryToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flp_bookmarkStar;
        private System.Windows.Forms.Panel p_pages;
        private System.Windows.Forms.ToolStripButton tsb_bookmarkStar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.Button btn_reload;
        internal System.Windows.Forms.Button btn_GoForward;
        internal System.Windows.Forms.Button btn_GoBack;
        internal System.Windows.Forms.ComboBox cb_address;
        private System.Windows.Forms.ContextMenuStrip cms_flow;
        private System.Windows.Forms.ToolStripMenuItem ClearAll_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_forButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteCurr_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_HomePage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_bookmark1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_bookmark2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}

