using System;

namespace GenericBasics.Classes
{
    public class ComplexType<TEntity, TDefinition>
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