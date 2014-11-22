﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Lennon.Web.Http.Internal;


namespace Lennon.Web.Http.Handlers
{
    public abstract class TokenAuthenticationHandlerBase : DelegatingHandler
    {
        /// <summary>
        /// 重写以实现登录标识验证的具体业务
        /// </summary>
        /// <param name="authenticationToken">用户名密码的加密标识</param>
        /// <returns>是否验证通过</returns>
        protected abstract bool Authorize(string authenticationToken);

        #region Overrides of DelegatingHandler

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.Headers.Contains(HttpHeaderNames.GmfAuthenticationToken))
            {
                return base.SendAsync(request, cancellationToken);
            }
            string authenticationToken = request.Headers.GetValues(HttpHeaderNames.GmfAuthenticationToken).First();
            if (!Authorize(authenticationToken))
            {
                return CreateForbiddenResponseMessage(request);
            }
            return base.SendAsync(request, cancellationToken);
        }

        private static Task<HttpResponseMessage> CreateForbiddenResponseMessage(HttpRequestMessage request)
        {
            return Task<HttpResponseMessage>.Factory.StartNew(() =>
            {
                HttpResponseMessage response = request.CreateErrorResponse(HttpStatusCode.Forbidden, "用户登录已失效，请重新登录");
                return response;
            });
        }

        #endregion
    }
}
