using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NUnit.Should
{
	public static class ShouldExtensions
	{
		public static void ShouldContain(this string self, string str)
		{
			Assert.That(str, Is.StringContaining(self));
		}

        //public static void ShouldContain(this string self, string str, StringComparison comparison)
        //{
        //    Assert.That(str, Is.StringContaining(self).And.));
        //}

		public static void ShouldContain<T>(this IEnumerable<T> series, T item)
		{
            Assert.That(series, Has.Member(item));
		}

        //public static void ShouldContain<T>(this IEnumerable<T> series, T item, IComparer<T> comparer)
        //{
        //    Assert.Contains(item, series, comparer);
        //}

		public static void ShouldNotContain(this string self, string str)
		{
			Assert.That(str, Is.Not.StringContaining(self));
		}

        //public static void ShouldNotContain(this string self, string str, StringComparison comparison)
        //{
        //    Assert.DoesNotContain(str, self, comparison);
        //}

		public static void ShouldNotContain<T>(this IEnumerable<T> series, T item)
		{
			Assert.That(series, Has.No.Member(item));
		}

        //public static void ShouldNotContain<T>(this IEnumerable<T> series, T item, IComparer<T> comparer)
        //{
        //    Assert.DoesNotContain(item, series, comparer);
        //}

		public static void ShouldBeEmpty(this IEnumerable series)
		{
			Assert.That(series, Is.Empty);
		}

		public static void ShouldNotBeEmpty(this IEnumerable series)
		{
            Assert.That(series, Is.Not.Empty);
		}

		public static void ShouldBe<T>(this T self, T other)
		{
			Assert.Equals(other, self);
		}

        //public static void ShouldBe<T>(this T self, T other, IComparer<T> comparer)
        //{
        //    Assert.Equals(other, self, comparer);
        //}

		public static void ShouldNotBe<T>(this T self, T other)
		{
			Assert.AreNotEqual(other, self);
		}

        //public static void ShouldNotBe<T>(this T self, T other, IComparer<T> comparer)
        //{
        //    Assert.NotEqual(other, self, comparer);
        //}

		public static void ShouldBeNull(this object self)
		{
			Assert.Null(self);
		}

		public static void ShouldNotBeNull(this object self)
		{
			Assert.NotNull(self);
		}

		public static void ShouldBeSameAs(this object self, object other)
		{
			Assert.AreSame(other, self);
		}

		public static void ShouldNotBeSameAs(this object self, object other)
		{
			Assert.AreNotSame(other, self);
		}

		public static void ShouldBeTrue(this bool self)
		{
			Assert.True(self);
		}

		public static void ShouldBeTrue(this bool self, string message)
		{
			Assert.True(self, message);
		}

		public static void ShouldBeFalse(this bool self)
		{
			Assert.False(self);
		}

		public static void ShouldBeFalse(this bool self, string message)
		{
			Assert.False(self, message);
		}

		public static void ShouldBeInRange<T>(this T self, T low, T high) where T : IComparable
		{
			Assert.That(self, Is.InRange(low, high));
		}

        public static void ShouldNotBeInRange<T>(this T self, T low, T high) where T : IComparable
		{
            Assert.That(self, Is.Not.InRange(low, high));
		}

		public static void ShouldBeGreaterThan<T>(this T self, T other)
			where T : IComparable<T>
		{
			Assert.True(self.CompareTo(other) > 0);
		}

		public static void ShouldBeGreaterThan<T>(this T self, T other, IComparer<T> comparer)
		{
			Assert.True(comparer.Compare(self, other) > 0);
		}

		public static void ShouldBeGreaterThanOrEqualTo<T>(this T self, T other)
			where T : IComparable<T>
		{
			Assert.True(self.CompareTo(other) >= 0);
		}

		public static void ShouldBeGreaterThanOrEqualTo<T>(this T self, T other, IComparer<T> comparer)
		{
			Assert.True(comparer.Compare(self, other) >= 0);
		}

		public static void ShouldBeLessThan<T>(this T self, T other)
			where T : IComparable<T>
		{
			Assert.True(self.CompareTo(other) < 0);
		}

		public static void ShouldBeLessThan<T>(this T self, T other, IComparer<T> comparer)
		{
			Assert.True(comparer.Compare(self, other) < 0);
		}

		public static void ShouldBeLessThanOrEqualTo<T>(this T self, T other)
			where T : IComparable<T>
		{
			Assert.True(self.CompareTo(other) <= 0);
		}

		public static void ShouldBeLessThanOrEqualTo<T>(this T self, T other, IComparer<T> comparer)
		{
			Assert.True(comparer.Compare(self, other) <= 0);
		}

		public static void ShouldBeInstanceOf<T>(this object self)
		{
			Assert.That(self, Is.InstanceOf(typeof(T)));
		}

		public static void ShouldBeInstanceOf(this object self, Type type)
		{
            Assert.That(self, Is.InstanceOf(type));
		}

		public static void ShouldNotBeInstanceOf<T>(this object self)
		{
            Assert.That(self, Is.Not.InstanceOf(typeof(T)));
		}

		public static void ShouldNotBeInstanceOf(this object self, Type type)
		{
            Assert.That(self, Is.Not.InstanceOf(type));
		}

	/*	public static void ShouldBeThrownBy<T>(this T self, Assert.ThrowsDelegate method)
			where T : Exception
		{
			Assert.Throws<T>(method);
		}*/
	}
}