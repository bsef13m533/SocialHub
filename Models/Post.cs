//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int PostId { get; set; }

        [Required(ErrorMessage = "This Field is Required.")]
        public string PostMsg { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public System.DateTime Date { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual User User { get; set; }
    }
}
