using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалста введите эмейл")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Введите верный эмейл")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Номер телефона введи заебал")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Будешь нет?")]
        public bool? WillAttend { get; set; }
    }
}
