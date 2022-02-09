using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
    public interface IFormMain
    {
        void Add();
        void Delete();
        void RefreshData();
        void New();
        bool Validate();
       
    }
}
