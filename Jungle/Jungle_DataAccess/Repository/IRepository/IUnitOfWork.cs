﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository.IRepository
{
    internal interface IUnitOfWork: IDisposable
    {
        void Save();
    }
}
