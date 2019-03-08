using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumandaKontrol
{
    public class CheckedListboxItem
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return Text.ToString();
        }
    }
}
