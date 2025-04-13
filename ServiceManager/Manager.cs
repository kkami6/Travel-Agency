﻿using DataLayer;
using System.Data.Common;
using System.Collections.Generic;
using MySqlX.XDevAPI.CRUD;
using System.Data;

namespace ServiceLayer
{
    public class Manager<T, K>
    {
        private IDb<T, int> context;

        public void Create(T item)
        {
            try
            {
                context.Create(item);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void Read(int key)
        {
            try
            {
                context.Read(key);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ReadAll()
        {
            try
            {
                context.ReadAll();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T item)
        {
            try
            {
                context.Update(item);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                context.Delete(key);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
