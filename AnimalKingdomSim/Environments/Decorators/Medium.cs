using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalKingdomSimulator.Environments.Decorators
{
    class Medium : EnvironmentDecorator
    {
        Environment environment;

        public Medium(Environment environment)
        {
            this.environment = environment;
        }

        public override int Value()
        {
            return 2 + environment.Value();
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
