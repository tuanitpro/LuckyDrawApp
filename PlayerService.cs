using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    public interface IPlayerService
    {
        List<Player> ListPlayer();
        List<Player> ListPlayer(int source);
    }
    public class PlayerService : IPlayerService
    {
        public List<Player> ListPlayer()
        {
            return ListPlayer(2);
        }
        public List<Player> ListPlayer(int source)
        {
            if (source == 1) return PlayerFromExcelFile();
            return BuildData();
        }
        private List<Player> PlayerFromExcelFile()
        {
            return new List<Player>();
        }
        private List<Player> BuildData()
        {
            var list = new List<Player>();
            List<string> winners = new List<string> { "Lê Thanh Tuấn", "Nguyễn Lê Tuân", "Nguyễn Trãi", "Lê Lợi", "Trần Hưng Đạo", "Định Bộ Lĩnh", "Hùng Vương" };
            foreach (var item in winners)
            {
                Random r = new Random();
                list.Add(new Player
                {
                    Number = r.Next(100000, 999999).ToString(),
                    Name = item + r.Next(0,99).ToString(),
                    Win = 0,
                });
            }
            foreach (var item in winners)
            {
                Random r = new Random();
                list.Add(new Player
                {
                    Number = r.Next(100000, 999999).ToString(),
                    Name = item,
                    Win = 0,
                });
            }
            
            return list;
        }
    }
}
