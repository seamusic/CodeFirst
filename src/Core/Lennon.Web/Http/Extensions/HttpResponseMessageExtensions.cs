// 源文件头信息：
// <copyright file="HttpResponseMessageExtensions.cs">
// Copyright(c)2012-2014 66SOFT.All rights reserved.
// CLR版本：4.0.30319.239
// 开发组织：柳柳软件坊
// 公司网站：http://www.66soft.net
// 所属工程：Gmf.Web
// 最后修改：郭明锋
// 最后修改：2014/03/10 20:27
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

using Lennon.Utility;
using Lennon.Utility.Extensions;


namespace Lennon.Web.Http.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static Task<HttpResponseMessage> ToTask(this HttpResponseMessage responseMessage)
        {
            TaskCompletionSource<HttpResponseMessage> taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
            taskCompletionSource.SetResult(responseMessage);
            return taskCompletionSource.Task;
        }

        public static string GetErrorMessage(this HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string msg = "请求处理失败";
                switch (response.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        msg = "请求的资源不存在";
                        break;
                    case HttpStatusCode.BadRequest:
                        msg = "非法请求";
                        break;
                    case HttpStatusCode.Forbidden:
                        msg = "请求被拒绝";
                        break;
                }
                MediaTypeHeaderValue contentType = response.Content.Headers.ContentType;
                if (contentType == null || contentType.MediaType != "text/html")
                {
                    //HttpError error = response.Content.ReadAsAsync<HttpError>().Result;
                    //if (error != null)
                    //{
                    //    msg = "{0}，详情：{1}".FormatWith(msg, error.Message);
                    //}
                }
                return msg;
            }
            return null;
        }
    }
}