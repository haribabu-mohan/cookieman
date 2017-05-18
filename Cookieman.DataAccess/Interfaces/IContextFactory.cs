﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookieman.DataAccess.Interfaces
{
    public interface IContextFactory 
    {
        CookieContext Context(Guid storeId);
    }
}
