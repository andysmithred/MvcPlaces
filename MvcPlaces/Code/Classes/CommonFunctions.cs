using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Code.Classes
{
    public static class CommonFunctions
    {
        public static List<string> ConvertToStringList<K>()
        {
            return Enum.GetValues(typeof(K))
                    .Cast<K>()
                    .Select(v => v.ToString())
                    .ToList();
        }
    }
}
