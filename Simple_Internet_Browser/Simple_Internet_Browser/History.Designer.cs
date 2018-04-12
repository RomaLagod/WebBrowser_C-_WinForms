namespace Simple_Internet_Browser
{
    partial class History_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Form));
            this.tv_timeLine = new System.Windows.Forms.TreeView();
            this.il_treeimages = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lb_sites = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_timeLine
            // 
            this.tv_timeLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_timeLine.ImageIndex = 0;
            this.tv_timeLine.ImageList = this.il_treeimages;
            this.tv_timeLine.Location = new System.Drawing.Point(0, 0);
            this.tv_timeLine.Name = "tv_timeLine";
            this.tv_timeLine.SelectedImageIndex = 0;
            this.tv_timeLine.Size = new System.Drawing.Size(121, 317);
            this.tv_timeLine.TabIndex = 0;
            this.tv_timeLine.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_timeLine_NodeMouseClick);
            // 
            // il_treeimages
            // 
            this.il_treeimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_treeimages.ImageStream")));
            this.il_treeimages.TransparentColor = System.Drawing.Color.Transparent;
            this.il_treeimages.Images.SetKeyName(0, "clock-history.ico");
            this.il_treeimages.Images.SetKeyName(1, "calendar-select-week.ico");
            this.il_treeimages.Images.SetKeyName(2, "stock_calendar-view-day.ico");
            this.il_treeimages.Images.SetKeyName(3, "arrow_right.ico");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 317);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lb_sites
            // 
            this.lb_sites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_sites.ContextMenuStrip = this.contextMenuStrip1;
            this.lb_sites.FormattingEnabled = true;
            this.lb_sites.HorizontalScrollbar = true;
            this.lb_sites.Location = new System.Drawing.Point(124, 0);
            this.lb_sites.Name = "lb_sites";
            this.lb_sites.Size = new System.Drawing.Size(304, 317);
            this.lb_sites.TabIndex = 2;
            this.lb_sites.DoubleClick += new System.EventHandler(this.lb_sites_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem,
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem,
            this.очиститиВсеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 70);
            // 
            // вилучитиПоточнийСайтЗІсторіїToolStripMenuItem
            // 
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem.Name = "вилучитиПоточнийСайтЗІсторіїToolStripMenuItem";
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem.Text = "Вилучити поточний сайт з історії";
            this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem.Click += new System.EventHandler(this.вилучитиПоточнийСайтЗІсторіїToolStripMenuItem_Click);
            // 
            // очиститиВсюПоточнуІсторіїToolStripMenuItem
            // 
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem.Name = "очиститиВсюПоточнуІсторіїToolStripMenuItem";
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem.Text = "Очистити всю поточну історії";
            this.очиститиВсюПоточнуІсторіїToolStripMenuItem.Click += new System.EventHandler(this.очиститиВсюПоточнуІсторіїToolStripMenuItem_Click);
            // 
            // очиститиВсеToolStripMenuItem
            // 
            this.очиститиВсеToolStripMenuItem.Name = "очиститиВсеToolStripMenuItem";
            this.очиститиВсеToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.очиститиВсеToolStripMenuItem.Text = "Очистити все";
            this.очиститиВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститиВсеToolStripMenuItem_Click);
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 317);
            this.Controls.Add(this.lb_sites);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tv_timeLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History_Form";
            this.Text = "History";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_timeLine;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox lb_sites;
        private System.Windows.Forms.ImageList il_treeimages;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вилучитиПоточнийСайтЗІсторіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиВсюПоточнуІсторіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиВсеToolStripMenuItem;
    }
}