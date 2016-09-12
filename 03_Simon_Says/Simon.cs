using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Simon_Says
{
	class Simon
	{
		public string Echo(string i)
		{
			return i;
		}

		public string Shout(string i)
		{
			return i.ToUpper();
		}

		public string Repeat(string i, int repeat=2)
		{
			string a = i;
			for(int u = 1; u < repeat; u++)
			{
				a += " " + i;
			}
			return a;
		}

		public string StartOfWord(string i, int num = 1)
		{
			return i.Substring(0,num);
		}

		public string FirstWord(string i, int num = 1)
		{
			string[] a = i.Split(' ');
			return a[num-1];
		}

		public string Titleize(string i)
		{
			string[] a = i.Split(' ');
			string n = "";
			bool first = true;
			
			
			foreach (string f in a)
			{
				if (!first)
				{
					n += " ";
				}
				if(first || (f != "and" && f != "over" && f != "the"))
				{
					n += char.ToUpper(f[0]) + f.Substring(1);
				}else
				{
					n += f;
				}
				if (first)
				{
					first = false;
				}
				
			}
			return n;
		}
	}
}
