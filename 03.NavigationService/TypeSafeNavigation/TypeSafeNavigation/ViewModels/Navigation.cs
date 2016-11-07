using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace TypeSafeNavigation.ViewModels
{
    public class Navigation
    {
        private readonly NavigateDestination _destination;
        private readonly NavigationParameters _parameters;

        public Navigation(NavigateDestination destination)
            : this(destination, new NavigationParameters())
        {
        }

        public Navigation(NavigateDestination destination, NavigationParameters parameters)
        {
            _destination = destination;
            _parameters = parameters;
        }

        public object this[string param]
        {
            get { return _parameters[param]; }
            set { _parameters[param] = value; }
        }

        public override string ToString()
        {
            return _destination.ToString() + _parameters.ToString();
        }
    }
}
