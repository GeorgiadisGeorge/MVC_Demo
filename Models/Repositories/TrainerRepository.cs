using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models.Repositories
{
    public class TrainerRepository : ITrainerRepository
    {
        private List<Trainer> _trainers;

        public TrainerRepository()
        {
            _trainers = new List<Trainer>();
        }

        public void AddTrainer(Trainer trainer)
        {
            _trainers.Add(trainer);
        }

        public void UpdateTrainer(Trainer trainer)
        {
            var existingTrainer = _trainers.FirstOrDefault(t => t.Id == trainer.Id);
            if (existingTrainer != null)
            {
                existingTrainer.FirstName = trainer.FirstName;
                existingTrainer.LastName = trainer.LastName;
                existingTrainer.Email = trainer.Email;
                existingTrainer.PhoneNumber = trainer.PhoneNumber;
                existingTrainer.Skills = trainer.Skills;
            }
        }

        public void DeleteTrainer(int id)
        {
            var trainerToDelete = _trainers.FirstOrDefault(t => t.Id == id);
            if (trainerToDelete != null)
            {
                _trainers.Remove(trainerToDelete);
            }
        }

        public Trainer GetTrainerById(int id)
        {
            return _trainers.FirstOrDefault(t => t.Id == id);
        }

        public List<Trainer> GetAllTrainers()
        {
            return _trainers;
        }
    }

}