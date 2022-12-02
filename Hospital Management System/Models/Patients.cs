using System.ComponentModel.DataAnnotations;

namespace Hospital_Management_System.Models
{
    public class Patients
    {
        [Key]
       public int id { get; set; }  
        public string? name { get; set; }    
        public DateTime DatefBirth { get; set; }
        public int? Age { get; set; }    
       public string? HomeAddress { get; set; }  
        public string? City { get; set; }
        public string? Region { get; set; }  
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }   
        public string? Email { get; set; }
        public string? Passwrd { get; set; }
        public string? Gender { get; set; }   
        public string? Occupation { get; set; }

    }
}
