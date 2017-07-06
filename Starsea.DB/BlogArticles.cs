namespace Starsea.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BlogArticles
    {
        public int Id { get; set; }

        public Guid BlogId { get; set; }

        [Required]
        public string Subject { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateModify { get; set; }

        public int Blog_Id { get; set; }

        public virtual Blogs Blogs { get; set; }
    }
}
