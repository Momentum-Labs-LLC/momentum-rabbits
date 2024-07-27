using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Momentum.NodaTime.Clock;
using Momentum.Rabbits.Api.Rabbits.ViewModels;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;
using Momentum.Rabbits.Models;
using NodaTime.Extensions;

namespace Momentum.Rabbits.Api.Rabbits
{
    [ApiController]
    [Authorize]
    [Route("v1/rabbits")]
    public class RabbitController : Controller
    {
        private readonly IClockService _clockService;
        private readonly IDynamoDbRabbitService _rabbitService;
        private readonly ILogger _logger;

        public RabbitController(
            IDynamoDbRabbitService rabbitService,
            IClockService clockService,
            ILogger<RabbitController> logger)
        {
            _rabbitService = rabbitService ?? throw new ArgumentNullException(nameof(rabbitService));
            _clockService = clockService ?? throw new ArgumentNullException(nameof(clockService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        } // end method

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            IActionResult result = NotFound();

            var rabbit = await _rabbitService.GetAsync(id, token).ConfigureAwait(false);
            if(rabbit != null)
            {
                result = Ok(rabbit);
            } // end if
            
            return Ok(rabbit);
        } // end method

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] RabbitFieldsViewModel viewModel,
            CancellationToken token = default)
        {
            var rabbit = new Rabbit()
            {
                Name = viewModel.Name,
                BirthTimestamp = viewModel.BirthDate.ToInstant(),
                PaternalId = viewModel.PaternalId,
                MaternalId = viewModel.MaternalId,
                LastUpdatedOn = _clockService.Now,
                //UserId = base.User.
                //LastUpdatedBy = base.User
            };

            var createdRabbit = await _rabbitService.CreateAsync(rabbit, token).ConfigureAwait(false);

            return Ok(createdRabbit);
        } // end method
    } // end class
} // end namespace