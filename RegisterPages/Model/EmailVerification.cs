using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterPages.Model
{
    class EmailVerification
    {
        public event EventHandler emailVerificationEvent;
        public void OnUserRegistered(object source, EventArgs e)
        {

            emailVerificationEvent(this, EventArgs.Empty);

        }
    }
}