using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // legge da web.config !!!
            string name = ConfigurationManager.AppSettings["name"];
            string surname = ConfigurationManager.AppSettings["surname"];
            // mostra nel paragrafo con id test
            test.InnerText = " Ciao!\nSono " + name + " " + surname + ".";
        }
    }
}