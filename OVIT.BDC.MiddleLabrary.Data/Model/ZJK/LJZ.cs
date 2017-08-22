using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVIT.BDC.MiddleLabrary.Data.Model.ZJK
{
    public class LJZ
    {
        //逻辑幢编码  
        [Key]
        public string LJZBM{get;set;}
        //逻辑幢号  
        public string LJZH{get;set;}
        //幢编码  
        public string ZBM{get;set;}
        //幢号  
        public string ZH{get;set;}
        //门牌号  
        public string MPH{get;set;}
        //预测建筑面积  
        public string YCJZMJ{get;set;}
        //预测地下面积  
        public string YCDXMJ{get;set;}
        //预测其它面积  
        public string YCQTMJ{get;set;}
        //实测建筑面积  
        public string SCJZMJ{get;set;}
        //实测地下面积  
        public string SCDXMJ{get;set;}
        //实测其它面积  
        public string SCQTMJ{get;set;}
        //竣工日期  
        public string JGRQ{get;set;}
        //房屋结构1  
        public string FWJG1{get;set;}
        //房屋结构2  
        public string FWJG2{get;set;}
        //房屋结构3  
        public string FWJG3{get;set;}
        //建筑物状态  
        public string JZWZT{get;set;}
        //房屋用途1  
        public string FWYT1{get;set;}
        //房屋用途2  
        public string FWYT2{get;set;}
        //房屋用途3  
        public string FWYT3{get;set;}
        //总层数  
        public string ZCS{get;set;}
        //地上层数  
        public string DSCS{get;set;}
        //地下层数  
        public string DXCS{get;set;}
        //备注  
        public string BZ{get;set;}
        //自然幢号  
        public string ZRZH{get;set;}
        //数据获取标识  
        public int SJHQBS {get;set;}
        //数据获取时间  
        public DateTime SJHQSJ{get;set;}
        //数据推送时间  
        public DateTime SJSCSJ {get;set;}
        //操作类型  
        public int CZLX{get;set;}

    }
}
