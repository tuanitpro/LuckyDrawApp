using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    /// <summary>
    /// Player edit
    /// </summary>
    public class Player
    {
        public string Number { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int Win { get; set; } = 0;
    }
}
