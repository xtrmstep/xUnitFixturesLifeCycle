using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitFixturesLifeCycle
{
    public class CollectionFixture : IDisposable
    {
        public CollectionFixture()
        {
            "CollectionFixture : ctor".Show();
        }

        public void Dispose()
        {
            "CollectionFixture : disposed".Show();
        }
    }

    public class ClassFixture : IDisposable
    {
        public ClassFixture()
        {
            "ClassFixture : ctor".Show();
        }

        public void Dispose()
        {
            "ClassFixture : disposed".Show();
        }
    }

    [CollectionDefinition("ContextOne")]
    public class TestCollection : ICollectionFixture<CollectionFixture>
    {
        public TestCollection()
        {
            "TestCollection is never instantiated".Show();
        }
    }

    [Collection("ContextOne")]
    public class TestContainerOne : IClassFixture<ClassFixture>, IDisposable
    {
        public TestContainerOne()
        {
            "TestContainerOne : ctor".Show();
        }

        [Fact]
        public void TestOne()
        {
            "TestContainerOne : TestOne".Show();
        }

        [Fact]
        public void TestTwo()
        {
            "TestContainerOne : TestTwo".Show();
        }

        public void Dispose()
        {
            "TestContainerOne : disposed".Show();
        }
    }

    [Collection("ContextOne")]
    public class TestContainerTwo : IDisposable
    {
        public TestContainerTwo()
        {
            "TestContainerTwo : ctor".Show();
        }

        [Fact]
        public void TestOne()
        {
            "TestContainerTwo : TestOne".Show();
        }

        public void Dispose()
        {
            "TestContainerTwo : disposed".Show();
        }
    }

    public class TestContainerThree
    {
        [Fact]
        public void TestOne()
        {
            "TestContainerThree : TestOne".Show();
        }
    }
}
