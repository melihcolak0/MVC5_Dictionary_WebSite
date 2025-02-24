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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;       

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer GetById(int id)
        {
            return _writerDal.Get(x => x.WriterId == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public Writer GetWriter(Writer p)
        {
            return _writerDal.GetWriter(p);
        }

        public int GetWriterByALetterInName(string words)
        {
            return _writerDal.GetWriterByALetterInName(words);
        }

        public int GetWriterId(string p)
        {            
            return _writerDal.GetWriterId(p);
        }

        public void UpdateWriter(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
