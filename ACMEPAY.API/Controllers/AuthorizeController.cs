using ACMEPAY.DB.Interfaces;
using ACMEPAY.DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACMEPAY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly IUnitOfWork _authorizeRepository;
        public AuthorizeController(IUnitOfWork authorizeRepository)
        {
            _authorizeRepository = authorizeRepository;
        }
        [HttpPost]
        [Route("authorize")]
        public IActionResult Authorize(Payment model)
        {
            try
            {
                _authorizeRepository.Payments.Add(model);
                _authorizeRepository.Complete();
                //return Ok();
                return Content("{ \"Id\":" + model.Id + ", \"Status\":Authorized }", "application/json");

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("authorize{id}/voids")]
        public IActionResult AuthorizeVoid(int Id, string OrderRefrence)
        {
            try
            {
                var _paymentDb = _authorizeRepository.Payments.GetByID(Id);
                //_paymentDb.OrderId = int.Parse(OrderRefrence);
                //_authorizeRepository.Payments.Update(_paymentDb);
                //_authorizeRepository.Complete();
                //return Ok();
                return Content("{ \"Id\":" + Id + ", \"Status\":Voided }", "application/json");

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("authorize{id}/capture")]
        public IActionResult AuthorizeCapture(int Id, string OrderRefrence)
        {
            try
            {
                var _paymentDb = _authorizeRepository.Payments.GetByID(Id);
                //_paymentDb.OrderId = int.Parse(OrderRefrence);
                //_authorizeRepository.Payments.Update(_paymentDb);
                //_authorizeRepository.Complete();
                //return Ok();
                return Content("{ \"Id\":" + Id + ", \"Status\":Captured }", "application/json");

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("authorize")]
        public IActionResult GetAllTransactions()
        {
            try
            {
                var AllTransactions = _authorizeRepository.Payments.GetAll();
                return Ok(AllTransactions);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
