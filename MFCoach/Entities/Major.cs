using System.ComponentModel.DataAnnotations;

namespace MFCoach.Entities
{
    public class Major
    {
        #region Propiedades autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(250)]
        public string Photo { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        #endregion
    }
}
