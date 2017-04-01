using OnlineShop.Service;
using ShopOnline.Model.Models;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopOnline.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }
        protected HttpResponseMessage CreateHttpRespone (HttpRequestMessage requestMessage, Func<HttpResponseMessage> funcion)
        {
            HttpResponseMessage response = null;
            try
            {
                response = funcion.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validaton errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($" - Property:\"{ve.PropertyName}\",Error:\"{ve.ErrorMessage}\"");
                        
                    }
                }      
                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException);
            }
            catch (DbUpdateException dbEx)
            {

                LogError(dbEx);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException);
            }
            catch (Exception ex)
            {

                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }
        private void LogError (Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StrackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}