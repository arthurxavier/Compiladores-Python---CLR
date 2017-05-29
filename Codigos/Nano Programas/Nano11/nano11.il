.assembly extern mscorlib
{
  .ver 4:0:0:0
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) // .z\V.4..
}
.assembly 'nano11'
{
  .custom instance void class [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::'.ctor'() =  (
		01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
		63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01       ) // ceptionThrows.

  .hash algorithm 0x00008004
  .ver  0:0:0:0
}
.module nano11.exe // GUID = {32A8C2EC-BE5E-43B3-B04E-10DF463DE8BD}


.namespace nano
{
  .class private auto ansi beforefieldinit Program
  	extends [mscorlib]System.Object
  {

    // method line 1
    .method public hidebysig specialname rtspecialname 
           instance default void '.ctor' ()  cil managed 
    {
        // Method begins at RVA 0x2050
	// Code size 7 (0x7)
	.maxstack 8
	IL_0000:  ldarg.0 
	IL_0001:  call instance void object::'.ctor'()
	IL_0006:  ret 
    } // end of method Program::.ctor

    // method line 2
    .method private static hidebysig 
           default void Main (string[] args)  cil managed 
    {
        // Method begins at RVA 0x2058
	.entrypoint
	// Code size 29 (0x1d)
	.maxstack 2
	.locals init (
		int32	V_0,
		int32	V_1,
		int32	V_2)
	IL_0000:  ldc.i4.1 
	IL_0001:  stloc.0 
	IL_0002:  ldc.i4.2 
	IL_0003:  stloc.1 
	IL_0004:  ldc.i4.5 
	IL_0005:  stloc.2 
	IL_0006:  br IL_0015

	IL_000b:  ldloc.0 
	IL_000c:  ldloc.1 
	IL_000d:  add 
	IL_000e:  stloc.0 
	IL_000f:  ldloc.0 
	IL_0010:  call void class [mscorlib]System.Console::WriteLine(int32)
	IL_0015:  ldloc.2 
	IL_0016:  ldloc.0 
	IL_0017:  bgt IL_000b

	IL_001c:  ret 
    } // end of method Program::Main

  } // end of class nano.Program
}

