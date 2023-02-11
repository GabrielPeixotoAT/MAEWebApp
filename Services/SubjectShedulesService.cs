using MAEWebApp.MAE_Api;
using MAEWebApp.Models.ViewModels;
using MAEWebApp.Services.Interfaces;
using System.Collections;
using System.Linq;

namespace MAEWebApp.Services
{
    public class SubjectShedulesService : ISubjectShedulesService
    {
        public IEnumerable GetAll()
        {
            List<SubjectSheduleViewModel> result = ApiRequest<List<SubjectSheduleViewModel>>.Get(ApiWebHost.Host + "/ClassShedule").Result;

            return result;
        }

        public List<ShedulesViewModel> ToSheduleView()
        {
            List<ShedulesViewModel> shedulesViewModel = new List<ShedulesViewModel>();

            List<SubjectSheduleViewModel> subjectShedules = GetAll() as List<SubjectSheduleViewModel>;

            for(int i = 1; i < 5; i++)
            {
                //int index = (i > 1) ? i + 2 : i;

                ShedulesViewModel sheduleInBuild = new ShedulesViewModel();
                foreach (SubjectSheduleViewModel shedule in subjectShedules)
                {
                    if (shedule.shedules.Contains(i.ToString()))
                    {
                        switch (shedule.schoolDayIDFK)
                        {
                            case 1:
                                sheduleInBuild.Monday = shedule.subjectCode.ToString();
                                break;
                            case 2:
                                sheduleInBuild.Tuesday = shedule.subjectCode.ToString();
                                break;
                            case 3:
                                sheduleInBuild.Wednesday = shedule.subjectCode.ToString();
                                break;
                            case 4:
                                sheduleInBuild.Thursday = shedule.subjectCode.ToString();
                                break;
                            case 5:
                                sheduleInBuild.Friday = shedule.subjectCode.ToString();
                                break;
                            case 6:
                                sheduleInBuild.Saturday = shedule.subjectCode.ToString();
                                break;
                        }
                    }
                }
                shedulesViewModel.Add(sheduleInBuild);
            }
            
            return shedulesViewModel;
        }
    }
}
