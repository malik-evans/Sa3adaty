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
    
    public partial class Campaign
    {
        public Campaign()
        {
            this.Tips = new HashSet<Tip>();
            this.Polls = new HashSet<Poll>();
        }
    
        public int CampaignId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Tip> Tips { get; set; }
        public virtual ICollection<Poll> Polls { get; set; }
    }
}
