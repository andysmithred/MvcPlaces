using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Code.Interfaces
{
    public interface IMapItem
    {
        string Name { get; }
        double LatitudeValue { get; }
        double LongitudeValue { get; }
    }
}