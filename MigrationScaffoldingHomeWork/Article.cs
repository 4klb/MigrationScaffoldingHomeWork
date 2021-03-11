using System;
using System.Collections.Generic;

#nullable disable

namespace MigrationScaffoldingHomeWork
{
    public partial class Article
    {
        public Article()
        {
            Authors = new HashSet<Author>();
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }
        public DateTime PublicationDate { get; set; }
        public Guid? CategoryId { get; set; } = Guid.NewGuid();

        public virtual Category Category { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
