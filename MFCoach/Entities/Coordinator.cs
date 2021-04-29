using System.ComponentModel.DataAnnotations;

namespace MFCoach.Entities
{
    public class Coordinator
    {
        
        #region 
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string CellPhoneNumber { get; set; }

        public string Photo { get; set; }

        public string Email { get; set; }

        public string FullName { get; }
        #endregion 
    }
}
