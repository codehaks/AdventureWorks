using System;
using System.Collections.Generic;

#nullable disable

namespace Portal.Data.Models
{
    public partial class DimAccount
    {
        public DimAccount()
        {
            InverseParentAccountKeyNavigation = new HashSet<DimAccount>();
        }

        public int AccountKey { get; set; }
        public int? ParentAccountKey { get; set; }
        public int? AccountCodeAlternateKey { get; set; }
        public int? ParentAccountCodeAlternateKey { get; set; }
        public string AccountDescription { get; set; }
        public string AccountType { get; set; }
        public string Operator { get; set; }
        public string CustomMembers { get; set; }
        public string ValueType { get; set; }
        public string CustomMemberOptions { get; set; }

        public virtual DimAccount ParentAccountKeyNavigation { get; set; }
        public virtual ICollection<DimAccount> InverseParentAccountKeyNavigation { get; set; }
    }
}
