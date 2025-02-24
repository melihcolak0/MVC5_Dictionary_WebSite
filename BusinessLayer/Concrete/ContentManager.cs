using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public void AddContentBL(Content content)
        {
            _contentDal.Insert(content);
        }

        public void DeleteContentBL(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public List<Content> GetListBySearch(string p)
        {
            return _contentDal.List(x => x.ContentValue.Contains(p));
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentDal.List(x => x.WriterId == id);
        }

        public void UpdateContentBL(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
