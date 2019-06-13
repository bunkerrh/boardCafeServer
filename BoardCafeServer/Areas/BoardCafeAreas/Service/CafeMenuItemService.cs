using BoardCafeServer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardCafeServer.Areas.BoardCafeAreas.Service
{
    public interface CafeMenuItemService
    {
        List<CafeMenuItem> getAllCafeMenuItem();
    }
}
