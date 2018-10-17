
using HRP.Contracts.ServiceContracts;
using HRP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRP.Web.Controllers
{    
    public class CandidateController : Controller
    {
        private readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // GET: Candidate
        public ActionResult Index() { 
            
            List<Candidate> Candidates = _candidateService.GetCandidates();
            return View(Candidates);
        }
        public ActionResult Create()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Candidate candidate)
        {
            _candidateService.AddCandidate(candidate);                    
            return RedirectToAction("Index");
        }
    }
}