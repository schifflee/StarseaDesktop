using System.ComponentModel.DataAnnotations;

namespace Starsea.DataAnalyze.DB
{
    public class DA_DBA_TABLES
    {

        //Owner of the table  
        [Key]
        public string ID { get; set; }
        public string OWNER { get; set; }
        //Name of the table
        public string TABLE_NAME { get; set; }
        //Name of the tablespace containing the table  
        public string TABLESPACE_NAME { get; set; }
        //Name of the cluster, if any, to which the table belongs  
        public string CLUSTER_NAME { get; set; }
        //Name of the index-only table, if any, to which the overflow or mapping table entry belongs  public string IOT_NAME{get;set;}"//Status of the table will be UNUSABLE if a previous DROP TABLE operation failed,VALID otherwise  
        public string STATUS { get; set; }
        //Minimum percentage of free space in a block  
        public string PCT_FREE { get; set; }
        //Minimum percentage of used space in a block  
        public string PCT_USED { get; set; }
        //Initial number of transactions  
        public string INI_TRANS { get; set; }
        //Maximum number of transactions  
        public string MAX_TRANS { get; set; }
        //Size of the initial extent in bytes  
        public string INITIAL_EXTENT { get; set; }
        //Size of secondary extents in bytes  
        public string NEXT_EXTENT { get; set; }
        //Minimum number of extents allowed in the segment  
        public string MIN_EXTENTS { get; set; }
        //Maximum number of extents allowed in the segment  
        public string MAX_EXTENTS { get; set; }
        //Percentage increase in extent size  
        public string PCT_INCREASE { get; set; }
        //Number of process freelists allocated in this segment  
        public string FREELISTS { get; set; }
        //Number of freelist groups allocated in this segment  
        public string FREELIST_GROUPS { get; set; }
        //Logging attribute  
        public string LOGGING { get; set; }
        //Has table been backed up since last modification?  
        public string BACKED_UP { get; set; }
        //The number of rows in the table  
        public string NUM_ROWS { get; set; }
        //The number of used blocks in the table  
        public string BLOCKS { get; set; }
        //The number of empty (never used) blocks in the table  
        public string EMPTY_BLOCKS { get; set; }
        //The average available free space in the table  
        public string AVG_SPACE { get; set; }
        //The number of chained rows in the table  
        public string CHAIN_CNT { get; set; }
        //The average row length, including row overhead  
        public string AVG_ROW_LEN { get; set; }
        //The average freespace of all blocks on a freelist  
        public string AVG_SPACE_FREELIST_BLOCKS { get; set; }
        //The number of blocks on the freelist  
        public string NUM_FREELIST_BLOCKS { get; set; }
        //The number of threads per instance for scanning the table  
        public string DEGREE { get; set; }
        //The number of instances across which the table is to be scanned  
        public string INSTANCES { get; set; }
        //Whether the table is to be cached in the buffer cache  
        public string CACHE { get; set; }
        //Whether table locking is enabled or disabled  
        public string TABLE_LOCK { get; set; }
        //The sample size used in analyzing this table  
        public string SAMPLE_SIZE { get; set; }
        //The date of the most recent time this table was analyzed  
        public string LAST_ANALYZED { get; set; }
        //Is this table partitioned? YES or NO  
        public string PARTITIONED { get; set; }
        //If index-only table, then IOT_TYPE is IOT or IOT_OVERFLOW or IOT_MAPPING else NULL  
        public string IOT_TYPE { get; set; }
        //Can the current session only see data that it place in this object itself?  
        public string TEMPORARY { get; set; }
        //Is this table object created as part of icreate for domain indexes?  
        public string SECONDARY { get; set; }
        //Is the table a nested table?  
        public string NESTED { get; set; }
        //The default buffer pool to be used for table blocks  
        public string BUFFER_POOL { get; set; }
        //The default flash cache hint to be used for table blocks  
        public string FLASH_CACHE { get; set; }
        //The default cell flash cache hint to be used for table blocks  
        public string CELL_FLASH_CACHE { get; set; }
        //Whether partitioned row movement is enabled or disabled  
        public string ROW_MOVEMENT { get; set; }
        //Are the statistics calculated without merging underlying partitions?  
        public string GLOBAL_STATS { get; set; }
        //Were the statistics entered directly by the user?  
        public string USER_STATS { get; set; }
        //If temporary table, then duration is sys$session or sys$transaction else NULL  
        public string DURATION { get; set; }
        //Whether skip corrupt blocks is enabled or disabled  
        public string SKIP_CORRUPT { get; set; }
        //Should we keep track of the amount of modification?  
        public string MONITORING { get; set; }
        //Owner of the cluster, if any, to which the table belongs  
        public string CLUSTER_OWNER { get; set; }
        //Should we keep track of row level dependencies?  
        public string DEPENDENCIES { get; set; }
        //Whether table compression is enabled or not  
        public string COMPRESSION { get; set; }
        //Compress what kind of operations  
        public string COMPRESS_FOR { get; set; }
        //Whether table is dropped and is in Recycle Bin  
        public string DROPPED { get; set; }
        //Whether table is read only or not  
        public string READ_ONLY { get; set; }
        //Whether the table segment is created or not  
        public string SEGMENT_CREATED { get; set; }
        //The result cache mode annotation for the table  
        public string RESULT_CACHE { get; set; }

    }
}