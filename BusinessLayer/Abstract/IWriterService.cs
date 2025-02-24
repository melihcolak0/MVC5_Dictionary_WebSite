﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();

        void AddWriter(Writer writer);

        void DeleteWriter(Writer writer);

        void UpdateWriter(Writer writer);

        Writer GetById(int id);

        Writer GetWriter(Writer p);

        int GetWriterId(string p);

        // İstatistikler
        int GetWriterByALetterInName(string word);
    }
}
