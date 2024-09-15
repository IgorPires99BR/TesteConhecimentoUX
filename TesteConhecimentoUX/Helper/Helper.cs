using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TesteConhecimentoUX.Helper
{
    public static class Helper
    {
        public static string AplicaEnum<TEnum>(this TEnum enumValue)
       where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException("Enum Precisa ter um Tipo");

            var enumType = enumValue.GetType();
            var memberInfo = enumType.GetMember(enumValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return enumValue.ToString();
        }
    }
}