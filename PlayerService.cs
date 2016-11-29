using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyDraw
{
    public interface IPlayerService
    {
        List<Player> ListPlayer();
        List<Player> ListPlayer(string source);
    }
    public class PlayerService : IPlayerService
    {
        public List<Player> ListPlayer()
        {
            return ListPlayer("");
        }
        public List<Player> ListPlayer(string source)
        {
            if (!string.IsNullOrEmpty(source)) return PlayerFromExcelFile(source);
            return BuildData();
        }
        private List<Player> PlayerFromExcelFile(string source)
        {
            var list = new List<Player>();
            if (!File.Exists(source)) return list;

            using (var package = new ExcelPackage(new FileInfo(source)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets.FirstOrDefault();

                for (int i = workSheet.Dimension.Start.Row; i <= workSheet.Dimension.End.Row; i++)
                {
                    object number = workSheet.Cells[i, 1].Value;
                    object code = workSheet.Cells[i, 2].Value;
                    object name = workSheet.Cells[i, 3].Value;
                    object note = workSheet.Cells[i, 4].Value;
                    var player = new Player
                    {
                        Number = number == null ? "" : number.ToString(),
                        Code = code == number ? "" : code.ToString(),
                        Name = name == number ? "" : name.ToString(),
                        Note = note == number ? "" : note.ToString(),
                        Win = 0
                    };
                    list.Add(player);
                }

            }
            return list;
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
