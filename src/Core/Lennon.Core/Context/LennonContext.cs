using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;


namespace Lennon.Core.Context
{
    /// <summary>
    /// OSharp框架上下文，用于构造OSharp框架运行环境
    /// </summary>
    [Serializable]
    public class LennonContext : Dictionary<string, object>
    {
        private const string CallContextKey = "__Lennon_CallContext";
        private const string OperatorKey = "__Lennon_Context_Operator";

        /// <summary>
        /// 初始化一个<see cref="LennonContext"/>类型的新实例
        /// </summary>
        public LennonContext()
        { }

        /// <summary>
        /// 初始化一个<see cref="LennonContext"/>类型的新实例
        /// </summary>
        protected LennonContext(SerializationInfo info, StreamingContext context)
            :base(info, context)
        { }

        /// <summary>
        /// 获取或设置 当前上下文
        /// </summary>
        public static LennonContext Current
        {
            get
            {
                LennonContext context = CallContext.LogicalGetData(CallContextKey) as LennonContext;
                if (context != null)
                {
                    return context;
                }
                context = new LennonContext();
                CallContext.LogicalSetData(CallContextKey, context);
                return context;
            }
            set
            {
                if (value == null)
                {
                    CallContext.FreeNamedDataSlot(CallContextKey);
                    return;
                }
                CallContext.LogicalSetData(CallContextKey, value);
            }
        }

        /// <summary>
        /// 获取 当前操作者
        /// </summary>
        public Operator Operator
        {
            get
            {
                if (!ContainsKey(OperatorKey))
                {
                    this[OperatorKey] = new Operator();
                }
                return this[OperatorKey] as Operator;
            }
        }
    }
}