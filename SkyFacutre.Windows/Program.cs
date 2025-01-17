﻿using SkyFacture.Content;
using SkyFacture.IO;

namespace SkyFacture.Windows;

public class Program : ExecutorMain
{
	private static void Main(string[] args)
	{
		SystemType = SystemType.Windows;
		ResourceLoader = new AssemblyResourceLoader(typeof(ExecutorMain));

		ParseParams(args);


		ContentList.RegistryAll();

		Launch();
	}
	private static void ParseParams(string[] arguments)
	{
		for (int i = 0; i < arguments.Length; i++)
		{
			string arg = arguments[i];

			switch (arg)
			{

			}
		}
	}
}
