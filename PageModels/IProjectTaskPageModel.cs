using CommunityToolkit.Mvvm.Input;
using Planing.Models;

namespace Planing.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}