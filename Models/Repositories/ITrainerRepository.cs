using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Demo.Models.Repositories
{
    public interface ITrainerRepository
    {
        Trainer GetTrainerById(int id);
        IEnumerable<Trainer> GetAllTrainers();
        void AddTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        void DeleteTrainer(int id);
    }

}
