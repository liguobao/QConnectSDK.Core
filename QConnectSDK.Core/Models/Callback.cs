﻿namespace QConnectSDK.Core.Models
{
    /// <summary>
    /// 根据access_token获得对应用户身份的openid
    /// </summary>
    public class Callback
    {
        /// <summary>
        /// 
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string openid { get; set; }
    }
}
