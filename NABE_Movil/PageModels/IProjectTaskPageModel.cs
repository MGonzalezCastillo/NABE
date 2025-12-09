using CommunityToolkit.Mvvm.Input;
using NABE_Movil.Models;

namespace NABE_Movil.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}