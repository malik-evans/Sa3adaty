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
    
    public partial class Video
    {
        public Video()
        {
            this.VideoImages = new HashSet<VideoImage>();
            this.VideoTags = new HashSet<VideoTag>();
            this.VideoComments = new HashSet<VideoComment>();
        }
    
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public System.DateTime AddDate { get; set; }
        public System.DateTime PublishDate { get; set; }
        public bool IsPublished { get; set; }
        public int NumberOfViews { get; set; }
        public string URL { get; set; }
        public string YoutubeId { get; set; }
        public Nullable<int> Duration { get; set; }
        public int CategoryId { get; set; }
    
        public virtual ICollection<VideoImage> VideoImages { get; set; }
        public virtual ICollection<VideoTag> VideoTags { get; set; }
        public virtual VideoCategory VideoCategory { get; set; }
        public virtual ICollection<VideoComment> VideoComments { get; set; }
        public virtual Author Author { get; set; }
    }
}
