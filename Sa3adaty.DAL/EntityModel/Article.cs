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
    
    public partial class Article
    {
        public Article()
        {
            this.ArticleCategories = new HashSet<ArticleCategory>();
            this.ArticleImages = new HashSet<ArticleImage>();
            this.Comments = new HashSet<Comment>();
            this.Likes = new HashSet<Like>();
            this.ArticleTags = new HashSet<ArticleTag>();
        }
    
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public bool IsPublished { get; set; }
        public System.DateTime AddDate { get; set; }
        public System.DateTime PublishDate { get; set; }
        public int NumberOfViews { get; set; }
        public string URL { get; set; }
    
        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
        public virtual ICollection<ArticleImage> ArticleImages { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
        public virtual Author Author { get; set; }
    }
}
