using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartComplaintManagement.Application.Service;

namespace SmartComplaintManagment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComplaintController : ControllerBase
    {
        private readonly IComplaintService _complaintService;

        public ComplaintController(IComplaintService complaintService)
        {
            _complaintService = complaintService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateComplaint(string title, string description)
        {
            var result = await _complaintService.CreateComplaint(title, description);
            return Ok(result);
        }
    }
}
