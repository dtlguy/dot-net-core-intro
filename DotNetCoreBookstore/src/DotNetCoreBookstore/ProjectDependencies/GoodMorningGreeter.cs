﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreBookstore.Dependencies
{
public class GoodMorningGreeter : IGreeter
{
	public string SendGreeting()
	{
		return "Good morning";
	}
}
}
