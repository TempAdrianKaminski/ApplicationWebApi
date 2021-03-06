﻿using Application.BL.Common;
using Application.BL.Interfaces;
using Application.DAL.Models;
using Application.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.BL
{
    public class ModelManager :BaseManager, IModelManager
    {
        private readonly IModelsRepository modelsRepository;
        public ModelManager(IModelsRepository modelsRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.modelsRepository = modelsRepository;
        }

        public Model GetModelById(int id)
        {
            return modelsRepository.GetByID(id);
        }

        public IEnumerable<Model> GetModels()
        {
            return modelsRepository.Get();
        }

        public long InsertModel(Model model)
        {
            var modelId = modelsRepository.Insert(model);
            this.UnitOfWork.Commit();
            return modelId;
        }

        public void DeleteModel(Model model)
        {
            modelsRepository.Delete(model);
            this.UnitOfWork.Commit();
        }

        public Model UpdateModel(Model model)
        {
            modelsRepository.Update(model);
            this.UnitOfWork.Commit();
            return model;
        }


    }
}
