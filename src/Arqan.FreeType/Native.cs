namespace Arqan.FreeType;

public static class Native
{
#if Windows
    public const string LIBFREETYPE = "libfreetype.dll";
#elif OSX
		public const string LIBFREETYPE = "libfreetype.dylib";
#else
		public const string LIBFREETYPE = "libfreetype.so";
#endif
}