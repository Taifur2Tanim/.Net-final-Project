using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneGo.Controllers
{
    public class UserReviewController : ApiController
    {
        [HttpGet]
        [Route("api/userreview/all")]
        public HttpResponseMessage UserReviews()
        {
            try
            {
                var data = UserReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/userreview/{id}")]
        public HttpResponseMessage UserReview(int Id)
        {
            try
            {
                var data = UserReviewService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/userreview/create")]
        public HttpResponseMessage Create(UserReviewDTO data)
        {
            try
            {
                var data1 = UserReviewService.Create(data);
                return Request.CreateResponse(HttpStatusCode.OK, data1);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPut]
        [Route("api/userreview/update")]
        public HttpResponseMessage Update(UserReviewDTO data)
        {
            var exm = UserReviewService.Get(data.UserReviewID);
            if (exm != null)
            {
                try
                {
                    var data1 = UserReviewService.Update(data);
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
        [Route("api/userreview/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exm = UserReviewService.Get(Id);
            if (exm != null)
            {
                try
                {
                    var data = UserReviewService.Delete(Id);
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

