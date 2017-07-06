namespace Starsea.DB
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model2 : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Model2”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“Starsea.DB.Model2”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Model2”
        //连接字符串。
        public Model2()
            : base("name=Model2")
        {
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

         public virtual DbSet<Blog1> BlogEntities { get; set; }
        public virtual DbSet<BlogArticle1> BlogArticleEntities { get; set; }

        public virtual DbSet<BASE_ACCOUNT1> BASE_ACCOUNTEntities { get; set; }
    }

    public class BASE_ACCOUNT1
    {
        public string ID { get; set; }
        public string ACCOUNT { get; set; }
        public string PASSWORD { get; set; }
        public string PERSONNAME { get; set; }
        public Nullable<decimal> AGE { get; set; }
        public string SEX { get; set; }
    }

    public class BlogArticle1
    {
        public int Id { get; set; }
        public System.Guid BlogId { get; set; }
        public string Subject { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime DateModify { get; set; }
    }

    public class Blog1
    {
        public int Id { get; set; }
        public System.Guid OwnerID { get; set; }
        public string Caption { get; set; }
        public System.DateTime DateCreate { get; set; }
    }

    
}