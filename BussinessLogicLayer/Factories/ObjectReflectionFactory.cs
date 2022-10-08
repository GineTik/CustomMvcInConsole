namespace BussinessLogicLayer.Factories
{
    public class ObjectReflectionFactory
    {
        public object Create(Type type)
        {
            var constructor = type.GetConstructor(new Type[] { });
            if (constructor == null)
                throw new InvalidOperationException("Type " + type.Name + " does not contain an appropriate constructor");
            return constructor.Invoke(new object[] { });
        }

        public T Create<T>()
        {
            var constructor = typeof(T).GetConstructor(new Type[] { });
            if (constructor == null)
                throw new InvalidOperationException("Type " + typeof(T).Name + " does not contain an appropriate constructor");
            return (T)constructor.Invoke(new object[] { });
        }

        public T Create<T, TValue>(TValue param)
        {
            var constructor = typeof(T).GetConstructor(new Type[] { typeof(TValue) });
            if (constructor == null)
                throw new InvalidOperationException("Type " + typeof(T).Name + " does not contain an appropriate constructor");
            return (T)constructor.Invoke(new object[] { param });
        }
    }
}
