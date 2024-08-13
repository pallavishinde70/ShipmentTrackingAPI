using Microsoft.AspNetCore.Mvc;
using ShipmentTrackingApi.Data;
using ShipmentTrackingApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShipmentTrackingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipmentsController : ControllerBase
    {
        private readonly ShipmentRepository _shipmentRepository;

        public ShipmentsController(ShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        [HttpGet("status")]
        public async Task<ActionResult<IEnumerable<ShipmentStatus>>> GetLatestShipmentStatusByDateRange(DateTime startDate, DateTime endDate)
        {
            var result = await _shipmentRepository.GetLatestShipmentStatusByDateRangeAsync(startDate, endDate);
            return Ok(result);
        }
    }
}
