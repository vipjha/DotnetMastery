﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }
        ServiceLifetime Lifetime { get; }
    }
}
