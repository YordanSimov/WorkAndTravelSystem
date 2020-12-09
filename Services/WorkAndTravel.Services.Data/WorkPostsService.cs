namespace WorkAndTravel.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;
    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;
    using WorkAndTravel.Web.Cloudinary;

    public class WorkPostsService : IWorkPostsService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
        private readonly IDeletableEntityRepository<WorkPost> workPostRepository;
        private readonly IRepository<Address> addressRepository;
        private readonly IRepository<City> cityRepository;
        private readonly Cloudinary cloudinary;

        public WorkPostsService(
            IDeletableEntityRepository<WorkPost> workPostRepository,
            IRepository<Address> addressRepository,
            IRepository<City> cityRepository,
            Cloudinary cloudinary)
        {
            this.workPostRepository = workPostRepository;
            this.addressRepository = addressRepository;
            this.cityRepository = cityRepository;
            this.cloudinary = cloudinary;
        }

        public async Task CreateAsync(CreateWorkPostsInputModel input, string userId, string imagePath)
        {
            var city = this.cityRepository.All().FirstOrDefault(x => x.Name == input.City);
            if (city == null)
            {
                city = new City { Name = input.City, CountryId = input.CountryId };
            }

            var address = this.addressRepository.All().FirstOrDefault(x => x.Name == input.Address);
            if (address == null)
            {
                address = new Address { Name = input.Address, City = city };
            }

            var workPost = new WorkPost()
            {
                Title = input.Title,
                Description = input.Description,
                Requirement = input.Requirement,
                CountryId = input.CountryId,
                Address = address,
                City = city,
                PaymentPerDay = input.PaymentPerDay,
                Responsibility = input.Responsibility,
                CategoryId = input.CategoryId,
                AddedByUserId = userId,
                Providing = input.Providing,
            };

           // Directory.CreateDirectory($"{imagePath}/workposts/");

            // /wwwroot/images/workpost{id}.{ext}
            foreach (var image in input.Images)
            {
                //var extension = Path.GetExtension(image.FileName).TrimStart('.');
                //if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                //{
                //    throw new Exception($"Invalid image extension {extension}");
                //}

                //var dbImage = new Image
                //{
                //    AddedByUserId = userId,
                //    WorkPost = workPost,
                //    Extension = extension,
                //};
                //workPost.Images.Add(dbImage);

                //var physicalPath = $"{imagePath}/workposts/{dbImage.Id}.{dbImage.Extension}";
                //using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                //await image.CopyToAsync(fileStream);

                if (image != null)
                {
                    var resultUrl = await Cloud.UploadAsync(this.cloudinary, image);

                    var imageCloud = new Image
                    {
                        AddedByUserId = userId,
                        WorkPost = workPost,
                        Extension = null,
                        RemoteImageUrl = resultUrl,
                    };
                    workPost.Images.Add(imageCloud);
                }
            }

            await this.workPostRepository.AddAsync(workPost);
            await this.workPostRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var workPost = this.workPostRepository.All().FirstOrDefault(x => x.Id == id);

            this.workPostRepository.Delete(workPost);

            await this.workPostRepository.SaveChangesAsync();
        }

        public async Task EditAsync(int id, EditWorkPostInputModel input)
        {
            var workPost = this.workPostRepository.All().FirstOrDefault(x => x.Id == id);

            workPost.Title = input.Title;
            workPost.Requirement = input.Requirement;
            workPost.Providing = input.Providing;
            workPost.CategoryId = input.CategoryId;
            workPost.PaymentPerDay = input.PaymentPerDay;
            workPost.Description = input.Description;
            workPost.Responsibility = input.Responsibility;

            await this.workPostRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int postsPerPage = 12)
        {
            var posts = this.workPostRepository.AllAsNoTracking().OrderByDescending(x => x.Id)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();

            return posts;
        }

        public IEnumerable<T> SortByDate<T>(int page, int postsPerPage = 12)
        {
            return this.workPostRepository.AllAsNoTracking().OrderByDescending(x => x.CreatedOn)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public IEnumerable<T> SortByName<T>(int page, int postsPerPage = 12)
        {
            return this.workPostRepository.AllAsNoTracking().OrderBy(x => x.Title)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public IEnumerable<T> SortBySalary<T>(int page, int postsPerPage = 12)
        {
            return this.workPostRepository.AllAsNoTracking().OrderByDescending(x => x.PaymentPerDay)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public T GetById<T>(int id)
        {
            return this.workPostRepository.AllAsNoTracking().Where(x => x.Id == id).To<T>().FirstOrDefault();
        }

        public int GetCount()
        {
            return this.workPostRepository.All().Count();
        }
    }
}
