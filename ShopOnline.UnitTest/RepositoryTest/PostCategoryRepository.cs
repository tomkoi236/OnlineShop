﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Data.Infrastructure;
using OnlineShop.Data.Repositories;
using ShopOnline.Model.Models;
using System.Linq;

namespace ShopOnline.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DBFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(7, list.Count);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-Category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.ID);

        }
    }
}