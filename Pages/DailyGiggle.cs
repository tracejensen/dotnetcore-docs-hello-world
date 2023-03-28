using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcoresample.Pages;

public class DailyGiggleModel : PageModel
{
    private readonly ILogger<DailyGiggleModel> _logger;

    public DailyGiggleModel(ILogger<DailyGiggleModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

