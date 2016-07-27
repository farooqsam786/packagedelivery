using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.API.Model
{
    public interface IDto
    {
        Guid Key { get; set; }
    }
}
