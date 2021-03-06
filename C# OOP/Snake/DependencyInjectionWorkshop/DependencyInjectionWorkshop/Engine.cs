﻿using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjectionWorkshop.Contracts;

namespace DependencyInjectionWorkshop
{
    class Engine
    {
        private ILogger logger;

        public Engine(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            logger.Log("Game Started");
        }

        public void End()
        {
            logger.Log("Game Ended");
        }
    }
}
