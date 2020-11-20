using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class ProductNotActiveException : Exception
    {
        public ProductNotActiveException()
        {
        }

        public ProductNotActiveException(string message)
            : base(message)
        {
        }

        public ProductNotActiveException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public ProductNotActiveException(Product product)
            : base($"Produktet: { product.ToString() } er ikke aktivt.")
        {
        }
    }
}
