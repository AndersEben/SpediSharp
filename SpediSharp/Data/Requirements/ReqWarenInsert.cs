using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqWarenInsert : Req<ReqWarenInsert>
    {
        private bool wareninsert { get; set; }
        public t_Waren ware { get; internal set; }

        public ReqWarenInsert(t_Waren ware)
        {
            this.wareninsert = true;
            this.ware = ware;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
