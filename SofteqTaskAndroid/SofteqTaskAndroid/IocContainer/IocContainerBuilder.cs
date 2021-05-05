using DryIoc;
using SofteqTaskAndroid.Algoritms;
using SofteqTaskAndroid.PageModels;

namespace SofteqTaskAndroid.IocContainer
{
    public class IocContainerBuilder
    {
        public void RegisterDependencies()
        {
            IocContainer.Instance.Register<Task1Calculator>(Reuse.Singleton);
            IocContainer.Instance.Register<Task2Calculator>(Reuse.Singleton);
            IocContainer.Instance.Register<Task3Calculator>(Reuse.Singleton);
            IocContainer.Instance.Register<Task4Calculator>(Reuse.Singleton);
        }
    }
}
