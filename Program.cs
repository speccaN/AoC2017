using AoC2017.Days.Day01;
using AoC2017.Days.Day02;
using AoC2017.Days.Day03;
using AoC2017.Days.Interfaces;
using AoC2017.Helpers;
using AoC2017.Helpers.Interfaces;
using Autofac;

namespace AoC2017
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            builder.RegisterType<TextReader>().As<ITextReader>();
            builder.RegisterType<TextWriter>().As<ITextWriter>();
            builder.RegisterType<Timer>().As<ITimer>();
            builder.RegisterType<MathHelper>().As<IMath>();
            //builder.RegisterType<Day01>().As<IExecute>();
            builder.RegisterType<Day03>().As<IExecute>();
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                scope.Resolve<IExecute>().Run();
            }
        }
    }
}
