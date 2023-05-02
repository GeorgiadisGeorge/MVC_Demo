using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Demo.Models.Services
{
    public interface ITrainerService
    {
        Trainer GetTrainerById(int id);
        IEnumerable<Trainer> GetAllTrainers();
        void AddTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        void DeleteTrainer(int id);
    }

}
