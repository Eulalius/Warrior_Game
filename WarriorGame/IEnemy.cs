using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    public interface IDescription
    {
        protected string? Description { get; set; }
        public string GetDescription(IDescription character);
    }
    
    public interface IEnvironmentColor
    {

    }
}
