﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lennon.Core.Data.Entity;
using Vatti.Life.Contracts.Models;

namespace Vatti.Life.Services.EntityConfigurations
{
    public class DemoDetailConfiguration : EntityConfigurationBase<DemoDetail, Guid>
    {
        public DemoDetailConfiguration()
        {
            HasRequired(m => m.DemoEntity).WithMany(n => n.DemoDetails);
        }
    }
}
