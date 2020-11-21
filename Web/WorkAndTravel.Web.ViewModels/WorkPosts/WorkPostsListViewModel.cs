namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using System;
    using System.Collections.Generic;

    public class WorkPostsListViewModel
    {
        public IEnumerable<WorkPostInListViewModel> WorkPosts { get; set; }

        public int PageNumber { get; set; }

        public int WorkPostsCount { get; set; }

        public int ItemsPerPage { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.WorkPostsCount / this.ItemsPerPage);
    }
}
