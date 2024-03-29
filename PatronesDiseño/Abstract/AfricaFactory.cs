﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class AfricaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
