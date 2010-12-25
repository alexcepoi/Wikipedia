using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wikipedia.Data
{
    public partial class Domain
    {
        public dynamic LatestArticles
        {
            get
            {
                return (from art in this.Articles
                        orderby art.CreateDate
                        select art).Take(5);
            }
        }
    }
}