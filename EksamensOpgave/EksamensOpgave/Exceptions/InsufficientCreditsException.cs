using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class InsufficientCreditsException : Exception
    {
        public InsufficientCreditsException()
        {
        }

        public InsufficientCreditsException(string message)
            : base(message)
        {
        }

        public InsufficientCreditsException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public InsufficientCreditsException(User user, Product product)
            : base($"Navn: { user.ToString() } Du har ikke nok penge til at købe { product.ToString() }")
        {
        }
    }
}
