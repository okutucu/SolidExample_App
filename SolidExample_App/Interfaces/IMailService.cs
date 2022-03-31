﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExample_App.Interfaces
{
    public interface IMailService
    {

        bool SendMail(string subject, string body, List<string> to);
    }
}
