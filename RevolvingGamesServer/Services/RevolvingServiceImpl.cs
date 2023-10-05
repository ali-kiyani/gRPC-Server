using Grpc.Core;
using RevolvingGamesServer;

namespace RevolvingGamesServer.Services
{
    public class RevolvingServiceImpl : RevolvingService.RevolvingServiceBase
    {
        private readonly ILogger<RevolvingServiceImpl> _logger;
        public RevolvingServiceImpl(ILogger<RevolvingServiceImpl> logger)
        {
            _logger = logger;
        }

        public override Task<PrimeNumberResp> CheckPrimeNmber(PrimeNumber request, ServerCallContext context)
        {
            return Task.FromResult(new PrimeNumberResp()
            {
                Id = request.Id,
                IsPrime = true
            });
        }
    }
}