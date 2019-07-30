﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Implem.IRds
{
    public interface ISqlCommandText
    {
        string CreateSelectIdentity(string template, string identityColumnName);

        string CreateSelectStatementTerminator(bool selectIdentity);
    }
}