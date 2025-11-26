using CommunityToolkit.Mvvm.Input;
using NABE_Mobile.Models;

namespace NABE_Mobile.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}