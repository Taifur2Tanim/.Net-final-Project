using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneGo.Controllers
{
    public class WishProductController : ApiController
    {
        [HttpGet]
        [Route("api/wishproduct/all")]
        public HttpResponseMessage WishProducts()
        {
            try
            {
                var data = WishProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/wishproduct/{id}")]
        public HttpResponseMessage WishProduct(int Id)
        {
            try
            {
                var data = WishProductService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/wishproduct/create")]
        public HttpResponseMessage Create(WishProductDTO data)
        {
            try
            {
                var data1 = WishProductService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("api/wishproduct/update")]
        public HttpResponseMessage Update(WishProductDTO data)
        {
            var exm = WishProductService.Get(data.WishlistID);
            if (exm != null)
            {
                try
                {
                    var data1 = WishProductService.Update(data);
                    return Request.CreateResponse(HttpStatusCode.OK, data1);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Not Found");
            }
        }

        [HttpDelete]
        [Route("api/wishproduct/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = WishProductService.Get(Id);
            if (exm != null)
            {
                try
                {
                    var data = WishProductService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Not Found");
            }
        }
    }
}


