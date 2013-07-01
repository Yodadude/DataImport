using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;

namespace DataImport
{
	public class UserListImport
	{
		private List<User> Users = new List<User>();
	}

	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
