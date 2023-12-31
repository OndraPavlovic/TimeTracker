﻿using TimeTracker.Shared.DTOs.Project;

namespace TimeTracker.API.Services
{
    public interface IProjectService
    {
        Task<List<ProjectResponse>> GetAllProjects();
        Task<ProjectResponse?> GetProjectById(int id);
        Task<List<ProjectResponse>> CreateProject(ProjectCreateRequest project);
        Task<List<ProjectResponse>?> UpdateProject(int id, ProjectUpdateRequest project);
        Task<List<ProjectResponse>?> DeleteProject(int id);
    }
}
