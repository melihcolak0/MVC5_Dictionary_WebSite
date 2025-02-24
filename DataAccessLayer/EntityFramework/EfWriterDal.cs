using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public Writer GetWriter(Writer p)
        {
            using (var context = new Context())  // Veritabanı Context
            {
                return context.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail &&
                x.WriterPassword == p.WriterPassword);
            }
        }

        public int GetWriterByALetterInName(string word)
        {
            using (var context = new Context())
            {
                return context.Writers.Count(x => x.WriterName.Contains(word));
            }
        }

        public int GetWriterId(string p)
        {
            using (var context = new Context())
            {
                return context.Writers.Where(x => x.WriterMail == p).Select(x => x.WriterId).FirstOrDefault();
            }
        }
    }
}
