using Microsoft.AspNetCore.Mvc.RazorPages;

public class HearingModel : PageModel
{
    private readonly ILogger<HearingModel> _logger;

    public HearingModel(ILogger<HearingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}