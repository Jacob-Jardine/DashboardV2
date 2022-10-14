using Microsoft.AspNetCore.Mvc.RazorPages;

public class MembersModel : PageModel
{
    private readonly ILogger<MembersModel> _logger;

    public MembersModel(ILogger<MembersModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}