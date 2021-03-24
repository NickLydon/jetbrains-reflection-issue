using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Company.Name.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<Assembly> assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName().FullName.StartsWith("Company.Name")).ToList();

            Assert.Equal(2, assemblies.Count);
        }
    }
}