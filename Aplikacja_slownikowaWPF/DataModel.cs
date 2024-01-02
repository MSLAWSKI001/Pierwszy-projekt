using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Aplikacja_slownikowaWPF
{
    struct DataModel
    {
        public string word;
        public string definicion;
        public List<string> word_list;
        public string selected_word;
        public string definition;

        public DataModel()
        {
            word = "";
            definicion = "";
            word_list = new List<string>;
         
            selected_word = word_list.First();
        }
    }
}
