using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataImport
{
	public class Data
	{
		public Data(IFileMapper fileMapper)
		{
			
		}

		public List<T> Import<T> (string data) where T : new()
		{
			var list = new List<T> {new T()};

			return list;
		}

	}

	public interface IFileMapper
	{
		List<T> Map<T>();
	}
}
