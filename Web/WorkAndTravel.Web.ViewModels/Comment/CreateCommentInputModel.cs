namespace WorkAndTravel.Web.ViewModels.Comment
{
    public class CreateCommentInputModel
    {
        public string Content { get; set; }

        public int WorkPostId { get; set; }

        public int ParentId { get; set; }
    }
}
