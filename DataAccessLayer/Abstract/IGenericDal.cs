﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //kuraller belirleniyor
    public interface IGenericDal<T> where T : class,new()
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAllList();
        T GetById(int id);
    }
}
