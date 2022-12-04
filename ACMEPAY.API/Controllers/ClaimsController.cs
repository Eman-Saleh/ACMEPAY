using ACMEPAY.DB.Interfaces;
using ACMEPAY.DB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ACMEPAY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IUnitOfWork _claimsRepository;
        public ClaimsController(IUnitOfWork claimsRepository)
        {
            _claimsRepository = claimsRepository;
        }
        [HttpGet]
        [Route("GetAllClaims")]
        public IActionResult GetAllClaims(int? Queue, int? userId)
        {
            List<FinancialClaim> Claims = new List<FinancialClaim>();
           
            //if (userId == null || userId == 0)
            //{
            //    if (Queue == null || Queue == 0)
            //    {
            //        Claims = _claimsRepository.FinancialClaims.FindAll(a => 1 == 1, null, b => b.ID, OrderBy.Descending).ToList();

            //    }
            //    else
            //    {
            //        Claims = _claimsRepository.FinancialClaims.FindAll(a => a.QueueId == Queue, null, b => b.ID, OrderBy.Descending).ToList();

            //    }
            //}
            //else
            //{
            //    Claims = _claimsRepository.FinancialClaims.FindAll(a => a.QueueId == Queue && a.CreatedBy == userId, null, b => b.ID, OrderBy.Descending).ToList();
            //    if(Queue ==6)
            //    {
            //        //Claims = _claimsRepository.FinancialClaims.FindAll(a => a.CreatedBy == userId || a.UpdatedBy == userId ||
            //        //    a.SentBy == userId || a.LastFinancialSentBy == userId || a.LastAdministrativeSentBy == userId ||
            //        //    a.LastOperationTransSentBy == userId, null, b => b.ID, OrderBy.Descending).ToList(); 
            //       var user= _claimsRepository.Users.GetByID (userId.Value);
            //        if (user != null)
            //            if(user.UserRole==6)
            //            {
            //                Claims = _claimsRepository.FinancialClaims.FindAll(a => a.SectorId  == user.SectorId , null, b => b.ID, OrderBy.Descending).ToList();
            //            }
            //            else 
            //            {
            //            Claims = _claimsRepository.FinancialClaims.FindAll(a => a.CreatedBy == userId || a.UpdatedBy == userId ||
            //                a.SentBy == userId || a.LastFinancialSentBy == userId || a.LastAdministrativeSentBy == userId ||
            //                a.LastOperationTransSentBy == userId, null, b => b.ID, OrderBy.Descending).ToList();
            //            }
            //    }
            //}

            return Ok(Claims);
        }
        [HttpGet]
        [Route("GetClaim")]
        public IActionResult GetClaim(int id, int Queue)
        {
            FinancialClaim Claim = new FinancialClaim();
            if (id == null || id == 0)
            {
                return BadRequest();
            }
            else
            {
                //Claim = _claimsRepository.FinancialClaims.Find(a => a.ID == (int)id);
                Claim = _claimsRepository.FinancialClaims.FindAll(a => a.ID == id, new[] { "FinancialClaimsDocs" , "FinancialClaimsLogs" }).ToList()[0];
            }
            // Serializing object to json data
          //  JavaScriptSerializer js = new JavaScriptSerializer();
            return Ok(Claim);
        }
        [HttpPost]
        [Route("AddClaim")]
        public IActionResult AddClaim(FinancialClaim model)
        {
            try
            {
                _claimsRepository.FinancialClaims.Add(model);
                _claimsRepository.Complete();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

      
    }

}
