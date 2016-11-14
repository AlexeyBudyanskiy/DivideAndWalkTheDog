using DivideAndWalkTheDog.BLL.Services;
using System.Web.Mvc;
using Ninject;
using System.Collections.Generic;
using System;
using DivideAndWalkTheDog.BLL.Interfaces;

namespace DivideAndWalkTheDog.WEB.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IDogService>().To<DogService>();
            kernel.Bind<IMessageService>().To<MessageService>();
            kernel.Bind<IRequestService>().To<RequestService>();
            kernel.Bind<IUserService>().To<UserService>();
        }
    }
}