using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using MAEWebApp.Services.Interfaces;
using MAEWebApp.Models;
using MAEWebApp.MAE_Api;

namespace MAEWebApp.Services
{
    public class AbstenceService : IAbstenceService
    {
        public IEnumerable GetAll()
        {
            try
            {
                List<Abstence> abstences = ApiRequest<List<Abstence>>.Get(ApiWebHost.Host + "/Abstence").Result;
                return abstences;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}