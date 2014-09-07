using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Environments.Decorators
{
    class Small : EnvironmentDecorator
    {
        Environment environment;

        public Small(Environment environment)
        {
            this.environment = environment;
        }

        public override int Value()
        {
            return environment.Value() - 1;
        }

        public override System.Drawing.Image getImage()
        {
            return environment.getImage();
        }

        public override string getType()
        {
            return environment.getType();
        }
    }
}
