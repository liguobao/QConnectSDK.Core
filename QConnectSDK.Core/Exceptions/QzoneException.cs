﻿using System;
using System.Net;
using RestSharp;

namespace QConnectSDK.Core.Exceptions
{
    /// <summary>
    /// 异常处理类
    /// </summary>
    public class QzoneException : Exception
    {
        /// <summary>
        /// Http请求状态
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        ///默认构造函数
        /// </summary>
       public QzoneException()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message"></param>
        public QzoneException(string message)
            : base(message)
        {

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="r"></param>
        public QzoneException(IRestResponse r)
        {
            Response = r;
            StatusCode = r.StatusCode;
        }

        /// <summary>
        /// The response of the error call (for Debugging use)
        /// </summary>
        public IRestResponse Response { get; private set; }
    }
}
