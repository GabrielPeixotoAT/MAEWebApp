using MAEWebApp.MAE_Api;
using MAEWebApp.Models.ViewModels;
using MAEWebApp.Services.Interfaces;

namespace MAEWebApp.Services
{
    public class SubjectAbstencesService : ISubjectAbstencesService
    {
        public List<SubjectViewModel> GetAll()
        {
            Task<List<SubjectViewModel>> response = ApiRequest.Get("https://maeapi.azurewebsites.net/Abstence/percents");

            return response.Result;
        }
    }
}
