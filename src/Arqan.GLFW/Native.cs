namespace Arqan.Glfw
{
	public static class Native
	{
		#if Windows
		public const string LIBGLFW = "glfw3.dll";
		#elif OSX
		public const string LIBGLFW = "libglfw.dylib";
		#else
		public const string LIBGLFW = "libglfw.so";
		#endif
	}
}
