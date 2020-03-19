﻿using AnimalRescue.DataAccess.Mongodb.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescue.DataAccess.Mongodb.Interfaces.Repositories
{
    public interface ISecurityTokenRepository: IBaseCollection<SecurityToken>
    {
        Task<SecurityToken> GetIfExists(string token);
    }
}
