using Microsoft.EntityFrameworkCore;
using MvcPlaces.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Code.Data
{
    public class DataAccess<T, TView>
        where T : class
        where TView : IView<T>, new()
    {
        #region Private Declarations

        private DbSet<T> dataSet = null;
        private DbContext context = null;

        #endregion Private Declarations

        #region Public Properties

        public DbSet<T> DataSet
        {
            get => dataSet ?? throw new NullReferenceException("The dataSet has not been set.");
            set => dataSet = value;
        }

        public DbContext Context
        {
            get => context ?? throw new NullReferenceException("The context object has not been set.");
            set => context = value;
        }

        #endregion Public Properties

        #region Constructor

        public DataAccess(DbContext context, DbSet<T> dataSet)
        {
            Context = context;
            DataSet = dataSet;
        }

        #endregion Constructor

        #region Methods

        private int Count()
        {
            return DataSet.Count();
        }

        public bool ItemExists(Func<T, bool> predicate)
        {
            return DataSet.Any(predicate);
        }

        public virtual IQueryable<T> GetItems()
        {
            return from item in DataSet
                   select item;
        }

        public T GetItem(int id)
        {
            return DataSet.Find(id);
        }

        public T GetItem(int id, Func<int, T> itemFunc)
        {
            return itemFunc(id);
        }




        public void Add(T item)
        {
            DataSet.Add(item);
        }







        public void Delete(T item)
        {
            DataSet.Remove(item);
        }

        public void Update(T item)
        {
            Context.Entry<T>(item).State = EntityState.Modified;
        }

        public void Save()
        {
            Context.SaveChanges();
        }


        public Task<int> SaveAsync()
        {
            return Context.SaveChangesAsync();
        }



        public ICollection<TView> GetViews()
        {
            ICollection<TView> result = new List<TView>();
            foreach (var item in GetItems())
            {
                TView view = new TView();
                view.ViewObject = item;
                result.Add(view);
            }
            return result;
        }

        public TView GetView(int id)
        {
            TView view = new TView();
            view.ViewObject = GetItem(id);
            return view;
        }

        public TView GetView(int id, Func<int, T> itemFunc)
        {
            TView view = new TView();
            view.ViewObject = GetItem(id, itemFunc);
            return view;
        }

        #region Asynchronous Methods

        public Task<ICollection<TView>> GetViewsAsync()
        {
            return Task<ICollection<TView>>.Factory.StartNew(() => GetViews());
        }

        public Task<TView> GetViewAsync(int id, Func<int, T> itemFunc)
        {
            return Task<TView>.Factory.StartNew(() => GetView(id, itemFunc));
        }

        public Task<T> GetItemAsync(int id, Func<int, T> itemFunc)
        {
            return Task<T>.Factory.StartNew(() => GetItem(id, itemFunc));
        }

        #endregion Asynchronous Methods

        #endregion Methods

    }
}
