using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;

namespace Surfer
{
    public partial class Form1 : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        public Form1()
        {
            InitializeComponent();

            TextBox1.Click += TextBoxOnClick;
        }

        //Select Entire Content of SearchBox in Single Click
        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }


        //Form Load
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Load Below URL initially
            WebBrowser1.Navigate("http://www.google.co.in");
            TextBox1.Text = "http://www.google.co.in";
        }


        //Searchbox
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter Key to Search Event
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser1.Navigate(TextBox1.Text);
            }
        }

        //Set the Search Box Value as the Web Brouser Control's current URL
        private void WebBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            TextBox1.Text = WebBrowser1.Url.ToString();
        }



        //Backward Button
        private void BackwardBtn_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoBack();
        }

        //Forward Button
        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            WebBrowser1.GoForward();
        }

        //Reload Button
        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            WebBrowser1.Refresh();
        }

        //Home Button
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate("https://www.google.co.in");
        }

        //Search Button
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate(TextBox1.Text);
        }

        OpenFileDialog ofd = new OpenFileDialog();



        //---Menu Strip---//
        //Menu Item - Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WebBrowser1.Navigate(ofd.FileName);
            }
        }

        //Menu Item - Find
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser1.Focus();
            SendKeys.Send("^f");
        }

        //Menu Item - Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser1.ShowPrintDialog();
        }

        //Menu Item - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

    }
}
