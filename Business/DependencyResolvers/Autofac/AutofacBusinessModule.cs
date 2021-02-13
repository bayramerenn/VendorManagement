using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.CivilDal;
using DataAccess.Concrete.EntityFramework.VMDal;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductHierarchyService>().As<IProductHierarchyService>();
            builder.RegisterType<EfProductHierarchyDal>().As<IProductHierarchyDal>();

            builder.RegisterType<EfCdColorDal>().As<ICdColorDal>();
            builder.RegisterType<EfCdColorDescDal>().As<ICdColorDescDal>();
            builder.RegisterType<ColorService>().As<IColorService>();

            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<EfProductAttributeDal>().As<IProductAttributeDal>();
            builder.RegisterType<ProductAttributeService>().As<IProductAttributeService>();

            builder.RegisterType<EfProductDescriptionDal>().As<IProductDescriptionDal>();
            builder.RegisterType<ProductDescriptionService>().As<IProductDescriptionService>();

            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<EfProductDimSetContentDal>().As<IProductDimSetContentDal>();
            builder.RegisterType<ProductDimSetContentService>().As<IProductDimSetContentService>();

            builder.RegisterType<EfProductVariantDal>().As<IProductVariantDal>();
            builder.RegisterType<ProductVariantService>().As<IProductVariantService>();

            builder.RegisterType<EfProductColorFabricBlendDal>().As<IProductColorFabricBlendDal>();
            builder.RegisterType<ProductColorFabricBlendService>().As<IProductColorFabricBlendService>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                });
        }
    }
}
