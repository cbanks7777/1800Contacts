﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justin._1800Contacts.Api.Interface
{
    public interface IClassLogic
    {

        List<string> SortByPrerequisite(List<string> classDependencyList);

    }
}
