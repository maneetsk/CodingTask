using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;

namespace BusinessLogic
{
    public class clsUtilities
    {
        public static string ConvertToJson(object obj)
        {

            string sJSON = "";
            System.Web.Script.Serialization.JavaScriptSerializer oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer() { MaxJsonLength = 86753090 };
            sJSON = oSerializer.Serialize(obj);
            return sJSON;
        }

        public static object ConvertToObject(object original, object convertto)
        {
            try
            {
                if (convertto != null)
                {
                    Type _original = original.GetType();
                    Type _convertto = convertto.GetType();
                    PropertyInfo[] properties_original = _original.GetProperties();

                    foreach (PropertyInfo item in properties_original)
                    {
                        PropertyInfo properties_convertto = _convertto.GetProperty(item.Name);
                        if (properties_convertto != null)
                        {
                            object defaultValue = item.GetValue(original, null);
                            Type t = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType;

                            object safeValue = (defaultValue == null) ? null : Convert.ChangeType(defaultValue, t);
                            properties_convertto.SetValue(convertto, safeValue, null);
                            // properties_convertto.SetValue(convertto, System.Convert.ChangeType(safeValue, item.PropertyType), null);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return convertto;
        }

        public static object DataTableToJSON(DataTable table)
        {
            var list = new List<Dictionary<string, object>>();

            foreach (DataRow row in table.Rows)
            {
                var dict = new Dictionary<string, object>();

                foreach (DataColumn col in table.Columns)
                {
                    dict[col.ColumnName] = (Convert.ToString(row[col]));
                }
                list.Add(dict);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            return serializer.Serialize(list);
        }
    }
}