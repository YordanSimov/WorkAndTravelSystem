namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using System.Collections.Generic;

    public class WorkPostsListViewModel : PagingViewModel
    {
        public IEnumerable<WorkPostInListViewModel> WorkPosts { get; set; }
    }
}
