using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    interface IStartUp
    {
        void Start();
        void Start(List<String> l, List<string> r);
        void Start(DataTable table);
    }
}
