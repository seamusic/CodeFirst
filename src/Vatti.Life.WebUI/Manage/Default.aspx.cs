using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lennon.Core.Logging;
using Vatti.Life.Contracts;

namespace Vatti.Life.WebUI.Manage
{
    public partial class Default : Vatti.Life.WebUI.PageBase
    {
        [Import]
        protected IDemoContract _demoContract;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}