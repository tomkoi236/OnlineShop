using OnlineShop.Service;
using ShopOnline.Model.Models;
using ShopOnline.Web.Infrastructure.Core;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopOnline.Web.Api
{
    [RoutePrefix("api/postCategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryServicce) :
            base(errorService)
        {
            this._postCategoryService = postCategoryServicce;
        }
        // create method
        public HttpResponseMessage Post(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpRespone(request, () =>
             {

                 HttpResponseMessage response = null;
                 if (!ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                   var category=  _postCategoryService.Add(postCategory);
                     _postCategoryService.Save();

                     response = request.CreateResponse(HttpStatusCode.Created, category);
                 }
                 return response;
             });
        }
        //update method
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpRespone(request, () =>
            {

                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpRespone(request, () =>
            {

                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpRespone(request, () =>
            {

                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                   var listCategory = _postCategoryService.GetAll();

                    response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }







    }
}