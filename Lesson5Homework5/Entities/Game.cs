using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int UnitPrice { get; set; }

    }
}
