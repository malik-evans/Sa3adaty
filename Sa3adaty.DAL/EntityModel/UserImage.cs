//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sa3adaty.DAL.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserImage
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int UserId { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
