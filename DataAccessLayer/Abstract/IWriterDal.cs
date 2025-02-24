using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal : IRepository<Writer>
    {
        int GetWriterByALetterInName(string word);

        Writer GetWriter(Writer p);

        int GetWriterId(string p);
    }
}
