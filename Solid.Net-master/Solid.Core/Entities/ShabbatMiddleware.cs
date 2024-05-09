//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace Solid.Core.Entities
//{
//    public class ShabbatMiddleware
//    {
//        private readonly RequestDelegate _next;
//        private readonly ILogger<TrackMiddleware> _logger;

//        public TrackMiddleware(RequestDelegate next, ILogger<TrackMiddleware> logger)
//        {
//            _next = next;
//            _logger = logger;
//        }

//        public async Task InvokeAsync(HttpContext context)
//        {
//            var requestSeq = Guid.NewGuid().ToString();
//            _logger.LogInformation($"Request Starts {requestSeq}");
//            context.Items.Add("RequestSequence", requestSeq);
//            await _next(context);
//            _logger.LogInformation($"Request Ends {requestSeq}");
//        }
//    }
//}
