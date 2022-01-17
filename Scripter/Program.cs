﻿using CLI.Core;
using CLI.Core.Lib;
using Unity;

namespace Scripter;

public class Program
{
	static void Main(string[] args)
	{
        IBootstraper booter = new Bootstraper(
			new UnityDependencyCollection(
				new UnityContainer().AddExtension(
                    new Diagnostic())));
		booter.Boot(args);
	}
}