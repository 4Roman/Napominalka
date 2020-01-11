using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Выведение_данных_в_datagridview
{
    public class Note
    {
        public Note()
        {
        }

        public DateTime Date { get; set; } = new DateTime();
        public string TextNote { get; set; } = string.Empty;
    }
}
