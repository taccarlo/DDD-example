using System.Linq;
using System.Threading.Tasks;
using NimblePros.DotNetConf.Core;
using NimblePros.DotNetConf.Core.ProjectAggregate;
using NimblePros.DotNetConf.Core.ProjectAggregate.Specifications;
using NimblePros.DotNetConf.SharedKernel.Interfaces;
using NimblePros.DotNetConf.Web.ApiModels;
using NimblePros.DotNetConf.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace NimblePros.DotNetConf.Web.Controllers;

[Route("[controller]")]
public class ProjectController : Controller
{
    private readonly IRepository<Project> _projectRepository;

    public ProjectController(IRepository<Project> projectRepository)
    {
        _projectRepository = projectRepository;
    }

    // GET project/{projectId?}
    [HttpGet("{projectId:int}")]
    public async Task<IActionResult> Index(int projectId = 1)
    {
        var spec = new ProjectByIdWithItemsSpec(projectId);
        var project = await _projectRepository.GetBySpecAsync(spec);

        var dto = new ProjectViewModel
        {
            Id = project.Id,
            Name = project.Name,
            Items = project.Items
                        .Select(item => ToDoItemViewModel.FromToDoItem(item))
                        .ToList()
        };
        return View(dto);
    }
}
