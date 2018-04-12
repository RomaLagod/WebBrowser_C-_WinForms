using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Simple_Internet_Browser
{
    public partial class Form1 : Form
    {
        public TabControl tabControl = new TabControl();

        static string strAppData = Path.Combine(
                                   Environment.GetFolderPath(
                                   Environment.SpecialFolder.LocalApplicationData),
                                   "SimpleWebBrowser\\Settings\\SIB.Settings.xml");

        public BrowserSettings settings;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Завантаження параметрів
            settings = BrowserSettings.Load(strAppData);

            //Підказки
            SetToolTip();

            btn_GoBack.Enabled = false;
            btn_GoForward.Enabled = false;

            this.p_pages.Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;

            MyTabPage tabPage = new MyTabPage("New Page     ",this);
            tabControl.Controls.Add(tabPage);
            tabPage.webbrowser.Navigate(settings.Home);

            tabPage = new MyTabPage("+",this);
            tabControl.Controls.Add(tabPage);

            //tabControl.MouseDown += TabControlMouseDown;
            tabControl.MouseClick += tbMouseClick;

            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += TabControl_DrawItem;
            //tabControl.MouseEnter += TabControl_mouseEnter;
            tabControl.SelectedIndexChanged += OoSelectedIndexChanged;

            // Визначення розмірів і стану вікна
            Bounds = settings.WindowBounds;
            WindowState = settings.WindowState;
            flp_bookmarkStar.Visible = settings.ViewBookMarksStar;
            tsmi_bookmark2.Checked = flp_bookmarkStar.Visible;
            ts_star.Visible = settings.ViewBookMarks;
            tsmi_bookmark1.Checked = ts_star.Visible;

            //підключаємо введені адреса
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = settings.ManualUrls;
            cb_address.DataSource = bindingSource;
            //foreach (var item in settings.ManualUrls)
            //{
            //    cb_address.Items.Add(item);
            //}

            //завантажуємо панель закладок
            foreach (var item in settings.Favorites)
            {
                ToolStripButton tsb = new ToolStripButton();
                tsb.Text = item.Title;
                tsb.Tag = item.Url;
                tsb.ToolTipText = item.Url;
                tsb.Click += FavoriteButtonClick;
                ts_star.Items.Add(tsb);
            }

            //завантажуємо панель вибраних закладок
            foreach (var item in settings.FavoSupers)
            {
                Button button = new Button();
                button.Size = new Size(100, 100);
                Image img = item.image;
                button.BackgroundImage = img;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Tag = item.Url;
                ToolTip tt = new ToolTip();
                tt.SetToolTip(button, item.Url);
                button.TextAlign = ContentAlignment.TopCenter;
                button.Text = item.Title;
                button.Click += ButtonClick;
                button.ContextMenuStrip = cms_forButton;

                flp_bookmarkStar.Controls.Add(button);
            }
        }

        //Підказки
        public void SetToolTip()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btn_GoBack, "На сторінку назад");
            tt.SetToolTip(this.btn_GoForward, "На сторінку вперед");
            tt.SetToolTip(this.btn_reload, "Перевантажити сторінку");
            tt.SetToolTip(this.btn_home, "Повернутися на домашню сторінку");
            tt.SetToolTip(this.cb_address, "Рядок адреси");
            tt.SetToolTip(this.btn_run, "Перейти на сторінку");
            tt.SetToolTip(this.btn_add, "Додати сторіку на панель вибраного");
            tt.SetToolTip(this.tb_search, "Рядок пошуку");
            tt.SetToolTip(this.btn_google, "Пошук у Google)");
            tt.SetToolTip(this.btn_menu, "Меню");
        }

        private void TabControlMouseDown(object sender, MouseEventArgs e)
        {


        }

        private void OoSelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                btn_GoBack.Enabled = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoBack;
                btn_GoForward.Enabled = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoForward;
                if ((tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url != null)
                {
                    cb_address.Text = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString();
                }
                else
                {
                    cb_address.Text = "";
                }
            }
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //малюємо червоні хрестик на активній закладці
            if (e.Index == tabControl.SelectedIndex && e.Index < tabControl.TabCount-1)
            {
                Rectangle r = e.Bounds;
                r.Offset(5, 2);
                int widthRect = r.Width - 2;
                string title = tabControl.TabPages[e.Index].Text;
                e.Graphics.DrawString(title, e.Font, new SolidBrush(Color.Black), r.X, r.Y);
                //if (e.Index == tabControl.TabPages.Count - 1) return;
                Image close = il_workpanel.Images[9];
                Image closeSmall = new Bitmap(close, new Size(14, 14));

                e.Graphics.DrawImage(closeSmall, r.X - closeSmall.Width + widthRect - 5, r.Y);
            }
            //малюємо чорні хрестики на неактивних закладках
            else if (e.Index < tabControl.TabCount - 1)
            {
                Rectangle r = e.Bounds;
                r.Offset(5, 2);
                int widthRect = r.Width - 2;
                string title = tabControl.TabPages[e.Index].Text;
                e.Graphics.DrawString(title, e.Font, new SolidBrush(Color.Black), r.X, r.Y);
                //if (e.Index == tabControl.TabPages.Count - 1) return;
                Image close = il_workpanel.Images[11];
                Image closeSmall = new Bitmap(close, new Size(14, 14));

                e.Graphics.DrawImage(closeSmall, r.X - closeSmall.Width + widthRect - 5, r.Y);
            }

            //Малюємо плюсик на останній вкладці
            if (e.Index == tabControl.TabCount-1)
            {
                Rectangle r = e.Bounds;
                r.Offset(-7, 3);
                int widthRect = r.Width - 2;
                string title = tabControl.TabPages[e.Index].Text;
                //e.Graphics.DrawString(title, e.Font, new SolidBrush(Color.Black), r.X, r.Y);
                Image close = il_workpanel.Images[12];
                Image closeSmall = new Bitmap(close, new Size(14, 14));

                e.Graphics.DrawImage(closeSmall, r.X - closeSmall.Width + widthRect - 5, r.Y);
            }

        }

        private void tbMouseClick(object sender, MouseEventArgs e)
        {            
            if (tabControl.SelectedIndex == tabControl.TabPages.Count - 1)
            {
                MyTabPage current = (MyTabPage) tabControl.TabPages[tabControl.SelectedIndex];
                current.Text = "New Page     ";
                current.webbrowser.Navigate(settings.Home);

                MyTabPage newTabPage = new MyTabPage("+",this);
                tabControl.TabPages.Add(newTabPage);
            }

            Rectangle tabRec = tabControl.GetTabRect(tabControl.SelectedIndex);
            tabRec.Offset(tabRec.Width - 15, 2);
            tabRec.Width = 10;
            tabRec.Height = 10;
            if (tabRec.Contains(e.X, e.Y))
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
            }

            //Робить знімок вікна браузера

            Bitmap bitmap = new Bitmap(500, 500);
            Rectangle bitmapRect = new Rectangle(0, 0, 500, 500);
            (tabControl.SelectedTab.Controls[0] as WebBrowser).DrawToBitmap(bitmap, bitmapRect);
            Image origImage = bitmap;
            origImage.Tag = cb_address.Text;

            tabControl.SelectedTab.DoDragDrop(origImage, DragDropEffects.Copy);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btn_menu, btn_menu.Width - contextMenuStrip1.Width, btn_menu.Size.Height);
        }

        private void NewPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTabPage newpage = (MyTabPage)tabControl.TabPages[tabControl.TabPages.Count-1];
            newpage.Text = "New Page     ";            
            MyTabPage newTabPage = new MyTabPage("+",this);
            tabControl.TabPages.Add(newTabPage);
        }

        private void DeletePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                cb_address.Text = settings.Home;

                (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url = new Uri(cb_address.Text);
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            Go(cb_address.Text);
        }

        private void cb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_run.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Панель вибраного в топі
        private void toolStripButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripButton)
            {
                if ((sender as ToolStripButton).Checked == true)
                {
                    flp_bookmarkStar.Visible = true;
                }
                else
                {
                    flp_bookmarkStar.Visible = false;
                }

            }
        }

        //Reload && Stop
        private void btn_reload_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                if (btn_reload.ImageIndex == 2)
                {
                    (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Refresh();
                }
                else
                {
                    (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Stop();
                }
            }
        }

        //Navigate Back
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                (tabControl.SelectedTab.Controls[0] as MyWebBrowser).GoBack();
            }
        }

        //Navigate Forward
        private void btn_GoForward_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                (tabControl.SelectedTab.Controls[0] as MyWebBrowser).GoForward();
            }
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            string googleSearchString = @"https://www.google.com.ua/search?q=" + tb_search.Text; //+ " &sourceid=chrome&ie=UTF-8";

            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Navigate(googleSearchString);
            }
        }

        //On Enter on TextEdit
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_google.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void flp_bookmarkStar_DragDrop(object sender, DragEventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(100, 100);
            Image img = ((Bitmap)e.Data.GetData(DataFormats.Bitmap));
            button.BackgroundImage = img;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.Tag = img.Tag;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(button, img.Tag.ToString());
            button.TextAlign = ContentAlignment.TopCenter;
            button.Text = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).DocumentTitle;
            button.Click += ButtonClick;
            button.ContextMenuStrip = cms_forButton;

            FavoSuperPanel favoSuperPanel = new FavoSuperPanel
            {
                Title = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).DocumentTitle,
                Url = button.Tag.ToString(),
                image = new Bitmap(img)
            };

            settings.FavoSupers.Add(favoSuperPanel);

            flp_bookmarkStar.Controls.Add(button);
        }

        //Натиснута кнопка на панелі зліва
        private void ButtonClick(object sender, EventArgs e)
        {
            cb_address.Text = (sender as Button).Tag.ToString();
            btn_run.PerformClick();
        }

        private void flp_bookmarkStar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ClearAll_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flp_bookmarkStar.Controls.Clear();
        }

        private void DeleteCurr_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cms_forButton.SourceControl is Button)
            {
                flp_bookmarkStar.Controls.Remove(cms_forButton.SourceControl);
            }
        }

        private void cb_address_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Go(cb_address.SelectedItem.ToString());           
        }

        //Вибране на панель інструментів
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                Favorite favorite = new Favorite
                {
                    Title = tabControl.SelectedTab.Text,
                    Url = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString()
                };

                settings.Favorites.Add(favorite);

                ToolStripButton button = new ToolStripButton();
                button.Text = tabControl.SelectedTab.Text;
                button.Tag = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url;
                button.ToolTipText = (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString();
                button.MouseDown += FavoriteMouseDown;
                button.Click += FavoriteButtonClick;
                ts_star.Items.Add(button);
            }
        }

        //Видаляє обрану закладку правою кнопкою мишки
        private void FavoriteMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is ToolStripButton)
                {
                    ts_star.Items.Remove((sender as ToolStripButton));
                }
            }
        }

        //Перехід по ссилці від обраного
        private void FavoriteButtonClick(object sender, EventArgs e)
        {
            Go((sender as ToolStripButton).Tag.ToString());
        }

        //Окремий метод для всіх переходів
        private void Go(string address)
        {
            if (tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                if (address != "")
                {
                    string temp_url = address;
                    if (!temp_url.Contains("http"))
                    {
                        if (!temp_url.Contains("https"))
                        {
                            temp_url = temp_url.Insert(0, "http://");
                            cb_address.Text = temp_url;
                        }
                    }

                    Uri uri_address = new Uri(temp_url);

                    (tabControl.SelectedTab.Controls[0] as MyWebBrowser).Navigate(uri_address);
                }
                else
                {
                    btn_home.PerformClick();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.WindowState = WindowState;
            settings.WindowBounds = WindowState == FormWindowState.Normal ? Bounds : RestoreBounds;
            settings.ViewBookMarks = ts_star.Visible;
            settings.ViewBookMarksStar = flp_bookmarkStar.Visible;

            settings.Save(strAppData);
        }

        private void tsmi_HomePage_Click(object sender, EventArgs e)
        {
            settings.Home = Microsoft.VisualBasic.Interaction.InputBox("Введіть нову домашню сторінку:", "Зміна домашньої сторінки", settings.Home);
        }

        private void панельОбране1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tsmi_bookmark1.CheckState == CheckState.Checked)
            {
                ts_star.Visible = false;
                tsmi_bookmark1.CheckState = CheckState.Unchecked;
            }
            else
            {
                ts_star.Visible = true;
                tsmi_bookmark1.CheckState = CheckState.Checked;
            }
        }

        private void tsmi_bookmark2_Click(object sender, EventArgs e)
        {
            if (tsmi_bookmark2.CheckState == CheckState.Checked)
            {
                flp_bookmarkStar.Visible = false;
                tsmi_bookmark2.CheckState = CheckState.Unchecked;
            }
            else
            {
                flp_bookmarkStar.Visible = true;
                tsmi_bookmark2.CheckState = CheckState.Checked;
            }
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_Form hf = new History_Form();
            History history =  hf.ShowDialog(settings.Historys);
            if (history != null)
            {
                Go(history.Url);
            }
        }
    }

    //Браузер-----------------------------------------------------------------------------------
    class MyWebBrowser:WebBrowser
    {
        public MyWebBrowser() : base()
        {
            this.Dock = DockStyle.Fill;
            //Ігноруємо помилки сценаріїв
            this.ScriptErrorsSuppressed = true;
        }
    }

    //рядок стану-------------------------------------------------------------------------------
    class MyStatusStrip : StatusStrip
    {
        public MyStatusStrip() : base()
        {
            ToolStripStatusLabel statlbl = new ToolStripStatusLabel();
            statlbl.TextAlign = ContentAlignment.MiddleLeft;
            statlbl.Spring = true;
            this.Items.Add(statlbl);

            ToolStripProgressBar statprog = new ToolStripProgressBar();
            statprog.Visible = false;
            this.Items.Add(statprog);
        }
    }
    //Закладка----------------------------------------------------------------------------------
    class MyTabPage:TabPage
    {
        public MyWebBrowser webbrowser { get; }
        public MyStatusStrip statusStrip { get; }

        private Form1 _form;

        public MyWebBrowser MyWebBrowser
        {
            get { return webbrowser; }
        }

        public MyTabPage(string text, Form1 form1) : base(text)
        {
            webbrowser = new MyWebBrowser();
            this.Controls.Add(webbrowser);

            statusStrip = new MyStatusStrip();
            this.Controls.Add(statusStrip);

            _form = form1;

            webbrowser.DocumentTitleChanged += OnDocumentTitleChanged;
            webbrowser.StatusTextChanged += OnStatusTextChanged;
            webbrowser.ProgressChanged += OnProgressChanged;
            webbrowser.Navigating += OnNavigating;
            webbrowser.Navigated += OnNavigated;
            webbrowser.CanGoBackChanged += OnCanGoBackChanged;
            webbrowser.CanGoForwardChanged += OnCanGoForwardChanged;            
        }

        private void OnCanGoBackChanged(object sender, EventArgs e)
        {
            if (_form.tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                _form.btn_GoBack.Enabled = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoBack;
                _form.btn_GoForward.Enabled = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoForward;
            }
        }

        private void OnCanGoForwardChanged(object sender, EventArgs e)
        {
            if (_form.tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                _form.btn_GoBack.Enabled = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoBack;
                _form.btn_GoForward.Enabled = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).CanGoForward;
            }
        }

        private void OnNavigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            _form.btn_reload.ImageIndex = 11;            
        }

        private void OnNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            _form.btn_reload.ImageIndex = 2;
            if (_form.tabControl.SelectedTab.Controls[0] is MyWebBrowser)
            {
                //до історії
                History history = new History
                {
                    Url = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString(),
                    Title = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).DocumentTitle,
                    dateTime = DateTime.Now
                };
                _form.settings.Historys.Add(history);

                //переходи
                _form.settings.ManualUrls.Add((_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString());
                _form.cb_address.DataSource = null;
                _form.cb_address.DataSource = _form.settings.ManualUrls;
                //_form.cb_address.Items.Add((_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString());

                //адресний рядок
                _form.cb_address.Text = (_form.tabControl.SelectedTab.Controls[0] as MyWebBrowser).Url.ToString();

            }
        }

        private void OnProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if ((statusStrip.Items[1] as ToolStripProgressBar).Visible = (e.CurrentProgress != e.MaximumProgress))
            {
                long curr_emaxp = e.MaximumProgress <= 0 ? 1 : e.MaximumProgress;
                long curr_eminp = e.CurrentProgress <= 0 ? 1 : e.CurrentProgress;
                curr_emaxp = curr_emaxp > 100 ? 100 : curr_emaxp;
                curr_eminp = curr_eminp > 100 ? 100 : curr_eminp;
                (statusStrip.Items[1] as ToolStripProgressBar).Value = (int)(100 * curr_eminp /
                curr_emaxp);
            }

        }

        private void OnStatusTextChanged(object sender, EventArgs e)
        {
            (statusStrip.Items[0] as ToolStripStatusLabel).Text = (sender as MyWebBrowser).StatusText;
        }

        private void OnDocumentTitleChanged(object sender, EventArgs e)
        {
            if (sender is MyWebBrowser)
            {
                string title = (sender as MyWebBrowser).DocumentTitle;               
                title = title.Length >= 21 ? title.Remove(21, title.Length - 21) : title;

                ((sender as MyWebBrowser).Parent as TabPage).Text = title + "     ";
            }
        }

    }

    //Класс Faforite----------------------------------------------------------------------------
    public class Favorite : IComparable<Favorite>
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public Favorite()
        { }

        public Favorite(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public int CompareTo(Favorite other)
        {
            return Title.CompareTo(other.Title);
        }
    }

    //class FavoSuperPanel------------------------------------------------------
    public class FavoSuperPanel : IComparable<FavoSuperPanel>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        [XmlIgnore]
        public Bitmap image { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("image")]
        public byte[] LargeIconSerialized
        {
            get
            { // serialize
                if (image == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    //image.Save(ms,ImageFormat.Jpeg);
                    // return ms.ToArray();

                    ImageConverter converter = new ImageConverter();
                    return (byte[])converter.ConvertTo(image, typeof(byte[]));
                }
            }
            set
            { // deserialize
                if (value == null)
                {
                    image = null;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        image = new Bitmap(ms);
                    }
                }
            }
        }

        public FavoSuperPanel()
        {
        }

        public FavoSuperPanel(string title, string url, Image image)
        {
            Title = title;
            Url = url;
            this.image =  new Bitmap(image) ;
        }

        public int CompareTo(FavoSuperPanel other)
        {
            return Title.CompareTo(other.Title);
        }
    }
    
    //Класс ІСТОРІЯ-------------------------------------------------------------
    public class History : IComparable<History>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime dateTime { get; set; }

        public History()
        {

        }

        public History(string title, string url, DateTime dateTime)
        {
            Title = title;
            Url = url;
            this.dateTime = dateTime;
        }

        public int CompareTo(History other)
        {
            return dateTime.CompareTo(other.dateTime);
        }
    }

    //Класс BrowserSettings-----------------------------------------------------
    public class BrowserSettings
    {
        //Параметри по замівчуванню
        public Rectangle WindowBounds = new Rectangle(0, 0, 800, 600);
        public FormWindowState WindowState = FormWindowState.Normal;

        public string Home = @"https://www.google.com.ua";
        public bool ViewBookMarksStar = false;
        public bool ViewBookMarks = true;

        //Список вибраного, супер панелі, та введених в адресний рядок URL-адресів, Історія
        public List<Favorite> Favorites = new List<Favorite>();
        public List<FavoSuperPanel> FavoSupers = new List<FavoSuperPanel>();
        public List<string> ManualUrls = new List<string>();
        public List<History> Historys = new List<History>();

        //Завантаження параметрів із файла
        public static BrowserSettings Load (string strAppData)
        {
            StreamReader sr;
            BrowserSettings settings;
            XmlSerializer xmlser = new XmlSerializer(typeof(BrowserSettings));

            try
            {
                sr = new StreamReader(strAppData);
                settings = (BrowserSettings)xmlser.Deserialize(sr);
                sr.Close();                
            }
            catch 
            {
                settings = new BrowserSettings();
            }
            return settings;
        }

        //Збереження параметрів у файл
        public void Save(string strAppData)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(strAppData));
            StreamWriter sw = new StreamWriter(strAppData);
            XmlSerializer xmlser = new XmlSerializer(GetType());
            xmlser.Serialize(sw, this);
            sw.Close();
        }
    }
}