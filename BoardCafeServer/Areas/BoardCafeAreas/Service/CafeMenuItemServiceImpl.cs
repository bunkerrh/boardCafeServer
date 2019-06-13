using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardCafeServer.Objects;
using BoardCafeServer.Areas.BoardCafeAreas.DBConnections;

namespace BoardCafeServer.Areas.BoardCafeAreas.Service
{
    public class CafeMenuItemServiceImpl : CafeMenuItemService
    {
        BoardCafeMySqlUtil sqlUtil = new BoardCafeMySqlUtil();
        public List<CafeMenuItem> getAllCafeMenuItem()
        {

            List<CafeMenuItem> items = new List<CafeMenuItem>();

            items = sqlUtil.selectAllCafeItems();

            return items;
            throw new NotImplementedException();
        }
    }
}
