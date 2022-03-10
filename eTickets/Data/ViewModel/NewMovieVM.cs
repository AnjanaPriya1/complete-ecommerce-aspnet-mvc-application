using eTickets.Data.Base;
using eTickets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Data.ViewModel
{
    public class NewMovieVM
    {

        public int Id { get; set; }

        [Display(Name ="Movie Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Name = "Movie Price in $")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Name poster URL is Required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date Required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date Required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Movie Category is Required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is Required")]
        public List<Actor_Movie> ActorIds { get; set; }
        //public List<int> ActorIds
        //{
          //  get { return ActorIds; }
           // set { ActorIds = value; }
       // }

        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "Cinema is Required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Movie Producer is Required")]
        public int ProducerId { get; set; }

    }
}
