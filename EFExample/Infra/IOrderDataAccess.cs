using EFExample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample.Infra
{
    public interface IOrderDataAccess
    {
        List<OrderModel> GetAllOrder();

        void SaveOrder(OrderModel order);
    }
}
