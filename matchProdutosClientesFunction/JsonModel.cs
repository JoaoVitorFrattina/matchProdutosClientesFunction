using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace matchProdutosClientesFunction
{
    public class JsonModel
    {
        public decimal probability { get; set; }
        public string tagId { get; set; }
        public string  tagName { get; set; }
    }

    public class JsonReturn
    {
        public string tag { get; set; }
        //public string prob2 { get; set; }
        //public List<string> Tags { get; set; }
    }
}
