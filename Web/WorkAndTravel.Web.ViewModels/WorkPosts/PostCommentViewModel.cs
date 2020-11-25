namespace WorkAndTravel.Web.ViewModels.Comment
{
    using System;

    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class PostCommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Comment { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUserName{ get; set; }
    }
}
