using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Demo.Models.Repositories
{
    public interface ITrainerRepository
    {
        void AddTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        void DeleteTrainer(int id);
        Trainer GetTrainerById(int id);
        List<Trainer> GetAllTrainers();
    }

}
