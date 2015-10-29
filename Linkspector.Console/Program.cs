﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkspectorJS.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			ParseUrl();

			System.Console.ReadLine();
		}

		static void Print(string str)
		{
			System.Console.WriteLine(str);
		}

		static void ParseUrl()
		{
			Print(new Uri("http://www.test.com", UriKind.RelativeOrAbsolute).ToString());

			Print(new Uri("//www.test.com", UriKind.RelativeOrAbsolute).ToString());

			Print(new Uri("www.test.com", UriKind.RelativeOrAbsolute).ToString());

		}

      static void LinqTest()
      {
         var a = new[] { 1, 2, 3, 4 };

         //a.ToList().ForEach()
      }
	}
}
