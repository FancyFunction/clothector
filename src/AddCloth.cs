using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FancyFunction.Clothector;

public class AddCloth
{
    private readonly ILogger<AddCloth> _logger;

    public AddCloth(ILogger<AddCloth> logger)
    {
        _logger = logger;
    }

    [Function("AddCloth")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}