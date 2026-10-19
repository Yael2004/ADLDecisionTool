using ADLDecisionTool.Data;
using ADLDecisionTool.Models;
using ADLDecisionTool.Services;
using Microsoft.AspNetCore.Mvc;

namespace ADLDecisionTool.Controllers;

public class HomeController : Controller
{
    private readonly DecisionService _decisionService;

    public HomeController(DecisionService decisionService)
    {
        _decisionService = decisionService;
    }

    public IActionResult Index()
    {
        var model = new DecisionViewModel
        {
            AvailableSystemTypes = ADLData.GetSystemTypes(),
            AvailableDomains = ADLData.GetDomains(),
            AvailableCharacteristics = CharacteristicData.GetCharacteristics()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Index(DecisionViewModel model)
    {
        var request = new DecisionRequest
        {
            SystemType = model.SystemType,
            Domain = model.Domain,
            Characteristics = model.Characteristics
        };

        var result = _decisionService.GetDecision(request);

        model.Recommendations = result.Recommendations;
        model.Summary = result.Summary;
        
        model.AvailableSystemTypes = ADLData.GetSystemTypes();
        model.AvailableDomains = ADLData.GetDomains();
        model.AvailableCharacteristics = CharacteristicData.GetCharacteristics();

        return View(model);
    }
}