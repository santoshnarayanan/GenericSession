using System;

namespace GenericBasics.Interfaces
{
    public class ComplexNewType <TEntity, TDefinition>:IComplexType<TEntity, TDefinition>
    {

        public void UseOneType(TDefinition definition)
        {
        }

        public void UseBothTypes(TEntity entity, TDefinition definition)
        {
        }

        public void UseMethodSpecificType<TMethodType>(TEntity entity, TMethodType parameter)
        {
        }

        public void UseAction(Action<TEntity> action)
        {
        }

        public static void StaticMethod(TEntity entity)
        {
        }
    }
}