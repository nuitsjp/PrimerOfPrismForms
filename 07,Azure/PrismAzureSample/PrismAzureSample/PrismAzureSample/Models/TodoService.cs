using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismAzureSample.Models
{
    public class TodoService : ITodoService
    {
        private bool _isInitialized;
        public void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
            }
        }
    }
}
