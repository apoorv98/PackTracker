﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackChronicler.Entity;

namespace PackChronicler.Event {
  class PackOpenedEventArgs {
    Pack _pack;

    public Pack Pack { get { return _pack; } }

    public PackOpenedEventArgs(Pack Pack) {
      _pack = Pack;
    }
  }
}
