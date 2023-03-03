using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace LlenadoDataGridView
{
    internal class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

       
        public Persona(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
