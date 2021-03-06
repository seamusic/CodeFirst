﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lennon.Web.Http.Extensions
{
    public static class ActionExtensions
    {
        public static Action Chain(this IEnumerable<Action> actions)
        {
            return () =>
            {
                foreach (var action in actions)
                    action();
            };
        }

    }
}
