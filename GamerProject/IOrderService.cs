using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface IOrderService
    {
        void Order(Gamer gamer,Campaign campaign,Game game);
    }
}
