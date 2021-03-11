using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationScaffoldingHomeWork
{
    public partial class Author
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public Guid? ArticleId { get; set; } = Guid.NewGuid();
        public string Status { get; set; }
        public virtual Article Article { get; set; }
    }
}
