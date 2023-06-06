using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTec
{
    class Mensagens
    {
        public  DateTime Timestamp { get; set; }
        public string Text { get; set; }
        public int RemetenteId { get; set; }
        public bool Lido { get; set; }
    }
}
