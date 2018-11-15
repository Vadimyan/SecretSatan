using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretSatan.Tests
{
	[TestClass]
	public class SatanRandomizerTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(true, true);
			Assert.AreNotEqual(true, false);
			CollectionAssert.AreEquivalent(new [] {1, 2, 3}, new [] {3, 1, 2});
		}
	}
}
