using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models.bo
{
    public class PhongBO
    {
        DataContext context = new DataContext();
        public List<Phong> getListPhong()
        {
            List<Phong> listPhong = context.Phongs.OrderBy(x=>x.tenPhong).ToList();
            return listPhong;
        }
    }
}