using System.ComponentModel.DataAnnotations;

namespace Starsea.DataAnalyze.DB
{
    public class DA_DBA_TAB_COLS
    {
        [Key]
        public string ID { get; set; }
        public string OWNER{get;set;}
        
        public string TABLE_NAME{get;set;}
        
        public string COLUMN_NAME{get;set;}
        public string DATA_TYPE{get;set;}
        public string DATA_TYPE_MOD{get;set;}
        public string DATA_TYPE_OWNER{get;set;}
        public string DATA_LENGTH{get;set;}
        public string DATA_PRECISION{get;set;}
        public string DATA_SCALE{get;set;}
        public string NULLABLE{get;set;}
        public string COLUMN_ID{get;set;}
        public string DEFAULT_LENGTH{get;set;}
        public string DATA_DEFAULT{get;set;}
        public string NUM_DISTINCT{get;set;}
        public string LOW_VALUE{get;set;}
        public string HIGH_VALUE{get;set;}
        public string DENSITY{get;set;}
        public string NUM_NULLS{get;set;}
        public string NUM_BUCKETS{get;set;}
        public string LAST_ANALYZED{get;set;}
        public string SAMPLE_SIZE{get;set;}
        public string CHARACTER_SET_NAME{get;set;}
        public string CHAR_COL_DECL_LENGTH{get;set;}
        public string GLOBAL_STATS{get;set;}
        public string USER_STATS{get;set;}
        public string AVG_COL_LEN{get;set;}
        public string CHAR_LENGTH{get;set;}
        public string CHAR_USED{get;set;}
        public string V80_FMT_IMAGE{get;set;}
        public string DATA_UPGRADED{get;set;}
        public string HIDDEN_COLUMN{get;set;}
        public string VIRTUAL_COLUMN{get;set;}
        public string SEGMENT_COLUMN_ID{get;set;}
        public string INTERNAL_COLUMN_ID{get;set;}
        public string HISTOGRAM{get;set;}
        public string QUALIFIED_COL_NAME{get;set;}

    }
}