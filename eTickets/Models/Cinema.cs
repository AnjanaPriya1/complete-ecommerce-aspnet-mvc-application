using eTickets.Data.Base;
using eTickets.Data.ViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage = "Logo is Required")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        //Relationships
        public List<NewMovieVM> Movies { get; set; }

    }
}
