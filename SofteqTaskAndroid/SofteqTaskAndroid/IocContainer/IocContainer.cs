using DryIoc;

namespace SofteqTaskAndroid.IocContainer
{
    public class IocContainer
    {
        private static IocContainer _instance;

        public static IocContainer Instance => _instance != null ? _instance : _instance = new IocContainer();

        public IContainer Container { get; private set; }

        private IocContainer() => Container = new Container(rules => rules.WithUseInterpretation());

        public void Register<TService>(IReuse reuse = null) => Container.Register<TService>(reuse);

        public void Register<TImplementation, TService>(IReuse reuse = null)
            where TImplementation : TService => Container.Register<TService, TImplementation>(reuse);

        public TService Resolve<TService>() => Container.Resolve<TService>();
    }
}
