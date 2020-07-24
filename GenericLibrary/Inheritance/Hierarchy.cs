using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Inheritance
{
    public abstract class BaseClass<T> { }

    public class WireDiagram { }

    public class NormalSchema {  }

    public class NonGenericChild : BaseClass<int> { }

    public class GenericChild<T>: BaseClass<T> { }

    public class GenericChildWithAdditionalType<TAdditionalType>: BaseClass<string>
    { }

    public class ComplexBaseClass<TDiagram, TSchema> {  }

    public class OneTypeSpecified<TSchema> : ComplexBaseClass<WireDiagram, TSchema> { }

    public class BothTypesSpecified : ComplexBaseClass<WireDiagram, NormalSchema> { }

}
