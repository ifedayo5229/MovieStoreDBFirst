using System.ComponentModel.DataAnnotations;

namespace movieAPP.Models  
{
    public class MovieViewModel
    {
        public string Title { get; set; }
        public string Director { get; set; }
        
        public string YearReleased { get; set; }

        
    }
}