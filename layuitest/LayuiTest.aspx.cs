using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace layuitest
{
    public partial class LayuiTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetValue()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name1", "001");
            dic.Add("name2", "002");
            string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dic);
            return jsonStr;

        }
    }
}