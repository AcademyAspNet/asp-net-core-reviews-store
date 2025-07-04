using System.ComponentModel.DataAnnotations;

namespace OnlineStoreReviews.Models.Views
{
    public class FeaturesViewModel
    {
        [Display(Name = "Имя")]
        public string? FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [DataType(DataType.Time)]
        public string? LastName { get; set; }
    }
}
