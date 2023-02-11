using MAEWebApp.MAE_Api;
using MAEWebApp.Models.ViewModels;
using MAEWebApp.Services.Interfaces;
using System.Collections;

namespace MAEWebApp.Services
{
    public class SubjectAbstencesService : ISubjectAbstencesService
    {
        public IEnumerable GetAll()
        {
            List<SubjectViewModel> response = ApiRequest<List<SubjectViewModel>>.Get("https://maeapi.azurewebsites.net/Abstence/percents").Result;

            return response;
        }
    }
}
