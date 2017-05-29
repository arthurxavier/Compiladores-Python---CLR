.assembly extern mscorlib
{
  .ver 4:0:0:0
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) // .z\V.4..
}
.assembly 'nano12'
{
  .custom instance void class [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::'.ctor'() =  (
		01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
		63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01       ) // ceptionThrows.

  .hash algorithm 0x00008004
  .ver  0:0:0:0
}
.module nano12.exe // GUID = {73BA7430-DC1A-434C-A8D7-6509CACB50D7}


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
	// Code size 47 (0x2f)
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
	IL_0006:  br IL_0027

	IL_000b:  ldloc.0 
	IL_000c:  ldloc.1 
	IL_000d:  bne.un IL_001d

	IL_0012:  ldloc.0 
	IL_0013:  call void class [mscorlib]System.Console::WriteLine(int32)
	IL_0018:  br IL_0023

	IL_001d:  ldc.i4.0 
	IL_001e:  call void class [mscorlib]System.Console::WriteLine(int32)
	IL_0023:  ldloc.2 
	IL_0024:  ldc.i4.1 
	IL_0025:  sub 
	IL_0026:  stloc.2 
	IL_0027:  ldloc.2 
	IL_0028:  ldloc.0 
	IL_0029:  bgt IL_000b

	IL_002e:  ret 
    } // end of method Program::Main

  } // end of class nano.Program
}

