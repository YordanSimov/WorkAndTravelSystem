namespace WorkAndTravel.Web.ViewModels.WorkPosts
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;

    public class EditWorkPostInputModel : BaseWorkPostInputModel, IMapFrom<WorkPost>
    {
        public int Id { get; set; }
    }
}
