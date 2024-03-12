﻿using EmployeeMVC.Models.Domain;

namespace EmployeeMVC.Repository.Interface
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikes(Guid blogPostId); 
        Task<BlogPostLike>AddLikeForBlog(BlogPostLike blogPostLike);
    }
} 

