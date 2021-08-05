using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public class Product : Entity
    {
        public override void Create()
        {
            base.Create();
            // mas su propia implementacion
        }

        public override void Update()
        {
            // su propia implementacion
        }

        public override void Delete()
        {
            // su propia implementacion
        }
    }
}
