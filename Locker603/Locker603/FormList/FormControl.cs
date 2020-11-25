using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Form5.FormList
{
    public static class FormControl
    {
        public static T FindByName<T>(this object obTarget, string strName) where T : class
        {
            FieldInfo[] fis = obTarget.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo fi = null;

            for (int iIndex = 0; iIndex < fis.Length; iIndex++)
            {
                if (fis[iIndex].Name.ToLower() == strName.ToLower())
                {
                    fi = fis[iIndex];
                    break;
                }
            }
            return fi.GetValue(obTarget) as T;
        }
        public static T FindByName<T>(this string strName, object obTarget) where T : class
        {
            FieldInfo[] fis = obTarget.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo fi = null;

            for (int iIndex = 0; iIndex < fis.Length; iIndex++)
            {
                if (fis[iIndex].Name.ToLower() == strName.ToLower())
                {
                    fi = fis[iIndex];
                    break;
                }
            }
            return fi.GetValue(obTarget) as T;
        }
    }
}
