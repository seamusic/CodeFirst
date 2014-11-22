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
            //����MEF����ע������
            DirectoryCatalog catalog = new DirectoryCatalog(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
            //����һ���������൱������������
            _container = new CompositionContainer(catalog);

            //���ó����ComposeParts�Ѹ���������ϵ�һ��
            try
            {
                this._container.ComposeParts(this);//����ֻ��Ҫ���뵱ǰӦ�ó���ʵ���Ϳ����ˣ��������ֻ��Զ����ֲ���װ
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