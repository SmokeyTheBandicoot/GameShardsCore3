﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.QueryHelper {
    
    public interface ISequence<T> {

        public T getNext();
        public bool hasNext();

    }

}