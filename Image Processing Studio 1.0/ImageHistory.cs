using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Processing_Studio_1._0
{
    class ImageHistory
    {
        private string filename;
        private Stack<string> histroy;

        public string Filename
        {
            get { return filename; }
        }

        public Stack<string> History
        {
            get { return histroy; }
        }

        public ImageHistory(string filename)
        {
            this.filename = filename;
            histroy = new Stack<string>();
        }

        public void addToHistory(string operation)
        {
            histroy.Push(operation);
        }
    }
}
