using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Lennon.Web.Mvc
{
    [Authorize]
    public abstract class AdminBaseController : BaseController
    { }
}