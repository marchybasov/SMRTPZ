﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public interface ICardFinder
    {
        CardBase GetCardById(int id);
    }
}
