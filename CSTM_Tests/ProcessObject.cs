using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace CSTM_Tests
{
    public class ProcessObject : Component
    {
        public string ProcessName { set; get; }
        public int Id { set; get; }
    }
}
