﻿

namespace SkyFacture;
public static class Screen
{
	public static int Width { get; internal set; }
	public static int Height { get; internal set; }
	public static bool InFocuse { get; internal set; }
	public static float Ratio => Width / Height;
}
