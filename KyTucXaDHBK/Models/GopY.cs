using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblGOPY")]
    public class GopY
    {
        [Key]
        public string idGopY { set; get; }
        public string tieuDe { set; get; }
        public string noiDung { set; get; }
        public string nguoiGopY { set; get; }
        public DateTime ngayGui { set; get; }
        public bool daDoc { set; get; }
        public bool daPhanHoi { set; get; }
        public GopY() { }
        public GopY(string idGopY, string tieuDe, string noiDung, string nguoiGopY,
            DateTime ngayGui, bool daDoc, bool daPhanHoi)
        {
            this.idGopY = idGopY;
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.nguoiGopY = nguoiGopY;
            this.ngayGui = ngayGui;
            this.daDoc = daDoc;
            this.daPhanHoi = daPhanHoi;
        }
    }
}