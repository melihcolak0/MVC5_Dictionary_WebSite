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
    public class AbilityCardManager : IAbilityCardService
    {
        IAbilityCardDal _abilityCardDal;

        public AbilityCardManager(IAbilityCardDal abilityCardDal)
        {
            _abilityCardDal = abilityCardDal;
        }

        public List<AbilityCard> GetList()
        {
            return _abilityCardDal.List();
        }
    }
}
