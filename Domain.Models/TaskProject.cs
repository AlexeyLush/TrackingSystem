using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class TaskProject
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Заполните поле")]
        public string Title { get; set; }
        [Display(Name = "Начало")]
        [Required(ErrorMessage = "Заполните поле")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Конец")]
        [Required(ErrorMessage = "Заполните поле")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Тип задачи")]
        [Required(ErrorMessage = "Заполните поле")]
        public TaskType TaskType { get; set; }
        [Display(Name = "Пользователь")]
        [Required(ErrorMessage = "Заполните поле")]
        public Guid UserId { get; set; }
        [Display(Name = "Проект")]
        [Required(ErrorMessage = "Заполните поле")]
        public Guid ProjectId { get; set; }

        public bool isEnd { get; set; }

 
    }
}
