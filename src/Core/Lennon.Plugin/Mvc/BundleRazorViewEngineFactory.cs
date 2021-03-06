﻿// -----------------------------------------------------------------------
//  <copyright file="AbstractBuilder.cs" company="OSharp开源团队">
//      Copyright (c) 2014 Lennon. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2014-07-13 19:13</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UIShell.OSGi;


namespace Lennon.Plugin.Mvc
{
    public class BundleRazorViewEngineFactory : IBundleViewEngineFactory
    {
        public IBundleViewEngine CreateViewEngine(IBundle bundle)
        {
            return new BundleRazorViewEngine(bundle);
        }
    }
}