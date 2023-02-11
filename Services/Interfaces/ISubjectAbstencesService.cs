using MAEWebApp.Models.ViewModels;

namespace MAEWebApp.Services.Interfaces
{
    public interface ISubjectAbstencesService
    {
        public List<SubjectViewModel> GetAll();
    }
}
