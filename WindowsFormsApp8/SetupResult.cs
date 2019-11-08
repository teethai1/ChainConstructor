using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp8
{
    class SetupResult
    {
        public bool IsPass { get; }
        public string ErrorMessage { get; }
        public object Result { get; }

        internal SetupResult():
            this(true, "", null)
        {
            //this.IsPass = true;
            //this.ErrorMessage = "";
            //this.Result = null;
        }

        internal SetupResult(string errorMessage)
            :this(false, errorMessage, null)
        {
            //this.IsPass = false;
            //this.ErrorMessage = errorMessage;
            //this.Result = null;
        }

        internal SetupResult(object result)
            :this(true, "", result)
        {
            //this.IsPass = true;
            //this.ErrorMessage = "";
            //this.Result = result;
        }

        internal SetupResult(bool isPass, string errorMessage, object result)
        {
            this.IsPass = isPass;
            this.ErrorMessage = "Error:" + errorMessage;
            this.Result = result;
        }

    }
}
