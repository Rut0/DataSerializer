using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSerializer
{
    public class DataSerializer
    {
        public static byte[] Serialize(object data, bool compress)
        {
            if (IsPrimitive(data))
            {
                //Serialize(data);
            }
        }

        public static string Serialize(object data, bool compress, bool base64)
        {
            return Convert.ToBase64String(Serialize(data, compress));
        }

        private static bool IsPrimitive(object data)
        {
            return data.GetType().Namespace == "System";
        }
    }
}
