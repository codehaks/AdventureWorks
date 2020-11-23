using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimDepartmentGroup
    {
        public DimDepartmentGroup()
        {
            InverseParentDepartmentGroupKeyNavigation = new HashSet<DimDepartmentGroup>();
        }

        public int DepartmentGroupKey { get; set; }
        public int? ParentDepartmentGroupKey { get; set; }
        public string DepartmentGroupName { get; set; }

        public virtual DimDepartmentGroup ParentDepartmentGroupKeyNavigation { get; set; }
        public virtual ICollection<DimDepartmentGroup> InverseParentDepartmentGroupKeyNavigation { get; set; }
    }
}
