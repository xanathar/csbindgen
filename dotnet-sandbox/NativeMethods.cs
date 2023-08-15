// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace CsBindgen
{
    internal static unsafe partial class NativeMethods
    {
        const string __DllName = "csbindgen_tests";

        internal const int FOO = 10;
        internal const float BAR = 120.432f;
        internal const float BAR32 = 120.431f;
        internal const double BAR64 = 120.432;
        internal const string STR = "aiueo3";
        internal static ReadOnlySpan<byte> BSTR => new byte[] { 107, 97, 107, 105, 107, 117, 107, 101, 107, 111 };
        internal const byte CBYTE = 65;
        internal const char CCHAR = 'あ';
        internal const bool BOOLCONST_T = true;
        internal const bool BOOLCONST_F = false;


        [DllImport(__DllName, EntryPoint = "JPH_PruneContactPoints", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void JPH_PruneContactPoints(void/* UInt128[] */* ioContactPointsOn1, JPH_ContactManifold* ioContactPointsOn2);

        /// <summary>my comment!</summary>
        [DllImport(__DllName, EntryPoint = "comment_one", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void comment_one(EnumFlags _flags);

        /// <summary>Multiline Comments # GOTO Here Foo Bar  TO  ZZZ</summary>
        [DllImport(__DllName, EntryPoint = "long_jpn_comment", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void long_jpn_comment();

        [DllImport(__DllName, EntryPoint = "use_vec3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void use_vec3(my_int_vec3 _v3);

        [DllImport(__DllName, EntryPoint = "other_2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void other_2(NfcCard _hoge);

        [DllImport(__DllName, EntryPoint = "@event", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void @event(@event @event);

        [DllImport(__DllName, EntryPoint = "nest_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void nest_test(delegate* unmanaged[Cdecl]<delegate* unmanaged[Cdecl]<int, void>*, int> _f);

        [DllImport(__DllName, EntryPoint = "alias_test1", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void alias_test1(long* _a);

        [DllImport(__DllName, EntryPoint = "alias_test2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void alias_test2(long _b);

        [DllImport(__DllName, EntryPoint = "nullpointer_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void nullpointer_test(byte* p);

        [DllImport(__DllName, EntryPoint = "csharp_to_rust_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void csharp_to_rust_string(ushort* utf16_str, int utf16_len);

        [DllImport(__DllName, EntryPoint = "csharp_to_rust_utf8", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void csharp_to_rust_utf8(byte* utf8_str, int utf8_len);

        [DllImport(__DllName, EntryPoint = "csharp_to_rust_bytes", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void csharp_to_rust_bytes(byte* bytes, int len);

        [DllImport(__DllName, EntryPoint = "callback_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int callback_test(delegate* unmanaged[Cdecl]<int, int> cb);

        [DllImport(__DllName, EntryPoint = "csharp_to_rust", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void csharp_to_rust(delegate* unmanaged[Cdecl]<int, int, int> cb);

        [DllImport(__DllName, EntryPoint = "rust_to_csharp", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<int, int, int> rust_to_csharp();

        [DllImport(__DllName, EntryPoint = "sum", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sum(int x, int y);

        [DllImport(__DllName, EntryPoint = "cbt", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cbt(CallbackTable _cb);

        [DllImport(__DllName, EntryPoint = "nullable_callback_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int nullable_callback_test(delegate* unmanaged[Cdecl]<int, int> cb);

        [DllImport(__DllName, EntryPoint = "types_iroiro", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void types_iroiro(nint _i, nuint _u, CLong _cl, CULong _cul);

        [DllImport(__DllName, EntryPoint = "callback_test2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern delegate* unmanaged[Cdecl]<int, int> callback_test2();

        [DllImport(__DllName, EntryPoint = "callback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int callback(int a);

        [DllImport(__DllName, EntryPoint = "enum_test", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int enum_test(IntEnumTest i);

        [DllImport(__DllName, EntryPoint = "nop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void nop();

        [DllImport(__DllName, EntryPoint = "my_add", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int my_add(int x, int y);

        [DllImport(__DllName, EntryPoint = "create_counter_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern CounterContext* create_counter_context();

        [DllImport(__DllName, EntryPoint = "counter_context_insert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void counter_context_insert(CounterContext* context, int value);

        [DllImport(__DllName, EntryPoint = "destroy_counter_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void destroy_counter_context(CounterContext* context);

        [DllImport(__DllName, EntryPoint = "pass_vector3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void pass_vector3(MyVector3 v3);

        [DllImport(__DllName, EntryPoint = "return_union", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern MyUnion return_union();

        [DllImport(__DllName, EntryPoint = "my_bool", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool my_bool([MarshalAs(UnmanagedType.U1)] bool x, [MarshalAs(UnmanagedType.U1)] bool y, [MarshalAs(UnmanagedType.U1)] bool z, bool* xr, bool* yr, bool* zr);

        [DllImport(__DllName, EntryPoint = "alloc_c_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* alloc_c_string();

        [DllImport(__DllName, EntryPoint = "free_c_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_c_string(byte* str);

        [DllImport(__DllName, EntryPoint = "alloc_u8_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* alloc_u8_string();

        [DllImport(__DllName, EntryPoint = "free_u8_string", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_u8_string(ByteBuffer* buffer);

        [DllImport(__DllName, EntryPoint = "alloc_u8_buffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* alloc_u8_buffer();

        [DllImport(__DllName, EntryPoint = "free_u8_buffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_u8_buffer(ByteBuffer* buffer);

        [DllImport(__DllName, EntryPoint = "alloc_i32_buffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ByteBuffer* alloc_i32_buffer();

        [DllImport(__DllName, EntryPoint = "free_i32_buffer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void free_i32_buffer(ByteBuffer* buffer);

        [DllImport(__DllName, EntryPoint = "create_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Context* create_context();

        [DllImport(__DllName, EntryPoint = "delete_context", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void delete_context(Context* context);

        [DllImport(__DllName, EntryPoint = "call_bindgen", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void call_bindgen();

        [DllImport(__DllName, EntryPoint = "call_bindgen_lz4", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void call_bindgen_lz4();


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct JPH_ContactManifold
    {
        public float mPenetrationDepth;
        public fixed byte/* UInt128, this length is invalid so must keep pointer and can't edit from C# */ mWorldSpaceContactPointsOn1[65];
        public fixed byte/* UInt128, this length is invalid so must keep pointer and can't edit from C# */ mWorldSpaceContactPointsOn2[65];
        public fixed byte/* UInt128, this length is invalid so must keep pointer and can't edit from C# */ mWorldSpaceContactPointsOn3[65];
        public fixed byte/* UInt128, this length is invalid so must keep pointer and can't edit from C# */ mWorldSpaceContactPointsOn4[65];
        public fixed uint mWorldSpaceContactPointsOn5[65];
        public fixed byte png_name[5];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct my_int_vec3
    {
        public int Item1;
        public int Item2;
        public int Item3;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct NfcCard
    {
        public delegate* unmanaged[Cdecl]<ByteArray, ByteArray> @delegate;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ByteArray
    {
        public int i;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct @event
    {
        public int a;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct CounterContext
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    internal unsafe partial struct MyUnion
    {
        [FieldOffset(0)]
        public int foo;
        [FieldOffset(0)]
        public long bar;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct MyVector3
    {
        public float x;
        public float y;
        public float z;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct Context
    {
        [MarshalAs(UnmanagedType.U1)] public bool foo;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ByteBuffer
    {
        public byte* ptr;
        public int length;
        public int capacity;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct CallbackTable
    {
        public delegate* unmanaged[Cdecl]<void> foo;
        public delegate* unmanaged[Cdecl]<int, int> foobar;
    }


    [Flags]
    internal enum EnumFlags : uint
    {
        A = 0b00000001,
        B = 0b00000010,
        C = 0b00000100,
        ABC = A | B | C,
    }

    internal enum IntEnumTest : sbyte
    {
        A = 1,
        B = 2,
        C = 10,
    }


}
    