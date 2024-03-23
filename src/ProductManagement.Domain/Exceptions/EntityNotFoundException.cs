using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Exceptions
{
    [Serializable]
    public class EntityNotFoundException<TKey>: Exception
    {
        public EntityNotFoundException()
        {
        }
        public EntityNotFoundException(TKey id): base(string.Format("There is no Entity with Id {0}", id))
        {
        }
    }
}
