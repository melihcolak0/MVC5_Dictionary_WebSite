using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AbilityCard
    {
        [Key]
        public int CardId { get; set; }

        [StringLength(50)]
        public string NameSurname { get; set; }

        [StringLength(150)]
        public string Information { get; set; }

        [StringLength(50)]
        public string Ability1 { get; set; }
        
        public int Ability1Rate { get; set; }

        [StringLength(50)]
        public string Ability2 { get; set; }

        public int Ability2Rate { get; set; }

        [StringLength(50)]
        public string Ability3 { get; set; }

        public int Ability3Rate { get; set; }

        [StringLength(50)]
        public string Ability4 { get; set; }

        public int Ability4Rate { get; set; }

        [StringLength(300)]
        public string SocialMediaLink1 { get; set; }

        [StringLength(300)]
        public string SocialMediaLink2 { get; set; }

        [StringLength(300)]
        public string SocialMediaLink3 { get; set; }
    }
}
