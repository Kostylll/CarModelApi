﻿using CarModelRegister.Application.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Domain.Interface
{
    public interface IFinancialServices
    {
        Task<bool> Caculate(FinancialRequest request);
    }
}
