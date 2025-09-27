using System.Runtime.InteropServices;

namespace SampleNativeNuget
{
    public unsafe partial class NativeAccess
    {
        [LibraryImport("nativelibrary", EntryPoint = "AllocMemory")]
        public static partial void* AllocMemory(long length);

        [LibraryImport("nativelibrary", EntryPoint = "DeallocMemory")]
        public static partial void DeallocMemory(void* length);
    }
}
