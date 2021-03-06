using GraphQL.Types;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace GraphQL.Tests.Utilities
{
    public class TypeExtensionsTests
    {
        [Fact]
        public void supports_decimal_type()
        {
            typeof(decimal).GetGraphTypeFromType(true).ShouldBe(typeof(DecimalGraphType));
        }

        [Fact]
        public void supports_float_type()
        {
            typeof(float).GetGraphTypeFromType(true).ShouldBe(typeof(FloatGraphType));
        }

        [Fact]
        public void GetGraphTypeFromType_ForIList_EqualToListGraphType() =>
            typeof(IList<string>).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForIReadOnlyCollection_EqualToListGraphType() =>
            typeof(IReadOnlyCollection<string>).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForIEnumerable_EqualToListGraphType() =>
            typeof(IEnumerable<string>).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForICollection_EqualToListGraphType() =>
            typeof(ICollection<string>).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForList_EqualToListGraphType() =>
            typeof(List<string>).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForArray_EqualToListGraphType() =>
            typeof(string[]).GetGraphTypeFromType(true).ShouldBe(typeof(ListGraphType<StringGraphType>));

        [Fact]
        public void GetGraphTypeFromType_ForString_EqualToStringGraphType() =>
            typeof(string).GetGraphTypeFromType(true).ShouldBe(typeof(StringGraphType));
    }
}
