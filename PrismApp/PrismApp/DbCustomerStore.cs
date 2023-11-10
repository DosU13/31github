using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismApp;

public class DbCustomerStore : ICustomerStore
{
    public List<string> GetAll()
    {
        return new List<string>
        {
            "Hello",
            "World"
        };
    }
}
