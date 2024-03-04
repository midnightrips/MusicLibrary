using System.ComponentModel.DataAnnotations;

namespace MusicLibraryWebAPI.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public int Title { get; set; }
        public int Artist { get; set; }
        public int Album { get; set; }
        public int ReleaseDate { get; set; }
        public int Genre { get; set; }
    }
}
