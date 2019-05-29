using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class UsersModel
    {
        [Display(Name = "Возраст")]
        [Range(16, 60, ErrorMessage = "Регистрация доступна лицам от 16 до 60 лет")]
        public int age { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Необходимо ввести имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Необходимо ввести фамилию")]
        public string surname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Необходимо ввести email адрес")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Подтверждение Email")]
        [Compare("Email", ErrorMessage = "Поля Email не совпадают")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Необходимо ввести пароль")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Пароль должен быть не менее 4 символов и не более 50")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Поля пароля не совпадают")]
        public string ConfirmPassword { get; set; }



    }
}