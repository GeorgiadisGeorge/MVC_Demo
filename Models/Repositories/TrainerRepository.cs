using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models.Repositories
{
    public class TrainerRepository : ITrainerRepository
    {
        private List<Trainer> trainers = new List<Trainer>();

        public Trainer GetTrainerById(int id)
        {
            return trainers.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Trainer> GetAllTrainers()
        {
            return trainers;
        }

        public void AddTrainer(Trainer trainer)
        {
            trainer.Id = trainers.Count + 1;
            trainers.Add(trainer);
        }

        public void UpdateTrainer(Trainer trainer)
        {
            var existingTrainer = trainers.FirstOrDefault(t => t.Id == trainer.Id);
            if (existingTrainer != null)
            {
                existingTrainer.FirstName = trainer.FirstName;
                existingTrainer.Email = trainer.Email;
                existingTrainer.PhoneNumber = trainer.PhoneNumber;
            }
        }

        public void DeleteTrainer(int id)
        {
            var trainerToDelete = trainers.FirstOrDefault(t => t.Id == id);
            if (trainerToDelete != null)
            {
                trainers.Remove(trainerToDelete);
            }
        }
    }

}