using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampanyService
    {
        void Add(Campany campany);
        void Update(Campany campany);
        void Delete(Campany campany);
    }
}
