﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01KNN.model
{
    internal interface IDiagnostic
    {
        float[] Features { get; }
        bool Label { get; }
        void PrintInfo();
    }
}
