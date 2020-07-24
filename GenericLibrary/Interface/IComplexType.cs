using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBasics.Interfaces
{
    public interface IComplexType<TEntity, TDefinition>
    {
        void UseOneType(TDefinition definition);
        void UseBothTypes(TEntity entity, TDefinition definition);
        void UseMethodSpecificType<TMethodType>(TEntity entity, TMethodType parameter);
        void UseAction(Action<TEntity> action);
    }
}
