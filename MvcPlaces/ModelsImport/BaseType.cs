using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class BaseType
    {
        public BaseType()
        {
            Base = new HashSet<Base>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Base> Base { get; set; }
    }
}
