namespace summerWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameGenre
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime EditDate { get; set; }

        [Required]
        [StringLength(128)]
        public string GameId { get; set; }

        [Required]
        [StringLength(128)]
        public string GenreId { get; set; }

        public virtual Game Game { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
