.assembly extern mscorlib
{
  .ver 4:0:0:0
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) // .z\V.4..
}
.assembly 'nano10'
{
  .custom instance void class [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::'.ctor'() =  (
		01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
		63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01       ) // ceptionThrows.

  .hash algorithm 0x00008004
  .ver  0:0:0:0
}
.module nano10.exe // GUID = {695DDFFE-6534-4A06-B362-9A4CA91C24CC}


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
		int32	V_1)
	IL_0000:  ldc.i4.1 
	IL_0001:  stloc.0 
	IL_0002:  ldc.i4.2 
	IL_0003:  stloc.1 
	IL_0004:  ldloc.0 
	IL_0005:  ldloc.1 
	IL_0006:  bne.un IL_0016

	IL_000b:  ldloc.0 
	IL_000c:  call void class [mscorlib]System.Console::WriteLine(int32)
	IL_0011:  br IL_001c

	IL_0016:  ldc.i4.0 
	IL_0017:  call void class [mscorlib]System.Console::WriteLine(int32)
	IL_001c:  ret 
    } // end of method Program::Main

  } // end of class nano.Program
}

