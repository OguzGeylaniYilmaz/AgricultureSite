using System.ComponentModel.DataAnnotations;

namespace AgricultureSite.App.Models
{
    public class AddServiceViewModel
    {
        [Required(ErrorMessage = "Title field can not be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description field can not be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Image field can not be empty")]
        public string Image { get; set; }
    }
}
