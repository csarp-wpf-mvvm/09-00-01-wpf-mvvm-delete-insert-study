using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Responses
{
    public class ControllerResponse : ErrorStore
    {
        public bool IsSuccess => !HasError;

        public ControllerResponse() : base() { }
    }
}
