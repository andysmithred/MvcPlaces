using MvcPlaces.Models;
//using MvcPlaces
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcPlaces.ViewModels.Models.Main
{
    public class ContinentView : View<Continent>
    {
        #region Database Properties

        public int Id => ViewObject.Id;

        public string Name => ViewObject.Name;

        public string Code => ViewObject.Code;

        [Display(Name = "Parent Id")]
        public int? ParentId => ViewObject.ParentId;

        #endregion Database Properties

        #region Foreign Properties

        public ContinentView Parent => GetView<ContinentView, Continent>(ViewObject.Parent);

        public ICollection<ContinentView> Children => GetViewList<ContinentView, Continent>(ViewObject.Children);

        public ICollection<TerritoryView> Territories => GetTerritories();

        private ICollection<TerritoryView> GetTerritories()
        {
            ICollection<TerritoryView> result = GetViewList<TerritoryView, Territory>(ViewObject.Territories);

            if(result == null || result.Count == 0)
            {
                result = result.Concat(Children.SelectMany(x => x.Territories).ToList();
            }

            return result.OrderBy(x => x.Name).ToList();
        }

        #endregion Foreign Properties

        #region Other Properties

        public override string ListName => Name;

        public int TerritoryCount => Territories.Count;

        #endregion Other Properties

        #region Methods



        #endregion Methods


        public string CountryIsoCodesForGeochart => GetCountryIsoCodes();
        

        private string GetCountryIsoCodes()
        {
            string countries = "['Country', 'Name'],";
            bool first = true;

            foreach (var item in Territories)
            {
                string name = item.Name.Replace("'", "\\'");

                if (!first)
                {
                    countries += ",";
                }

                countries += "['" + item.Isocode + "', '" + name + "']";
                first = false;
            }

            return countries;
        }
    }
}