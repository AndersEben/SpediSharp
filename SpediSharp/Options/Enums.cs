using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Options
{
    public enum TokenType
    {
        Bearer
    }

    public enum JsonType
    {
        get,
        insert,
        update,
        error,
        ok
    }
}
