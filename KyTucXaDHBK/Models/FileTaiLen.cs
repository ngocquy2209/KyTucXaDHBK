using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models
{
    [Table("tblFILETAILEN")]
    public class FileTaiLen
    {
        [Key]
        public string idFileTaiLen { set; get; }
        public string tenFile { set; get; }
        public string anhFile { set; get; }
        public string link { set; get; }
        public string moTa { set; get; }
        public int loaiFile { set; get; }
        public string idTaiKhoan { set; get; }
        [ForeignKey("idTaiKhoan")]
        public virtual TaiKhoanNhanVien TaiKhoan { set; get; }
        public FileTaiLen() { }
        public FileTaiLen(string idFileTaiLen, string tenFile, string anhFile, string link, string moTa,
            int loaiFile, string idTaiKhoan)
        {
            this.idFileTaiLen = idFileTaiLen;
            this.tenFile = tenFile;
            this.anhFile = anhFile;
            this.link = link;
            this.moTa = moTa;
            this.loaiFile = loaiFile;
            this.idTaiKhoan = idTaiKhoan;
        }

    }
}