using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónTareas
{
    public class TaskBlock
    {
        public float Lineas { get; set; }
        public float Rate { get; set; }
        public List<CategoryTask> categoryTasks { get; set; }
    }
}
