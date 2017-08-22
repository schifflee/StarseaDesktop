using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVIT.BDC.MiddleLabrary.Data.Model.ZJK
{
    public class C
    {
        //层号  
        [Key, Column(Order = 1)]
        public string CH{get;set;}
        //幢号  
        public string ZH{get;set;}
        //逻辑幢号  
        public string LJZH{get;set;}
        //实际层  
        public string SJC{get;set;}
        //名义层  
        public string MYC{get;set;}
        //层建筑面积  
        public string CJZMJ{get;set;}
        //层套内建筑面积  
        public string CTNJZMJ{get;set;}
        //层阳台面积  
        public string CYTMJ{get;set;}
        //层共有建筑面积  
        public string CGYJZMJ{get;set;}
        //层分摊建筑面积  
        public string CFTJZMJ{get;set;}
        //层半墙面积  
        public string CBQMJ{get;set;}
        //层高  
        public string CG{get;set;}
        //水平投影面积  
        public string SPTYMJ{get;set;}
        //自然幢号  
        [Key, Column(Order = 0)]
        public string ZRZH{get;set;}

    }
}
