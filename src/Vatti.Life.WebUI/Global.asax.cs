using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevExpress.Web.ASPxClasses;
using Lennon.Core.Context;
using Lennon.Core.Data.Entity;
using Lennon.Core.Logging;
using Lennon.Utility.Extensions;

namespace Vatti.Life.WebUI
{
    public class Global_asax : System.Web.HttpApplication
    {
        private CompositionContainer _container;
        public Global_asax()
        {
            EndRequest += (sender, e) => LennonContext.Current = null;
        }

        private readonly Logger _logger = LogManager.GetLogger(typeof(Global_asax));
        void Application_Start(object sender, EventArgs e)
        {
            //设置MEF依赖注入容器
            DirectoryCatalog catalog = new DirectoryCatalog(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
            //创建一个容器，相当于是生产车间
            _container = new CompositionContainer(catalog);

            //调用车间的ComposeParts把各个部件组合到一起
            try
            {
                this._container.ComposeParts(this);//这里只需要传入当前应用程序实例就可以了，其它部分会自动发现并组装
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }

            DatabaseInitializer.Initialize();
            DevExpress.Web.ASPxClasses.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
        }

        void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }

        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = HttpContext.Current.Server.GetLastError();
            _logger.Error(ex.FormatMessage());
            // Code that runs when an unhandled error occurs
        }

        void Session_Start(object sender, EventArgs e)
        {
            HttpRequest request = HttpContext.Current.Request;
            LennonContext.Current.Operator.Ip = request.GetIpAddress();
            // Code that runs when a new session is started
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
    }
}