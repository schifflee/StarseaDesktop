//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Starsea.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogArticle
    {
        public int Id { get; set; }
        public System.Guid BlogId { get; set; }
        public string Subject { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime DateModify { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}