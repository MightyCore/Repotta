using System;
using System.Linq;

namespace Repotta.Common
{
    public static class Attributes
    {
        #region Attribute
        /// <summary>
        /// Enumに文字列を付与
        /// </summary>
        [AttributeUsage(AttributeTargets.Field)]
        public sealed class TextAttribute : Attribute
        {
            public string Text { get; set; }
        }

        /// <summary>
        /// Enumに付与した文字列の取得
        /// </summary>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        public static string GetText(this Enum vEnum) => vEnum.GetAttribute<TextAttribute>()?.Text;

        /// <summary>
        /// 属性取得
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="vEnum"></param>
        /// <returns></returns>
        private static TAttribute GetAttribute<TAttribute>(this Enum vEnum) where TAttribute : Attribute
        {
            var wFieldInfo = vEnum.GetType().GetField(vEnum.ToString());
            var wAttributes = wFieldInfo.GetCustomAttributes(typeof(TAttribute), false).Cast<TAttribute>();
            return ((wAttributes?.Count() ?? 0) <= 0) ? null : wAttributes.First();
        }
        #endregion Attribute
    }
}
