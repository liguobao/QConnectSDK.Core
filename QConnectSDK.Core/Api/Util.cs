using System;

namespace QConnectSDK.Core.Api
{
    class Util
    {
        /// <summary>
        /// 随机种子
        /// </summary>
        private static Random RndSeed = new Random();
        /// <summary>
        /// 生成一个随机码
        /// </summary>
        /// <returns></returns>
        public static string GenerateRndNonce()
        {
            return string.Concat(
            Util.RndSeed.Next(1, 99999999).ToString("00000000"),
            Util.RndSeed.Next(1, 99999999).ToString("00000000"),
            Util.RndSeed.Next(1, 99999999).ToString("00000000"),
            Util.RndSeed.Next(1, 99999999).ToString("00000000"));
        }
    }
}
