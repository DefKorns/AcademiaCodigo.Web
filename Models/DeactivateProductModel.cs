using System;
using System.ComponentModel.DataAnnotations;
namespace AcademiaCodigo.Web.Models
{
    public class DeactivateProductModel
    {
        [Required]
        public Guid Version { get; set; }

    }
}