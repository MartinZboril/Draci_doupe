﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public interface IAttackBehavior
    {
        void Attack(Enemy enemy, int attackStrenght);
    }
}
