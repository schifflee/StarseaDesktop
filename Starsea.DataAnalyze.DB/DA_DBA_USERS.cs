using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starsea.DataAnalyze.DB
{
    public class DA_DBA_USERS
    {
        [Key]
        public string ID { get; set; }
        //Name of the user  
        public string USERNAME { get; set; }
        //ID number of the user  

        public string USER_ID { get; set; }
        //Deprecated from 11.2 -- use AUTHENTICATION_TYPE instead  
        public string PASSWORD { get; set; }
        //  
        public string ACCOUNT_STATUS { get; set; }
        //  
        public string LOCK_DATE { get; set; }
        //  
        public string EXPIRY_DATE { get; set; }
        //Default tablespace for data  
        public string DEFAULT_TABLESPACE { get; set; }
        //Default tablespace for temporary tables  
        public string TEMPORARY_TABLESPACE { get; set; }
        //User creation date  
        public string CREATED { get; set; }
        //User resource profile name  
        public string PROFILE { get; set; }
        //User's initial consumer group  
        public string INITIAL_RSRC_CONSUMER_GROUP { get; set; }
        //User external name  
        public string EXTERNAL_NAME { get; set; }
        //Versions of encrypted passwords  
        public string PASSWORD_VERSIONS { get; set; }
        //Whether editions are enabled for this user  
        public string EDITIONS_ENABLED { get; set; }
        // 
        public string AUTHENTICATION_TYPE { get; set; }

    }
}
