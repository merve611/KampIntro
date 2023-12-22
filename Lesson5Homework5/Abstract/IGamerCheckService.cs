using Lesson5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
