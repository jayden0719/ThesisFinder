using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace ThesisFinder
{
    public partial class Form1 : Form
    {
        const string _dbpia_url = "http://api.dbpia.co.kr/v2/search/search.xml";
        const string _dbpia_key = "bae8589e0e959ef4df873bd23581677c";

        //DB 경로
        string strConn = string.Format("Data Source={0}", Application.StartupPath + @"\thesisDB.db");

        public Form1()
        {
            InitializeComponent();
            AssemblyName name = Assembly.GetExecutingAssembly().GetName();
            this.Text = "논문검색엔진_" + name.Version;
            textBox2.Text = Convert.ToString(10);
        }

        public string GetResult()
        {
            string searchall; //검색어
            string searchauthor; //저자명
            string searchbook; //간행물명
            string searchpublisher; //발행기관명
            int category; //주제분류
            int pyear = 1; //발행연도
            int pyear_start = 2020;
            int pyear_end = 2024;
            int pagecount; //검색건수
            int sorttype; //정렬유형

            string query = ""; // 파라미터 문자열
            string result = ""; // 반환값

            searchall = textBox1.Text;
            searchauthor = textBox3.Text;
            searchbook = textBox4.Text;
            searchpublisher = textBox5.Text;
            pagecount = Convert.ToInt32(textBox2.Text);


            if (pubchk.Text == "최근 1년")
            {
                pyear = 1;
            }
            else if (pubchk.Text == "최근 3년")
            {
                pyear = 2;
            }
            else
            {
                pyear = 3;
                pyear_start = Convert.ToInt32(textBox6.Text);
                pyear_end = Convert.ToInt32(textBox7.Text);
            }

            if (sortChk.Text == "유사도순")
            {
                sorttype = 1;

            }
            else if (sortChk.Text == "발행일순")
            {
                sorttype = 2;

            }
            else
            {
                sorttype = 3;
            }

            if (catechk.Text == "인문학")
            {
                category = 1;
            }
            else if (catechk.Text == "사회과학")
            {
                category = 2;
            }
            else if (catechk.Text == "자연과학")
            {
                category = 3;
            }
            else if (catechk.Text == "공학")
            {
                category = 4;
            }
            else if (catechk.Text == "의약학")
            {
                category = 5;
            }
            else if (catechk.Text == "농수해양")
            {
                category = 6;
            }
            else if (catechk.Text == "예술체육")
            {
                category = 7;
            }
            else if (catechk.Text == "복합학")
            {
                category = 8;
            }
            else
            {
                category = 9;
            }

            if (pyear == 3)
            {
                query = string.Format("?key={0}&target={1}&searchall={2}&searchauthor={3}&searchbook={4}&searchpublisher={5}&category={6}" +
                "&pyear={7}&pagecount={8}&sorttype={9}&pyear_start={10}&pyear_end={11}", _dbpia_key, "se_adv", searchall, searchauthor, searchbook, searchpublisher, category,
                pyear, pagecount, sorttype, pyear_start, pyear_end);


            }
            else
            {
                query = string.Format("?key={0}&target={1}&searchall={2}&searchauthor={3}&searchbook={4}&searchpublisher={5}&category={6}" +
                "&pyear={7}&pagecount={8}&sorttype={9}", _dbpia_key, "se_adv", searchall, searchauthor, searchbook, searchpublisher, category,
                pyear, pagecount, sorttype);
            }

            WebRequest request = WebRequest.Create(_dbpia_url + query);

            using (var response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(dataStream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string results = GetResult();
            int cnt = 0;

            XmlDocument XmlFile = new XmlDocument();
            XmlFile.LoadXml(results);

            XmlNodeList XmlList = XmlFile.GetElementsByTagName("item");

            foreach (XmlNode item in XmlList)
            {
                cnt++;
                string title = item["title"].InnerText;
                title = title.Replace("&lt;", "<");
                title = title.Replace("&gt;", ">");
                title = title.Replace("!HS", "");
                title = title.Replace("!HE", "");

                string name = item["authors"]["author"]["name"].InnerText;
                string price_yn = item["free_yn"].InnerText;
                string link_url = item["link_url"].InnerText;

                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(cnt.ToString());
                lvi.SubItems.Add(title);
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(price_yn);
                lvi.SubItems.Add(link_url);

                listView1.Items.Add(lvi);

            }

        }

        private void pubchk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pubchk.Text == "직접지정")
            {
                textBox6.Visible = true;
                label8.Visible = true;
                textBox7.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                label8.Visible = false;
                textBox7.Visible = false;

            }
        }

        private void listview1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool val = false;
                try
                {
                    val = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {

                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4), val ?
                    System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void listview1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listview1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listview1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool val = false;
                try
                {
                    val = Convert.ToBoolean(this.listView1.Columns[e.Column].Tag);
                }
                catch (Exception)
                {

                }
                this.listView1.Columns[e.Column].Tag = !val;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    item.Checked = !val;
                }
                this.listView1.Invalidate();
            }
        }

        private void listview1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListView.SelectedListViewItemCollection item = listView1.SelectedItems;
                ListViewItem lvItem = item[0];

                try
                {
                    string urlAddress = lvItem.SubItems[5].Text;

                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        urlAddress = urlAddress.Replace("&", "^&");
                        System.Diagnostics.Process p = new Process();
                        p.StartInfo.UseShellExecute = true;
                        p.StartInfo.FileName = urlAddress;
                        p.Start();
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title;
            string author;
            string free;
            string url;

       
            using (SqliteConnection conn = new SqliteConnection(strConn))
            {
                conn.Open();
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    title = item.SubItems[2].Text;
                    author = item.SubItems[3].Text;
                    free = item.SubItems[4].Text;
                    url = item.SubItems[5].Text;

                    string sql = string.Format("Insert into thesis_table(thesis_title, thesis_author, thesis_free, thesis_link) " +
                        "values('{0}','{1}','{2}','{3}')", title, author, free, url);

                    SqliteCommand cmd = new SqliteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conn.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            ListViewItem lvi;
            string title;
            string author;
            string free;
            string url;

            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                string sql = string.Format("select * from thesis_table");
                int idx = 0;

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    idx++;
                    title = rdr["thesis_title"].ToString();
                    author = rdr["thesis_author"].ToString();
                    free = rdr["thesis_free"].ToString();
                    url = rdr["thesis_link"].ToString();

                    lvi = new ListViewItem(new String[] {"", Convert.ToString(idx), title, author, free, url });
                    this.listView1.Items.Add(lvi);
                }
                rdr.Close();
                conn.Close();
            }
        }
    }
}
