using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lennon.Core.Data;
using Lennon.Utility.Data;

namespace Vatti.Life.Contracts.Models
{
    public class DemoDetail : EntityBase<Guid>
    {
        public DemoDetail()
        {
            Id = CombHelper.NewComb();
        }

        public string Content { get; set; }

        public bool IsLocked { get; set; }

        public virtual DemoEntity DemoEntity { get; set; }
    }
}
