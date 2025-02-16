using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloDotnet.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
	// This method is invoked when the page is about to be rendered on the server side.
	// We use the logger to log information either to your console or to any of the sources I have configured for logging.
	_logger.LogInformation("Hello there!");
    }
}
