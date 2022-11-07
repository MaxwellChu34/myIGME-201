using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch { }
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");
        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;
            htmlElement = webBrowser.Document.Body;
            htmlElementCollection = htmlElement.GetElementsByTagName("h1");
            htmlElement = htmlElementCollection[0];
            htmlElement.InnerText = "My UFO Page";
            htmlElement = webBrowser.Document.Body;
            htmlElementCollection = htmlElement.GetElementsByTagName("h2");
            htmlElementCollection[0].InnerText = "My UFO Info";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = "";
            htmlElement.Style = "font-family: sans-serif;";
            htmlElement.Style = "color: #a40000;";
            htmlElement = webBrowser.Document.Body;
            htmlElementCollection = htmlElement.GetElementsByTagName("p");
            htmlElementCollection[0].InnerHtml = "Report your UFO sightings here: <a href=\"http://www.nuforc.org\">www.nuforc.org</a>";
            htmlElementCollection[0].Style = "color: green;";
            htmlElementCollection[0].Style = "font-weight: bold;";
            htmlElementCollection[0].Style = "font-size: 2em;";
            htmlElementCollection[0].Style = "text-transform: uppercase;";
            htmlElementCollection[0].Style = "text-shadow: 3px 2px #A44;";
            htmlElementCollection[1].InnerText = "";
            htmlElementCollection[2].InnerHtml += "<img src=\"https://s.w-x.co/util/image/w/in-ufo.jpg?v=ap&w=980&h=551\" width=\"300\" height=\"200\">";
            htmlElement = webBrowser.Document.CreateElement("footer");
            htmlElement.InnerText = "(&copy;) 2022 M. Chu";
            webBrowser.Document.Body.AppendChild(htmlElement);
        } 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
