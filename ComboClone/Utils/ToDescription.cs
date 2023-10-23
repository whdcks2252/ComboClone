using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComboClone.Utils
{
    public static class ToDescription
    {
        /// <summary>
        /// Enum 확장메소드, Description 읽어오기
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Description(this Enum source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());
            var att = (DescriptionAttribute)fi.GetCustomAttribute(typeof(DescriptionAttribute));
            if (att != null)
            {
                return att.Description;
            }
            else
            {
                return source.ToString();
            }
        }

    }
}
