using System.ComponentModel.DataAnnotations;

namespace Starsea.DataAnalyze.DB
{
    public class DA_DBA_COL_COMMENTS
    {
        [Key]
        public string ID { get; set; }
        public string OWNER{get;set;}
        
        public string TABLE_NAME{get;set;}
        
        public string COLUMN_NAME{get;set;}
        public string COMMENTS{get;set;}

    }
}