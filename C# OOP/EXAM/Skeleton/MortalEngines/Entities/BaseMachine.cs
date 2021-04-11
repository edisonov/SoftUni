using System;
using System.Collections.Generic;
using MortalEngines.Entities.Contracts;

namespace MortalEngines.Entities
{
    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private readonly double attackPoints;
        private readonly double defensePoints;
        private readonly IList<string> targets;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => pilot;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException();
                }
                this.pilot = value;
            } 
        }

        public double HealthPoints
        {
            get => healthPoints;
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints => attackPoints;

        public double DefensePoints => defensePoints;

        public IList<string> Targets => targets;

        public void Attack(IMachine target)
        {
            throw new System.NotImplementedException();
        }
    }
}