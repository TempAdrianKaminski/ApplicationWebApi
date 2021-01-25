
using Application.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.BL.Interfaces
{
    public interface IModelManager
    {
        Model GetModelById(int id);

        IEnumerable<Model> GetModels();
        long InsertModel(Model model);
        void DeleteModel(Model model);
        Model UpdateModel(Model model);
        

    }
}
