﻿using System.Linq;
using System.Threading.Tasks;
using NimblePros.DotNetConf.Core.ProjectAggregate;
using NimblePros.DotNetConf.Core.ProjectAggregate.Specifications;
using NimblePros.DotNetConf.SharedKernel.Interfaces;
using NimblePros.DotNetConf.Web.ApiModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NimblePros.DotNetConf.Web.Pages.ToDoRazorPage;

public class IndexModel : PageModel
{
    private readonly IRepository<Project> _repository;

    [BindProperty(SupportsGet = true)]
    public int ProjectId { get; set; }
    public string Message { get; set; } = "";

    public ProjectDTO Project { get; set; }

    public IndexModel(IRepository<Project> repository)
    {
        _repository = repository;
    }

    public async Task OnGetAsync()
    {
        var projectSpec = new ProjectByIdWithItemsSpec(ProjectId);
        var project = await _repository.GetBySpecAsync(projectSpec);

        if (project == null)
        {
            Message = "No project found.";
            return;
        }

        Project = new ProjectDTO
        {
            Id = project.Id,
            Name = project.Name,
            Items = project.Items
            .Select(item => ToDoItemDTO.FromToDoItem(item))
            .ToList()
        };
    }
}
