using System;
using NUnit.Framework;

namespace NUnit.Should.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldContainText()
        {
            "The Rain In Spain".ShouldContain("Rain");
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldContainTextException()
        {
            "The Rain In Spain".ShouldContain("Bulgaria");
        }

        [Test]
        public void ShouldContainMember()
        {
            new[]{1,2,3}.ShouldContain(2);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldContainMemberException()
        {
            new[] { 1, 2, 3 }.ShouldContain(42);
        }

        [Test]
        public void ShouldNotContainText()
        {
            "The Rain In Spain".ShouldNotContain("Bulgaria");
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotContainTextException()
        {
            "The Rain In Spain".ShouldNotContain("Rain");
        }

        [Test]
        public void ShouldNotContainMember()
        {
            new[] { 1, 2, 3 }.ShouldNotContain(42);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotContainMemberException()
        {
            new[] { 1, 2, 3 }.ShouldNotContain(2);
        }

        [Test]
        public void ShouldBeEmpty()
        {
            new int[] {}.ShouldBeEmpty();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeEmptyexception()
        {
            new[] { 1,2,3 }.ShouldBeEmpty();
        }

        [Test]
        public void ShouldNotBeEmpty()
        {
            new[] { 1, 2, 3 }.ShouldNotBeEmpty();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeEmptyexception()
        {
            new int[] { }.ShouldNotBeEmpty();
        }

        [Test]
        public void ShouldBeValueTypes()
        {
            1.ShouldBe(1);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeValueTypesException()
        {
            1.ShouldBe(2);
        }

        [Test]
        public void ShouldNotBeValueTypes()
        {
            1.ShouldNotBe(2);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeValueTypeException()
        {
            1.ShouldNotBe(1);
        }

        [Test]
        public void ShouldBeObject()
        {
            var obj = new object();
            obj.ShouldBe(obj);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeObjectException()
        {
            var obj = new object();
            var otherobj = new object();
            obj.ShouldBe(otherobj);
        }

        [Test]
        public void ShouldNotBeObject()
        {
            var obj = new object();
            var otherobj = new object();
            obj.ShouldNotBe(otherobj);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeObjectException()
        {
            var obj = new object();
            obj.ShouldNotBe(obj);
        }

        [Test]
        public void ShouldBeNull()
        {
            const object obj = null;
            obj.ShouldBeNull();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeNullException()
        {
            var obj = new object();
            obj.ShouldBeNull();
        }

        [Test]
        public void ShouldNotBeNull()
        {
            var obj = new object();
            obj.ShouldNotBeNull();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeNullException()
        {
            
            const object obj = null;
            obj.ShouldNotBeNull();
        }

        [Test]
        public void ShouldBeSame()
        {
            object foo = 1;
            foo.ShouldBeSameAs(foo);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeSameException()
        {
            object foo = 1;
            object bar = 1;
            foo.ShouldBeSameAs(bar);
        }

        [Test]
        public void ShouldNotBeSame()
        {
            const int foo = 1;
            const int bar = 1;
            foo.ShouldNotBeSameAs(bar);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeSameException()
        {
            object foo = 1;
            foo.ShouldNotBeSameAs(foo);
        }

        [Test]
        public void ShouldBeTrue()
        {
            true.ShouldBeTrue();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeTrueException()
        {
            false.ShouldBeTrue();
        }

        [Test]
        public void ShouldBeFalse()
        {
            false.ShouldBeFalse();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeFalseException()
        {
            true.ShouldBeFalse();
        }

        [Test]
        public void ShouldBeInRange()
        {
            2.ShouldBeInRange(1,3);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeInRangeException()
        {
            2.ShouldBeInRange(5, 9);
        }

        [Test]
        public void ShouldNotBeInRange()
        {
            2.ShouldNotBeInRange(3, 6);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeInRangeException()
        {
            2.ShouldNotBeInRange(1, 9);
        }

        [Test]
        public void ShouldBeGreaterThan()
        {
            1.ShouldBeGreaterThan(0);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeGreaterThanException()
        {
            1.ShouldBeGreaterThan(1);
        }

        [Test]
        public void ShouldBeGreaterThanOrEqTo()
        {
            1.ShouldBeGreaterThanOrEqualTo(1);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeGreaterThanOrEqToException()
        {
            1.ShouldBeGreaterThanOrEqualTo(2);
        }


        [Test]
        public void ShouldBeLessThan()
        {
            0.ShouldBeLessThan(1);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeLessThanException()
        {
            1.ShouldBeLessThan(1);
        }

        [Test]
        public void ShouldBeLessThanOrEqTo()
        {
            1.ShouldBeLessThanOrEqualTo(1);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeLessThanOrEqToException()
        {
            1.ShouldBeLessThanOrEqualTo(0);
        }

        [Test]
        public void ShouldBeInstanceOfT()
        {
            1.ShouldBeInstanceOf<int>();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeInstanceOfTException()
        {
            1.ShouldBeInstanceOf<string>();
        }

        [Test]
        public void ShouldNotBeInstanceOfT()
        {
            1.ShouldNotBeInstanceOf<string>();
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeInstanceOfTException()
        {
            1.ShouldNotBeInstanceOf<int>();
        }

        [Test]
        public void ShouldBeInstanceOf()
        {
            1.ShouldBeInstanceOf(typeof(int));
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldBeInstanceOfException()
        {
            1.ShouldBeInstanceOf(typeof(string));
        }

        [Test]
        public void ShouldNotBeInstanceOf()
        {
            1.ShouldNotBeInstanceOf(typeof(string));
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void ShouldNotBeInstanceOfException()
        {
            1.ShouldNotBeInstanceOf(typeof(int));
        }
    }
}
