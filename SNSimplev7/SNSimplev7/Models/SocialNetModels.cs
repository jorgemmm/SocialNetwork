using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNSimplev7.Models
{
    

    public class SocialNetModels
    {

    }

    public class SocialNetContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MyMessages> MyMessages { get; set; }
        public DbSet<Contact> Contact { get; set; }

    }

    public class User
    {
        [Key, Display(Name = "ID")]
        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [Required, StringLength(40), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        public virtual Contact Contact { get; set; }


         public virtual ICollection<MyMessages> MyMessages { get; set; }
     
    }


    public class MyMessages
    {
        [Key]
        [Column(Order = 1)]
        public int UserId { get; set; }
        public virtual User Users { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ContactID { get; set; }
        public virtual Contact Contacts { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DateTimeMsg { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Contenido")]
        public string Content { get; set; }

    }


    public enum ContactRole
    {
        Unknown,        
        FriendShip        
    }

    public class Contact
    {
        [Key, Display(Name = "ContactID")]
        [ScaffoldColumn(false)]
        public int ContactID { get; set; }

        [Required, StringLength(40), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [EnumDataType(typeof(ContactRole)), Display(Name = "Estado Contacto")]
        public ContactRole role { get; set; }

        //referencias
        public virtual ICollection<MyMessages> MyMessages { get; set; }
        public virtual ICollection <User> users { get; set; }
    }



    

}