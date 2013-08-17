﻿using System.Collections.Generic;
using SPCommon.Interface;

namespace SPCommon.Infrastructure.Cache
{
    /// <summary>
    /// TODO: Implement
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class IISCacheProvider<T> : ICacheProvider<T> where T : class
    {
        private readonly ICacheConfiguration _configuration;

        public IISCacheProvider(ICacheConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool IsInCache()
        {
            throw new System.NotImplementedException();
        }

        public IList<T> GetListFromCache()
        {
            throw new System.NotImplementedException();
        }

        public IList<T> InsertListItems(IList<T> items)
        {
            throw new System.NotImplementedException();
        }

        public void Refresh()
        {
            throw new System.NotImplementedException();
        }

        public T GetSingleItem()
        {
            throw new System.NotImplementedException();
        }

        public T InsertSingleItem(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}