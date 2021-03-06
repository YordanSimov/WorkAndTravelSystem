﻿namespace WorkAndTravel.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using WorkAndTravel.Data.Common.Repositories;
    using WorkAndTravel.Data.Models;
    using WorkAndTravel.Services.Mapping;
    using WorkAndTravel.Web.Cloudinary;
    using WorkAndTravel.Web.ViewModels;
    using WorkAndTravel.Web.ViewModels.WorkPosts;

    public class WorkPostsService : IWorkPostsService
    {
        private readonly IDeletableEntityRepository<WorkPost> workPostRepository;
        private readonly IRepository<Address> addressRepository;
        private readonly IRepository<City> cityRepository;
        private readonly Cloudinary cloudinary;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public WorkPostsService(
            IDeletableEntityRepository<WorkPost> workPostRepository,
            IRepository<Address> addressRepository,
            IRepository<City> cityRepository,
            Cloudinary cloudinary,
            IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.workPostRepository = workPostRepository;
            this.addressRepository = addressRepository;
            this.cityRepository = cityRepository;
            this.cloudinary = cloudinary;
            this.usersRepository = usersRepository;
        }

        public async Task CreateAsync(CreateWorkPostsInputModel input, string userId)
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

            foreach (var image in input.Images)
            {
                if (image != null)
                {
                    var resultUrl = await Cloud.UploadAsync(this.cloudinary, image);

                    var imageCloud = new Image
                    {
                        AddedByUserId = userId,
                        WorkPost = workPost,
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

        public IEnumerable<T> GetAll<T>(int page, int postsPerPage = 8)
        {
          return this.workPostRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public IEnumerable<T> SortByDate<T>(int page, int postsPerPage = 8)
        {
            return this.workPostRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public IEnumerable<T> SortByName<T>(int page, int postsPerPage = 8)
        {
            return this.workPostRepository
                .AllAsNoTracking()
                .OrderBy(x => x.Title)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public IEnumerable<T> SortBySalary<T>(int page, int postsPerPage = 8)
        {
            return this.workPostRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.PaymentPerDay)
                .Skip((page - 1) * postsPerPage).Take(postsPerPage)
                .To<T>().ToList();
        }

        public T GetById<T>(int id)
        {
            return this.workPostRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }

        public int GetCount()
        {
            return this.workPostRepository
                .All()
                .Count();
        }

        public async Task AddAsync(string userId, int postId)
        {
            var workPost = this.workPostRepository.All().Where(x => x.Id == postId).FirstOrDefault();
            var user = this.usersRepository.All().Where(x => x.Id == userId).FirstOrDefault();

            workPost.AppliedUsersWorkPosts.Add(new AppliedUsersWorkPosts
            {
                ApplicationUserId = user.Id,
                WorkPostId = workPost.Id,
            });

            await this.workPostRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetByCityName<T>(string cityName)
        {
            return this.workPostRepository
                .All()
                .Where(x => x.City.Name == cityName)
                .To<T>()
                .ToList();
        }

        public IEnumerable<T> GetTopThreePosts<T>()
        {
            return this.workPostRepository
                .All()
                .OrderByDescending(x => x.Ratings.Average(a => a.Value))
                .Take(3)
                .To<T>()
                .ToList();
        }
    }
}
