#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.IO.Compression.ZipArchive System.IO.Compression.ZipFile::Open(System.String,System.IO.Compression.ZipArchiveMode,System.Text.Encoding)
extern void ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D (void);
// 0x00000002 System.Void System.IO.Compression.ZipFile::CreateFromDirectory(System.String,System.String,System.IO.Compression.CompressionLevel,System.Boolean)
extern void ZipFile_CreateFromDirectory_m3DF528A8127C8C0CA942AA223FA153B61778F5ED (void);
// 0x00000003 System.Void System.IO.Compression.ZipFile::DoCreateFromDirectory(System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>,System.Boolean,System.Text.Encoding)
extern void ZipFile_DoCreateFromDirectory_m3225FCB59A0EDA74A3FED3858155FC2923DBD863 (void);
// 0x00000004 System.String System.IO.Compression.ZipFile::EntryFromPath(System.String,System.Int32,System.Int32,System.Char[]&,System.Boolean)
extern void ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A (void);
// 0x00000005 System.Void System.IO.Compression.ZipFile::EnsureCapacity(System.Char[]&,System.Int32)
extern void ZipFile_EnsureCapacity_m61A3D212DC6CBACFE57140BF095A849607493604 (void);
// 0x00000006 System.Boolean System.IO.Compression.ZipFile::IsDirEmpty(System.IO.DirectoryInfo)
extern void ZipFile_IsDirEmpty_m047A2732228B0C7A9CCEC311958381DCB264635C (void);
// 0x00000007 System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipFileExtensions::DoCreateEntryFromFile(System.IO.Compression.ZipArchive,System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>)
extern void ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26 (void);
static Il2CppMethodPointer s_methodPointers[7] = 
{
	ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D,
	ZipFile_CreateFromDirectory_m3DF528A8127C8C0CA942AA223FA153B61778F5ED,
	ZipFile_DoCreateFromDirectory_m3225FCB59A0EDA74A3FED3858155FC2923DBD863,
	ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A,
	ZipFile_EnsureCapacity_m61A3D212DC6CBACFE57140BF095A849607493604,
	ZipFile_IsDirEmpty_m047A2732228B0C7A9CCEC311958381DCB264635C,
	ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26,
};
static const int32_t s_InvokerIndices[7] = 
{
	11071,
	10567,
	9957,
	9692,
	12672,
	13678,
	10411,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_IO_Compression_FileSystem_CodeGenModule;
const Il2CppCodeGenModule g_System_IO_Compression_FileSystem_CodeGenModule = 
{
	"System.IO.Compression.FileSystem.dll",
	7,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
