namespace Windows.AnimationManager
{
    using System;

    public static class Factory
    {
        public static Guid CLSID_UIAnimationManager = Guid.Parse("4C1FC63A-695C-47E8-A339-1A194BE3D0B8");
        public static Guid CLSID_UIAnimationManager2 = Guid.Parse("D25D8842-8884-4A4A-B321-091314379BDD");
        public static Guid CLSID_UIAnimationTransitionLibrary = Guid.Parse("1D6322AD-AA85-4EF5-A828-86D71067D145");
        public static Guid CLSID_UIAnimationTransitionLibrary2 = Guid.Parse("812F944A-C5C8-4CD9-B0A6-B3DA802F228D");
        public static Guid CLSID_UIAnimationTransitionFactory = Guid.Parse("8A9B1CDD-FCD7-419c-8B44-42FD17DB1887");
        public static Guid CLSID_UIAnimationTransitionFactory2 = Guid.Parse("84302F97-7F7B-4040-B190-72AC9D18E420");
        public static Guid CLSID_UIAnimationTimer = Guid.Parse("BFCD4A0C-06B6-4384-B768-0DAA792C380E");

        internal static TInterface CreateCoClass<TInterface>(Guid coClass)
            where TInterface : ComObject
        {
            ComActivationHelpers.CreateComInstance(
                coClass,
                ComContext.Inproc,
                typeof(TInterface).GUID,
                out var ptrIUnk)
            .CheckError();
            return new ComObject(ptrIUnk).QueryInterface<TInterface>();
        }

        public static IUIAnimationManager CreateAnimationManager()
        {
            return CreateCoClass<IUIAnimationManager>(CLSID_UIAnimationManager);
        }

        public static IUIAnimationManager2 CreateAnimationManager2()
        {
            return CreateCoClass<IUIAnimationManager2>(CLSID_UIAnimationManager2);
        }

        public static IUIAnimationTransitionFactory CreateAnimationTransitionFactory()
        {
            return CreateCoClass<IUIAnimationTransitionFactory>(CLSID_UIAnimationTransitionFactory);
        }
        public static IUIAnimationTransitionFactory2 CreateAnimationTransitionFactory2()
        {
            return CreateCoClass<IUIAnimationTransitionFactory2>(CLSID_UIAnimationTransitionFactory2);
        }
        public static IUIAnimationTransitionLibrary CreateAnimationTransitionLibrary()
        {
            return CreateCoClass<IUIAnimationTransitionLibrary>(CLSID_UIAnimationTransitionLibrary);
        }
        public static IUIAnimationTransitionLibrary2 CreateAnimationTransitionLibrary2()
        {
            return CreateCoClass<IUIAnimationTransitionLibrary2>(CLSID_UIAnimationTransitionLibrary2);
        }
        public static IUIAnimationTimer CreateAnimationTimer()
        {
            return CreateCoClass<IUIAnimationTimer>(CLSID_UIAnimationTimer);
        }
    }
}
