using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Internet_Browser
{
    public partial class History_Form : Form
    {
        private List<History> _history;
        History dblSelect = null;

        public History_Form()
        {
            InitializeComponent();
        }

       public History ShowDialog(List<History> history)
       {
            _history = history;
            CreateRootNodes();
            base.ShowDialog();
            return dblSelect;
       }

        //Створює закладки
        private void CreateRootNodes()
        {
            TreeNode node_root = new TreeNode("Вся історія");
            node_root.ImageIndex = 0;
            node_root.SelectedImageIndex = 3;
            this.tv_timeLine.Nodes.Add(node_root);


            node_root = new TreeNode("Недавно відвідані");
            node_root.ImageIndex = 0;
            node_root.SelectedImageIndex = 3;
            this.tv_timeLine.Nodes.Add(node_root);

            node_root = new TreeNode("Сьогодні");
            node_root.ImageIndex = 0;
            node_root.SelectedImageIndex = 3;
            this.tv_timeLine.Nodes.Add(node_root);

            node_root = new TreeNode("За тиждень");
            node_root.ImageIndex = 0;
            node_root.SelectedImageIndex = 3;
            this.tv_timeLine.Nodes.Add(node_root);

            node_root = new TreeNode("За місяць");
            node_root.ImageIndex = 0;
            node_root.SelectedImageIndex = 3;
            this.tv_timeLine.Nodes.Add(node_root);

            ShowAllHistory();
        }

        private void ShowAllHistory()
        {
            DateTime curr = _history.OrderByDescending(x => x.dateTime).First().dateTime.AddDays(1);
            List<DateTime> indate = new List<DateTime>();
            this.tv_timeLine.Nodes[0].Nodes.Clear();

            foreach (var item in _history.OrderByDescending(x => x.dateTime))
            {
                string date = @"-------------------- [" + item.dateTime.Date.ToShortDateString() + "] --------------------";
                string temp = @"[" + item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;

                if (curr.Date > item.dateTime.Date)
                {
                    curr = curr.Date.AddDays(-1);
                    if (!indate.Contains(item.dateTime.Date))
                    {
                        indate.Add(item.dateTime.Date);
                        lb_sites.Items.Add("");
                        lb_sites.Items.Add(date);
                        lb_sites.Items.Add("");

                        TreeNode node_date = new TreeNode(item.dateTime.Date.ToShortDateString());
                        node_date.ImageIndex = 2;
                        node_date.SelectedImageIndex = 3;
                        this.tv_timeLine.Nodes[0].Nodes.Add(node_date);
                    }
                }

                if (curr.Date == item.dateTime.Date)
                {
                    lb_sites.Items.Add(temp);
                }
            }
        }

        private void tv_timeLine_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lb_sites.Items.Clear();
                switch (e.Node.Text)
                {
                    case "Вся історія":
                        ShowAllHistory();
                        break;
                    case "Недавно відвідані":
                        foreach (var item in _history.OrderByDescending(x => x.dateTime).Take(10))
                        {
                            string temp = @"[" + item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;
                            lb_sites.Items.Add(temp);
                        }
                        break;
                    case "Сьогодні":
                        foreach (var item in _history)
                        {                            
                            if(item.dateTime.ToShortDateString() == DateTime.Now.ToShortDateString())
                            {
                                string temp = @"["+item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;
                                lb_sites.Items.Add(temp);
                            }
                        }
                        break;
                    case "За тиждень":
                        foreach (var item in _history)
                        {
                            if (item.dateTime.Date.DayOfYear <= DateTime.Now.Date.DayOfYear && item.dateTime.Date.DayOfYear > DateTime.Now.Date.DayOfYear - 7 )
                            {
                                string temp = @"[" + item.dateTime.Date.ToShortDateString() + "]   " + "[" + item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;
                                lb_sites.Items.Add(temp);
                            }
                        }
                        break;
                    case "За місяць":
                        foreach (var item in _history)
                        {
                            if (item.dateTime.Date.DayOfYear <= DateTime.Now.Date.DayOfYear && item.dateTime.Date.DayOfYear > DateTime.Now.Date.DayOfYear - 31)
                            {
                                string temp = @"[" + item.dateTime.Date.ToShortDateString() + "]   " + "[" + item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;
                                lb_sites.Items.Add(temp);
                            }
                        }
                        break;
                    default:
                        foreach (var item in _history.OrderByDescending(x => x.dateTime))
                        {
                            if (e.Node.Text == item.dateTime.Date.ToShortDateString())
                            {
                                string temp = @"[" + item.dateTime.ToShortTimeString() + "]   " + item.Title + "  |  " + item.Url;
                                lb_sites.Items.Add(temp);
                            }
                        }
                        break;
                }
            }
        }

        private void вилучитиПоточнийСайтЗІсторіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp_all = lb_sites.SelectedItem.ToString();
            string temp_url = temp_all.Substring(temp_all.IndexOf('|') + 3);
            string temp_time = temp_all.Substring(temp_all.LastIndexOf('[')+1,5);

            var ind = _history.Where(x => x.Url == temp_url && x.dateTime.ToShortTimeString() == temp_time).FirstOrDefault();
            _history.Remove(ind);
            lb_sites.Items.RemoveAt(lb_sites.SelectedIndex);
        }

        private void очиститиВсюПоточнуІсторіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in lb_sites.Items)
            {
                if (item.ToString().Contains("|") == true)
                {
                    string temp_all = item.ToString();
                    string temp_url = temp_all.Substring(temp_all.IndexOf('|') + 3);
                    string temp_time = temp_all.Substring(temp_all.LastIndexOf('[') + 1, 5);

                    var ind = _history.Where(x => x.Url == temp_url && x.dateTime.ToShortTimeString() == temp_time).FirstOrDefault();
                    _history.Remove(ind);
                }
            }
            lb_sites.Items.Clear();
        }

        private void очиститиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _history.Clear();
        }

        //Два рази клікнули в історії
        private void lb_sites_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ListBox)
            { 
                string temp_all = (sender as ListBox).SelectedItem.ToString();
                string temp_url = temp_all.Substring(temp_all.IndexOf('|') + 3);
                string temp_time = temp_all.Substring(temp_all.LastIndexOf('[') + 1, 5);

                var ind = _history.Where(x => x.Url == temp_url && x.dateTime.ToShortTimeString() == temp_time).FirstOrDefault();

                dblSelect = ind;
                this.Close();
            }
        }
    }
}
