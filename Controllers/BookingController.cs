using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimplyFieldServicing.Models;

namespace SimplyFieldServicing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger, ApiContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            var bookings = _context.Bookings.ToList();
            return bookings;
        }
    }
}
