using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KyTucXaDHBK.Models.bo
{
    public class NhaBO
    {
        DataContext context = new DataContext();
        public List<Nha> getListNha()
        {
            return context.Nhas.ToList();
        }
    }
}