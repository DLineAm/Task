using System;

namespace TravelAgency.Services
{
    public static class BuilderFactory
    {
        public static T NewBuilder<T>() where T : IBuilder
        {
            //var k = new PdfBuilder();
            var instance = Activator.CreateInstance(typeof(T));
            return (T)instance;
        }
    }
}