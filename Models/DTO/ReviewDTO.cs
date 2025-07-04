using System.ComponentModel.DataAnnotations;

namespace OnlineStoreReviews.Models.DTO
{
    public class ReviewDTO
    {
        [Display(Name = "Ваше имя:")]
        [Required(ErrorMessage = "Укажите Ваше имя")]
        [MinLength(3, ErrorMessage = "Имя должно содержать хотя бы 3 символа")]
        public string? Author { get; set; }

        [Display(Name = "Текст отзыва:")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Текст отзыва не может быть пустым")]
        [MinLength(3, ErrorMessage = "Текст отзыва должен содержать хотя бы 3 символа")]
        public string? Text { get; set; }
    }
}
