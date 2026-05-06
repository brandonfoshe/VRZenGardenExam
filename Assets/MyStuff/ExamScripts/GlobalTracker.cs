using UnityEngine;

public static class GlobalTracker
{

	// Script written by Brandon Foshe during Exam Hours
	// Keeps track of lanterns, methods can be called from other scripts
	// Keeps track of number of spheres thrown and updates its text

	public static int lanternTracker = 5;
	public static int spheresThrown = 0;
	public static string lanternText = "";
	public static string sphereText = "";

	public static void DecrementLanterns()
	{
		lanternTracker--;
	}

	public static string UpdateTextLantern()
	{
		lanternText = ("Lantern Counter: " + lanternTracker);
		return lanternText;
	}

	public static void IncrementSpheres()
	{
		spheresThrown++;
	}

	public static string UpdateTextSphere()
	{
		sphereText = ("Spheres Thrown: " + spheresThrown);
		return sphereText;
	}
}
