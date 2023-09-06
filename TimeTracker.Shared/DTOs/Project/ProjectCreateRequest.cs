using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.DTOs.Project
{
    public record struct ProjectCreateRequest(        
            string Name,
            string? Description,
            DateTime? StartDate,
            DateTime? EndDate
        );
}
