﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lennon.Web.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lennon.Web.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 客户端对返回数据进行解密处理时发生异常。.
        /// </summary>
        internal static string Http_Seciruty_Client_DecryptResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Seciruty_Client_DecryptResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 客户端对发送数据进行加密处理时发生异常。.
        /// </summary>
        internal static string Http_Security_Client_EncryptRequest_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Client_EncryptRequest_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 客户端对返回数据签名验证未通过。.
        /// </summary>
        internal static string Http_Security_Client_VerifyResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Client_VerifyResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 服务器对请求数据进行解密处理时发生异常。.
        /// </summary>
        internal static string Http_Security_Host_DecryptRequest_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Host_DecryptRequest_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 服务器对返回数据进行加密处理时发生异常。.
        /// </summary>
        internal static string Http_Security_Host_EncryptResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Host_EncryptResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 参数hashType必须为MD5或SHA1。.
        /// </summary>
        internal static string Http_Security_RSA_Sign_HashType {
            get {
                return ResourceManager.GetString("Http_Security_RSA_Sign_HashType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 指定功能只支持使用Ajax的方式来调用。.
        /// </summary>
        internal static string Mvc_ActionAttribute_AjaxOnlyMessage {
            get {
                return ResourceManager.GetString("Mvc_ActionAttribute_AjaxOnlyMessage", resourceCulture);
            }
        }
    }
}
