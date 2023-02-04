using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}