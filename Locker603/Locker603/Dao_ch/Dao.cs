using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace Cus.Form5
{
    public class Dao
    {
        public static BoxDao Box { get; } = new BoxDao();
    }
}
