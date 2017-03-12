using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Processing_Studio_1._0
{
    class ImageProcessingEventArgs : EventArgs
    {
        private string[] parameters;

        public string Function
        {
            get { return parameters[0]; }
        }

        public string[] Parameters
        {
            get { return parameters; }
        }

        public ImageProcessingEventArgs(string[] parameters)
        {
            this.parameters = parameters;
        }

        public override string ToString()
        {
            return string.Join(",", parameters);
        }
    }
}
