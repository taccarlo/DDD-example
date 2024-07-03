using System.Collections.Generic;
using NimblePros.DotNetConf.Core.ProjectAggregate;

namespace NimblePros.DotNetConf.Web.Endpoints.ProjectEndpoints;

public class ProjectListResponse
{
    public List<ProjectRecord> Projects { get; set; } = new();
}
