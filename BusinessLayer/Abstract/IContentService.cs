using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();

        List<Content> GetListBySearch(string p);

        List<Content> GetListByWriter(int id);

        List<Content> GetListByHeadingId(int id);
        
        void AddContentBL(Content content);

        Content GetById(int id);

        void DeleteContentBL(Content content);

        void UpdateContentBL(Content content);
    }
}
