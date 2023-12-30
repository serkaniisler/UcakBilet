﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLaayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> GetList();

        T GetByID(int id);
    }
}
