using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Abstracrt
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);

    }
}
