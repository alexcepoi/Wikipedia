using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wikipedia.Data
{
    public partial class Article
    {
        public string Name
        {
            get
            {
                return (from ver in this.Versions
                        orderby ver.CreateDate
                        select ver.Name).FirstOrDefault();
            }
        }
    }
}