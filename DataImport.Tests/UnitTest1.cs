using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DataImport.Tests
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void UserTestData()
		{
			var import = new Data();
			var data = import.Import<UserListImport>("adam 30");

			Assert.IsNotNull(data, "object is null");
		}

		[Test]
		public void UserTestDataType()
		{
			var import = new Data();
			var data = import.Import<UserListImport>("adam 30");
			Assert.IsTrue(data.GetType() == typeof (List<UserListImport>), "");
		}

		[Test]
		public void ListShouldBeOneLong()
		{
			var import = new Data();
			var data = import.Import<UserListImport>("adam 30");
			Assert.IsTrue(data.Count == 1);
		}

		[Test]
		public void ListShouldBeOneLongAndValidValues()
		{
			var import = new Data();
			var data = import.Import<UserListImport>("adam 30");
			Assert.IsTrue(data.Count == 1);
		}
	}
}
