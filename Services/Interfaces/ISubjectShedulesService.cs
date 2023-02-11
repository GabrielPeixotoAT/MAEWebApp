using MAEWebApp.Models.ViewModels;

namespace MAEWebApp.Services.Interfaces
{
    public interface ISubjectShedulesService : IService
    {
        public List<ShedulesViewModel> ToSheduleView();
    }
}
