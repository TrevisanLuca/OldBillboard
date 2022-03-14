﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBillboard.Models;

namespace TheBillboard.Abstract
{
    public interface IMessageGateway
    {
        IEnumerable<Message> GetMessages();
        Message GetMessage(int id);
    }
}
