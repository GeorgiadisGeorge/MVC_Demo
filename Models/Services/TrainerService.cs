using MVC_Demo.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;

        public TrainerService(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public void AddTrainer(Trainer trainer)
        {
            _trainerRepository.AddTrainer(trainer);
        }

        public void UpdateTrainer(Trainer trainer)
        {
            _trainerRepository.UpdateTrainer(trainer);
        }

        public void DeleteTrainer(int id)
        {
            _trainerRepository.DeleteTrainer(id);
        }

        public Trainer GetTrainerById(int id)
        {
            return _trainerRepository.GetTrainerById(id);
        }

        public List<Trainer> GetAllTrainers()
        {
            return _trainerRepository.GetAllTrainers();
        }
    }

}