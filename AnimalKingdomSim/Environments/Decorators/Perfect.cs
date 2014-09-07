using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Environments.Decorators
{
    class Perfect : EnvironmentDecorator
    {
        Environment environment;

        public Perfect(Environment environment)
        {
            this.environment = environment;
        }

        public override int Value()
        {
            return 3 + environment.Value();
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
