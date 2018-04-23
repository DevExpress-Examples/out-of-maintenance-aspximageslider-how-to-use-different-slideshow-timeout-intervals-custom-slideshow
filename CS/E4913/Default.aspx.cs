using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxHiddenField;

namespace E4913 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void hfCustomIntervals_Init(object sender, EventArgs e) {
            ASPxHiddenField hiddenField = sender as ASPxHiddenField;

            hiddenField["Cherries"] = 2000;
            hiddenField["Raspberry"] = 5000;
            hiddenField["Strawberry"] = 1000;
            hiddenField["Tomatoes"] = 4000;
        }
    }
}