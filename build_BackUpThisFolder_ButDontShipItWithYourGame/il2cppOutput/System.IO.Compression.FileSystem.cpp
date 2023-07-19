#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1, typename T2>
struct VirtualActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Buffers.ArrayPool`1<System.Char>
struct ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding>
struct Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54;
// System.Collections.Generic.Dictionary`2<System.String,System.IO.Compression.ZipArchiveEntry>
struct Dictionary_2_tA1C10CF9D35962FF0289095A43DEE774B7F13C47;
// System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>
struct IEnumerable_1_t8D7AC720F84EFB74460403413F0F6BE54649BAF0;
// System.Collections.Generic.IEnumerable`1<System.String>
struct IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44;
// System.Collections.Generic.List`1<System.IO.Compression.ZipArchiveEntry>
struct List_1_tA389B1109F43128C89C6358C6B56C819460CF5B3;
// System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField>
struct List_1_t0845A5AAFB6B816C6E2719A0588604CE3A080FDC;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.IO.Compression.ZipArchiveEntry>
struct ReadOnlyCollection_1_t15A54E961DBC027444DA89894B8AD689A38CE9AC;
// System.Byte[][]
struct ByteU5BU5DU5BU5D_t19A0C6D66F22DF673E9CDB37DEF566FE0EC947FA;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129;
// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F;
// System.IO.BinaryReader
struct BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2;
// System.Text.DecoderFallback
struct DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90;
// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2;
// System.Text.EncoderFallback
struct EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293;
// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095;
// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.IO.MemoryStream
struct MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2;
// Microsoft.Win32.SafeHandles.SafeFileHandle
struct SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// System.IO.Compression.ZipArchive
struct ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41;
// System.IO.Compression.ZipArchiveEntry
struct ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;

IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_1_t8D7AC720F84EFB74460403413F0F6BE54649BAF0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_tB2588994D1BF27F8465E01E530B6EC04F04ED369_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral56F96CA2C7CD86A940882DB30231478A10E0B61F;
IL2CPP_EXTERN_C String_t* _stringLiteralAF248E82BE9EBA1ADBF067429FAEE5A5B6E05A74;
IL2CPP_EXTERN_C String_t* _stringLiteralD89ADD2DB1FBF30630EEA02FAAF144060CA0E908;
IL2CPP_EXTERN_C String_t* _stringLiteralE280D065A824A791F8305234D3E093FC9A5A90C7;
IL2CPP_EXTERN_C String_t* _stringLiteralEC39AAB8B28BCEDAFA6F3285CC603CE852769989;
IL2CPP_EXTERN_C const RuntimeMethod* ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1__ctor_m96D8F60EE929504A306033187F6FD0535FB8380A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_mEBB6F9CB853B438D075BB555958691054B188001_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_mE771FFC5C0CA05BC9996418326C1D36E8A33DB2A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D_RuntimeMethod_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t5C9D30A33D5BCEBCEE3B70E895505EE5A827FE73 
{
};

// System.Buffers.ArrayPool`1<System.Char>
struct ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B  : public RuntimeObject
{
};

// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095  : public RuntimeObject
{
	// System.Int32 System.Text.Encoding::m_codePage
	int32_t ___m_codePage_55;
	// System.Globalization.CodePageDataItem System.Text.Encoding::dataItem
	CodePageDataItem_t52460FA30AE37F4F26ACB81055E58002262F19F2* ___dataItem_56;
	// System.Boolean System.Text.Encoding::m_deserializedFromEverett
	bool ___m_deserializedFromEverett_57;
	// System.Boolean System.Text.Encoding::m_isReadOnly
	bool ___m_isReadOnly_58;
	// System.Text.EncoderFallback System.Text.Encoding::encoderFallback
	EncoderFallback_tD2C40CE114AA9D8E1F7196608B2D088548015293* ___encoderFallback_59;
	// System.Text.DecoderFallback System.Text.Encoding::decoderFallback
	DecoderFallback_t7324102215E4ED41EC065C02EB501CB0BC23CD90* ___decoderFallback_60;
};

// System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject* ____identity_0;
};
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// System.IO.Path
struct Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.IO.Compression.ZipArchive
struct ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41  : public RuntimeObject
{
	// System.IO.Stream System.IO.Compression.ZipArchive::_archiveStream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____archiveStream_0;
	// System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipArchive::_archiveStreamOwner
	ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* ____archiveStreamOwner_1;
	// System.IO.BinaryReader System.IO.Compression.ZipArchive::_archiveReader
	BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ____archiveReader_2;
	// System.IO.Compression.ZipArchiveMode System.IO.Compression.ZipArchive::_mode
	int32_t ____mode_3;
	// System.Collections.Generic.List`1<System.IO.Compression.ZipArchiveEntry> System.IO.Compression.ZipArchive::_entries
	List_1_tA389B1109F43128C89C6358C6B56C819460CF5B3* ____entries_4;
	// System.Collections.ObjectModel.ReadOnlyCollection`1<System.IO.Compression.ZipArchiveEntry> System.IO.Compression.ZipArchive::_entriesCollection
	ReadOnlyCollection_1_t15A54E961DBC027444DA89894B8AD689A38CE9AC* ____entriesCollection_5;
	// System.Collections.Generic.Dictionary`2<System.String,System.IO.Compression.ZipArchiveEntry> System.IO.Compression.ZipArchive::_entriesDictionary
	Dictionary_2_tA1C10CF9D35962FF0289095A43DEE774B7F13C47* ____entriesDictionary_6;
	// System.Boolean System.IO.Compression.ZipArchive::_readEntries
	bool ____readEntries_7;
	// System.Boolean System.IO.Compression.ZipArchive::_leaveOpen
	bool ____leaveOpen_8;
	// System.Int64 System.IO.Compression.ZipArchive::_centralDirectoryStart
	int64_t ____centralDirectoryStart_9;
	// System.Boolean System.IO.Compression.ZipArchive::_isDisposed
	bool ____isDisposed_10;
	// System.UInt32 System.IO.Compression.ZipArchive::_numberOfThisDisk
	uint32_t ____numberOfThisDisk_11;
	// System.Int64 System.IO.Compression.ZipArchive::_expectedNumberOfEntries
	int64_t ____expectedNumberOfEntries_12;
	// System.IO.Stream System.IO.Compression.ZipArchive::_backingStream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____backingStream_13;
	// System.Byte[] System.IO.Compression.ZipArchive::_archiveComment
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____archiveComment_14;
	// System.Text.Encoding System.IO.Compression.ZipArchive::_entryNameEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ____entryNameEncoding_15;
};

// System.IO.Compression.ZipFile
struct ZipFile_t18C9C6BB8ABF9F2AE85A0EB6FF918378A5745CC8  : public RuntimeObject
{
};

// System.IO.Compression.ZipFileExtensions
struct ZipFileExtensions_t06E75DEE7D8E222C1E0E563C2393652E251FD218  : public RuntimeObject
{
};

// System.Nullable`1<System.IO.Compression.CompressionLevel>
struct Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<System.Int32Enum>
struct Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<System.Int64>
struct Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int64_t ___value_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17 
{
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;
};

// System.DateTime
struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D 
{
	// System.UInt64 System.DateTime::_dateData
	uint64_t ____dateData_46;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.Stream/ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05* ____activeReadWriteTask_3;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ____asyncActiveSemaphore_4;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// Interop/Sys/FileStatus
struct FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 
{
	// Interop/Sys/FileStatusFlags Interop/Sys/FileStatus::Flags
	int32_t ___Flags_0;
	// System.Int32 Interop/Sys/FileStatus::Mode
	int32_t ___Mode_1;
	// System.UInt32 Interop/Sys/FileStatus::Uid
	uint32_t ___Uid_2;
	// System.UInt32 Interop/Sys/FileStatus::Gid
	uint32_t ___Gid_3;
	// System.Int64 Interop/Sys/FileStatus::Size
	int64_t ___Size_4;
	// System.Int64 Interop/Sys/FileStatus::ATime
	int64_t ___ATime_5;
	// System.Int64 Interop/Sys/FileStatus::ATimeNsec
	int64_t ___ATimeNsec_6;
	// System.Int64 Interop/Sys/FileStatus::MTime
	int64_t ___MTime_7;
	// System.Int64 Interop/Sys/FileStatus::MTimeNsec
	int64_t ___MTimeNsec_8;
	// System.Int64 Interop/Sys/FileStatus::CTime
	int64_t ___CTime_9;
	// System.Int64 Interop/Sys/FileStatus::CTimeNsec
	int64_t ___CTimeNsec_10;
	// System.Int64 Interop/Sys/FileStatus::BirthTime
	int64_t ___BirthTime_11;
	// System.Int64 Interop/Sys/FileStatus::BirthTimeNsec
	int64_t ___BirthTimeNsec_12;
	// System.Int64 Interop/Sys/FileStatus::Dev
	int64_t ___Dev_13;
	// System.Int64 Interop/Sys/FileStatus::Ino
	int64_t ___Ino_14;
	// System.UInt32 Interop/Sys/FileStatus::UserFlags
	uint32_t ___UserFlags_15;
};

// System.DateTimeOffset
struct DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 
{
	// System.DateTime System.DateTimeOffset::_dateTime
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ____dateTime_3;
	// System.Int16 System.DateTimeOffset::_offsetMinutes
	int16_t ____offsetMinutes_4;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5 
{
	// Interop/Sys/FileStatus System.IO.FileStatus::_fileStatus
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	// System.Int32 System.IO.FileStatus::_fileStatusInitialized
	int32_t ____fileStatusInitialized_1;
	// System.Boolean System.IO.FileStatus::<InitiallyDirectory>k__BackingField
	bool ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	// System.Boolean System.IO.FileStatus::_isDirectory
	bool ____isDirectory_3;
	// System.Boolean System.IO.FileStatus::_exists
	bool ____exists_4;
};
// Native definition for P/Invoke marshalling of System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5_marshaled_pinvoke
{
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	int32_t ____fileStatusInitialized_1;
	int32_t ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	int32_t ____isDirectory_3;
	int32_t ____exists_4;
};
// Native definition for COM marshalling of System.IO.FileStatus
struct FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5_marshaled_com
{
	FileStatus_tCB96EDE0D0F945F685B9BBED6DBF0731207458C2 ____fileStatus_0;
	int32_t ____fileStatusInitialized_1;
	int32_t ___U3CInitiallyDirectoryU3Ek__BackingField_2;
	int32_t ____isDirectory_3;
	int32_t ____exists_4;
};

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.FileStream::buf
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_7;
	// System.String System.IO.FileStream::name
	String_t* ___name_8;
	// Microsoft.Win32.SafeHandles.SafeFileHandle System.IO.FileStream::safeHandle
	SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E* ___safeHandle_9;
	// System.Boolean System.IO.FileStream::isExposed
	bool ___isExposed_10;
	// System.Int64 System.IO.FileStream::append_startpos
	int64_t ___append_startpos_11;
	// System.IO.FileAccess System.IO.FileStream::access
	int32_t ___access_12;
	// System.Boolean System.IO.FileStream::owner
	bool ___owner_13;
	// System.Boolean System.IO.FileStream::async
	bool ___async_14;
	// System.Boolean System.IO.FileStream::canseek
	bool ___canseek_15;
	// System.Boolean System.IO.FileStream::anonymous
	bool ___anonymous_16;
	// System.Boolean System.IO.FileStream::buf_dirty
	bool ___buf_dirty_17;
	// System.Int32 System.IO.FileStream::buf_size
	int32_t ___buf_size_18;
	// System.Int32 System.IO.FileStream::buf_length
	int32_t ___buf_length_19;
	// System.Int32 System.IO.FileStream::buf_offset
	int32_t ___buf_offset_20;
	// System.Int64 System.IO.FileStream::buf_start
	int64_t ___buf_start_21;
};

// System.IO.FileSystemInfo
struct FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.FileStatus System.IO.FileSystemInfo::_fileStatus
	FileStatus_tABB5F252F1E597EC95E9041035DC424EF66712A5 ____fileStatus_1;
	// System.String System.IO.FileSystemInfo::FullPath
	String_t* ___FullPath_2;
	// System.String System.IO.FileSystemInfo::OriginalPath
	String_t* ___OriginalPath_3;
	// System.String System.IO.FileSystemInfo::_name
	String_t* ____name_4;
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// System.IO.Compression.ZipArchiveEntry
struct ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4  : public RuntimeObject
{
	// System.IO.Compression.ZipArchive System.IO.Compression.ZipArchiveEntry::_archive
	ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* ____archive_0;
	// System.Boolean System.IO.Compression.ZipArchiveEntry::_originallyInArchive
	bool ____originallyInArchive_1;
	// System.Int32 System.IO.Compression.ZipArchiveEntry::_diskNumberStart
	int32_t ____diskNumberStart_2;
	// System.IO.Compression.ZipVersionMadeByPlatform System.IO.Compression.ZipArchiveEntry::_versionMadeByPlatform
	uint8_t ____versionMadeByPlatform_3;
	// System.IO.Compression.ZipVersionNeededValues System.IO.Compression.ZipArchiveEntry::_versionMadeBySpecification
	uint16_t ____versionMadeBySpecification_4;
	// System.IO.Compression.ZipVersionNeededValues System.IO.Compression.ZipArchiveEntry::_versionToExtract
	uint16_t ____versionToExtract_5;
	// System.IO.Compression.ZipArchiveEntry/BitFlagValues System.IO.Compression.ZipArchiveEntry::_generalPurposeBitFlag
	uint16_t ____generalPurposeBitFlag_6;
	// System.IO.Compression.ZipArchiveEntry/CompressionMethodValues System.IO.Compression.ZipArchiveEntry::_storedCompressionMethod
	uint16_t ____storedCompressionMethod_7;
	// System.DateTimeOffset System.IO.Compression.ZipArchiveEntry::_lastModified
	DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 ____lastModified_8;
	// System.Int64 System.IO.Compression.ZipArchiveEntry::_compressedSize
	int64_t ____compressedSize_9;
	// System.Int64 System.IO.Compression.ZipArchiveEntry::_uncompressedSize
	int64_t ____uncompressedSize_10;
	// System.Int64 System.IO.Compression.ZipArchiveEntry::_offsetOfLocalHeader
	int64_t ____offsetOfLocalHeader_11;
	// System.Nullable`1<System.Int64> System.IO.Compression.ZipArchiveEntry::_storedOffsetOfCompressedData
	Nullable_1_t365991B3904FDA7642A788423B28692FDC7CDB17 ____storedOffsetOfCompressedData_12;
	// System.UInt32 System.IO.Compression.ZipArchiveEntry::_crc32
	uint32_t ____crc32_13;
	// System.Byte[][] System.IO.Compression.ZipArchiveEntry::_compressedBytes
	ByteU5BU5DU5BU5D_t19A0C6D66F22DF673E9CDB37DEF566FE0EC947FA* ____compressedBytes_14;
	// System.IO.MemoryStream System.IO.Compression.ZipArchiveEntry::_storedUncompressedData
	MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* ____storedUncompressedData_15;
	// System.Boolean System.IO.Compression.ZipArchiveEntry::_currentlyOpenForWrite
	bool ____currentlyOpenForWrite_16;
	// System.Boolean System.IO.Compression.ZipArchiveEntry::_everOpenedForWrite
	bool ____everOpenedForWrite_17;
	// System.IO.Stream System.IO.Compression.ZipArchiveEntry::_outstandingWriteStream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ____outstandingWriteStream_18;
	// System.UInt32 System.IO.Compression.ZipArchiveEntry::_externalFileAttr
	uint32_t ____externalFileAttr_19;
	// System.String System.IO.Compression.ZipArchiveEntry::_storedEntryName
	String_t* ____storedEntryName_20;
	// System.Byte[] System.IO.Compression.ZipArchiveEntry::_storedEntryNameBytes
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____storedEntryNameBytes_21;
	// System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField> System.IO.Compression.ZipArchiveEntry::_cdUnknownExtraFields
	List_1_t0845A5AAFB6B816C6E2719A0588604CE3A080FDC* ____cdUnknownExtraFields_22;
	// System.Collections.Generic.List`1<System.IO.Compression.ZipGenericExtraField> System.IO.Compression.ZipArchiveEntry::_lhUnknownExtraFields
	List_1_t0845A5AAFB6B816C6E2719A0588604CE3A080FDC* ____lhUnknownExtraFields_23;
	// System.Byte[] System.IO.Compression.ZipArchiveEntry::_fileComment
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____fileComment_24;
	// System.Nullable`1<System.IO.Compression.CompressionLevel> System.IO.Compression.ZipArchiveEntry::_compressionLevel
	Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 ____compressionLevel_25;
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
};

// System.IO.FileInfo
struct FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
};

// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
};

// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
	// System.Object System.ArgumentOutOfRangeException::_actualValue
	RuntimeObject* ____actualValue_19;
};

// <Module>

// <Module>

// System.Buffers.ArrayPool`1<System.Char>
struct ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_StaticFields
{
	// System.Buffers.ArrayPool`1<T> System.Buffers.ArrayPool`1::<Shared>k__BackingField
	ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* ___U3CSharedU3Ek__BackingField_0;
};

// System.Buffers.ArrayPool`1<System.Char>

// System.Text.Encoding
struct Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095_StaticFields
{
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::defaultEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___defaultEncoding_0;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::unicodeEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___unicodeEncoding_1;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::bigEndianUnicode
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___bigEndianUnicode_2;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf7Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf7Encoding_3;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf8Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf8Encoding_4;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf32Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___utf32Encoding_5;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::asciiEncoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___asciiEncoding_6;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::latin1Encoding
	Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___latin1Encoding_7;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Text.Encoding> modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::encodings
	Dictionary_2_t87EDE08B2E48F793A22DE50D6B3CC2E7EBB2DB54* ___encodings_8;
	// System.Object System.Text.Encoding::s_InternalSyncObject
	RuntimeObject* ___s_InternalSyncObject_61;
};

// System.Text.Encoding

// System.IO.Path
struct Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_StaticFields
{
	// System.Char[] System.IO.Path::InvalidPathChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___InvalidPathChars_0;
	// System.Char System.IO.Path::AltDirectorySeparatorChar
	Il2CppChar ___AltDirectorySeparatorChar_1;
	// System.Char System.IO.Path::DirectorySeparatorChar
	Il2CppChar ___DirectorySeparatorChar_2;
	// System.Char System.IO.Path::PathSeparator
	Il2CppChar ___PathSeparator_3;
	// System.String System.IO.Path::DirectorySeparatorStr
	String_t* ___DirectorySeparatorStr_4;
	// System.Char System.IO.Path::VolumeSeparatorChar
	Il2CppChar ___VolumeSeparatorChar_5;
	// System.Char[] System.IO.Path::PathSeparatorChars
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___PathSeparatorChars_6;
	// System.Boolean System.IO.Path::dirEqualsVolume
	bool ___dirEqualsVolume_7;
	// System.Char[] System.IO.Path::trimEndCharsWindows
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___trimEndCharsWindows_8;
	// System.Char[] System.IO.Path::trimEndCharsUnix
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___trimEndCharsUnix_9;
};

// System.IO.Path

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.IO.Compression.ZipArchive

// System.IO.Compression.ZipArchive

// System.IO.Compression.ZipFile

// System.IO.Compression.ZipFile

// System.IO.Compression.ZipFileExtensions

// System.IO.Compression.ZipFileExtensions

// System.Nullable`1<System.IO.Compression.CompressionLevel>

// System.Nullable`1<System.IO.Compression.CompressionLevel>

// System.Nullable`1<System.Int32Enum>

// System.Nullable`1<System.Int32Enum>

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17_StaticFields
{
	// System.Byte[] System.Char::s_categoryForLatin1
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___s_categoryForLatin1_3;
};

// System.Char

// System.DateTime
struct DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D_StaticFields
{
	// System.Int32[] System.DateTime::s_daysToMonth365
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth365_30;
	// System.Int32[] System.DateTime::s_daysToMonth366
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___s_daysToMonth366_31;
	// System.DateTime System.DateTime::MinValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MinValue_32;
	// System.DateTime System.DateTime::MaxValue
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___MaxValue_33;
	// System.DateTime System.DateTime::UnixEpoch
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___UnixEpoch_34;
};

// System.DateTime

// System.Int32

// System.Int32

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE_StaticFields
{
	// System.IO.Stream System.IO.Stream::Null
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___Null_1;
};

// System.IO.Stream

// System.Void

// System.Void

// System.DateTimeOffset
struct DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4_StaticFields
{
	// System.DateTimeOffset System.DateTimeOffset::MinValue
	DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 ___MinValue_0;
	// System.DateTimeOffset System.DateTimeOffset::MaxValue
	DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 ___MaxValue_1;
	// System.DateTimeOffset System.DateTimeOffset::UnixEpoch
	DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 ___UnixEpoch_2;
};

// System.DateTimeOffset

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_StaticFields
{
	// System.Byte[] System.IO.FileStream::buf_recycle
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_recycle_5;
	// System.Object System.IO.FileStream::buf_recycle_lock
	RuntimeObject* ___buf_recycle_lock_6;
};

// System.IO.FileStream

// System.IO.FileSystemInfo

// System.IO.FileSystemInfo

// System.IO.Compression.ZipArchiveEntry
struct ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4_StaticFields
{
	// System.Boolean System.IO.Compression.ZipArchiveEntry::s_allowLargeZipArchiveEntriesInUpdateMode
	bool ___s_allowLargeZipArchiveEntriesInUpdateMode_26;
	// System.IO.Compression.ZipVersionMadeByPlatform System.IO.Compression.ZipArchiveEntry::CurrentZipPlatform
	uint8_t ___CurrentZipPlatform_27;
};

// System.IO.Compression.ZipArchiveEntry

// System.IO.DirectoryInfo

// System.IO.DirectoryInfo

// System.IO.FileInfo

// System.IO.FileInfo

// System.ArgumentNullException

// System.ArgumentNullException

// System.ArgumentOutOfRangeException

// System.ArgumentOutOfRangeException
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB  : public RuntimeArray
{
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};


// System.Void System.Nullable`1<System.Int32Enum>::.ctor(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Nullable_1__ctor_m5100B58428BDAD8C79F3D8576B0C2E1D4F3924EB_gshared (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Buffers.ArrayPool`1<T> System.Buffers.ArrayPool`1<System.Char>::get_Shared()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_gshared_inline (const RuntimeMethod* method) ;
// System.Boolean System.Nullable`1<System.Int32Enum>::get_HasValue()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;
// T System.Nullable`1<System.Int32Enum>::get_Value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Nullable_1_get_Value_m0E81D9B6F2BA5FA17AA4366C5179CD09524FCB60_gshared (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) ;

// System.Void System.ArgumentOutOfRangeException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentOutOfRangeException__ctor_mBC1D5DEEA1BA41DE77228CB27D6BAFEB6DCCBF4A (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* __this, String_t* ___0_paramName, const RuntimeMethod* method) ;
// System.Void System.IO.FileStream::.ctor(System.String,System.IO.FileMode,System.IO.FileAccess,System.IO.FileShare,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FileStream__ctor_mB51E4FD96A6B396795C835EFD7B0F0018A3A5029 (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* __this, String_t* ___0_path, int32_t ___1_mode, int32_t ___2_access, int32_t ___3_share, int32_t ___4_bufferSize, bool ___5_useAsync, const RuntimeMethod* method) ;
// System.Void System.IO.Compression.ZipArchive::.ctor(System.IO.Stream,System.IO.Compression.ZipArchiveMode,System.Boolean,System.Text.Encoding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipArchive__ctor_m2706DA413E897A83057237178CCC8E51C07230B5 (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_stream, int32_t ___1_mode, bool ___2_leaveOpen, Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___3_entryNameEncoding, const RuntimeMethod* method) ;
// System.Void System.IO.Stream::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stream_Dispose_mCDB42F32A17541CCA6D3A5906827A401570B07A8 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* __this, const RuntimeMethod* method) ;
// System.Void System.Nullable`1<System.IO.Compression.CompressionLevel>::.ctor(T)
inline void Nullable_1__ctor_m96D8F60EE929504A306033187F6FD0535FB8380A (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1* __this, int32_t ___0_value, const RuntimeMethod* method)
{
	((  void (*) (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1*, int32_t, const RuntimeMethod*))Nullable_1__ctor_m5100B58428BDAD8C79F3D8576B0C2E1D4F3924EB_gshared)(__this, ___0_value, method);
}
// System.Void System.IO.Compression.ZipFile::DoCreateFromDirectory(System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>,System.Boolean,System.Text.Encoding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFile_DoCreateFromDirectory_m3225FCB59A0EDA74A3FED3858155FC2923DBD863 (String_t* ___0_sourceDirectoryName, String_t* ___1_destinationArchiveFileName, Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 ___2_compressionLevel, bool ___3_includeBaseDirectory, Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___4_entryNameEncoding, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetFullPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFullPath_m9E485D7D38A868A6A5863CBD24677231288EECE2 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.IO.Compression.ZipArchive System.IO.Compression.ZipFile::Open(System.String,System.IO.Compression.ZipArchiveMode,System.Text.Encoding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D (String_t* ___0_archiveFileName, int32_t ___1_mode, Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___2_entryNameEncoding, const RuntimeMethod* method) ;
// System.Void System.IO.DirectoryInfo::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9 (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, String_t* ___0_path, const RuntimeMethod* method) ;
// System.IO.DirectoryInfo System.IO.DirectoryInfo::get_Parent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* DirectoryInfo_get_Parent_m2B95E4D3CBA22F8DAA259247ED791F1411D93347 (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, const RuntimeMethod* method) ;
// System.Buffers.ArrayPool`1<T> System.Buffers.ArrayPool`1<System.Char>::get_Shared()
inline ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_inline (const RuntimeMethod* method)
{
	return ((  ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* (*) (const RuntimeMethod*))ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_gshared_inline)(method);
}
// System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo> System.IO.DirectoryInfo::EnumerateFileSystemInfos(System.String,System.IO.SearchOption)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* DirectoryInfo_EnumerateFileSystemInfos_m63DB502DF1805313E60569E012AA90B190BD3149 (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, String_t* ___0_searchPattern, int32_t ___1_searchOption, const RuntimeMethod* method) ;
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
// System.String System.IO.Compression.ZipFile::EntryFromPath(System.String,System.Int32,System.Int32,System.Char[]&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A (String_t* ___0_entry, int32_t ___1_offset, int32_t ___2_length, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** ___3_buffer, bool ___4_appendPathSeparator, const RuntimeMethod* method) ;
// System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipFileExtensions::DoCreateEntryFromFile(System.IO.Compression.ZipArchive,System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26 (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* ___0_destination, String_t* ___1_sourceFileName, String_t* ___2_entryName, Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 ___3_compressionLevel, const RuntimeMethod* method) ;
// System.Boolean System.IO.Compression.ZipFile::IsDirEmpty(System.IO.DirectoryInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ZipFile_IsDirEmpty_m047A2732228B0C7A9CCEC311958381DCB264635C (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* ___0_possiblyEmptyDir, const RuntimeMethod* method) ;
// System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipArchive::CreateEntry(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* ZipArchive_CreateEntry_m52C487BC25504F8951CE8927F64778DC417CE88E (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* __this, String_t* ___0_entryName, const RuntimeMethod* method) ;
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3 (String_t* __this, int32_t ___0_index, const RuntimeMethod* method) ;
// System.String System.Char::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Char_ToString_m2A308731F9577C06AF3C0901234E2EAC8327410C (Il2CppChar* __this, const RuntimeMethod* method) ;
// System.Void System.IO.Compression.ZipFile::EnsureCapacity(System.Char[]&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFile_EnsureCapacity_m61A3D212DC6CBACFE57140BF095A849607493604 (CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** ___0_buffer, int32_t ___1_min, const RuntimeMethod* method) ;
// System.Void System.String::CopyTo(System.Int32,System.Char[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void String_CopyTo_m6E1DE99F2A6481B3B9839C8A026C74887C10A1DC (String_t* __this, int32_t ___0_sourceIndex, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___1_destination, int32_t ___2_destinationIndex, int32_t ___3_count, const RuntimeMethod* method) ;
// System.String System.String::CreateString(System.Char[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_CreateString_mB7B3AC2AF28010538650051A9000369B1CD6BAB6 (String_t* __this, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___0_val, int32_t ___1_startIndex, int32_t ___2_length, const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerable`1<System.String> System.IO.Directory::EnumerateFileSystemEntries(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Directory_EnumerateFileSystemEntries_mFC14748938E7979CA5472FB025BABE5448E9E216 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Void System.ArgumentNullException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* __this, String_t* ___0_paramName, const RuntimeMethod* method) ;
// System.Boolean System.Nullable`1<System.IO.Compression.CompressionLevel>::get_HasValue()
inline bool Nullable_1_get_HasValue_mEBB6F9CB853B438D075BB555958691054B188001_inline (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1*, const RuntimeMethod*))Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline)(__this, method);
}
// T System.Nullable`1<System.IO.Compression.CompressionLevel>::get_Value()
inline int32_t Nullable_1_get_Value_mE771FFC5C0CA05BC9996418326C1D36E8A33DB2A (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1*, const RuntimeMethod*))Nullable_1_get_Value_m0E81D9B6F2BA5FA17AA4366C5179CD09524FCB60_gshared)(__this, method);
}
// System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipArchive::CreateEntry(System.String,System.IO.Compression.CompressionLevel)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* ZipArchive_CreateEntry_m52B44886A7D190AA27F6CA6C56BF5BBA39AE16D3 (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* __this, String_t* ___0_entryName, int32_t ___1_compressionLevel, const RuntimeMethod* method) ;
// System.DateTime System.IO.File::GetLastWriteTime(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D File_GetLastWriteTime_m5DD0EAF55C3F704DDB7AC9919504C6FCB6DD6621 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Int32 System.DateTime::get_Year()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t DateTime_get_Year_m00A88C4CEE07B7906F5F7F75C254B769808F5138 (DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D* __this, const RuntimeMethod* method) ;
// System.Void System.DateTime::.ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DateTime__ctor_m1F66A4327FE6B127F0F0E83A70CED25DB0DFFB00 (DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D* __this, int32_t ___0_year, int32_t ___1_month, int32_t ___2_day, int32_t ___3_hour, int32_t ___4_minute, int32_t ___5_second, const RuntimeMethod* method) ;
// System.DateTimeOffset System.DateTimeOffset::op_Implicit(System.DateTime)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 DateTimeOffset_op_Implicit_m7BFCB56BB3714FA7E58AA0ECEE92B8455A0CEDA5 (DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D ___0_dateTime, const RuntimeMethod* method) ;
// System.Void System.IO.Compression.ZipArchiveEntry::set_LastWriteTime(System.DateTimeOffset)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipArchiveEntry_set_LastWriteTime_mB37B15E966275E236647AC8F23EC9D03B7C124A7 (ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* __this, DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 ___0_value, const RuntimeMethod* method) ;
// System.IO.Stream System.IO.Compression.ZipArchiveEntry::Open()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ZipArchiveEntry_Open_m1D0EFB9AD33BA96AAF0C624EADA3E58CD6CC67FF (ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* __this, const RuntimeMethod* method) ;
// System.Void System.IO.Stream::CopyTo(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Stream_CopyTo_m61DC54FF3708C2B8AB5C5D63D300AA57ADA01999 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_destination, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.IO.Compression.ZipArchive System.IO.Compression.ZipFile::Open(System.String,System.IO.Compression.ZipArchiveMode,System.Text.Encoding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D (String_t* ___0_archiveFileName, int32_t ___1_mode, Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___2_entryNameEncoding, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_3 = NULL;
	ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	{
		int32_t L_0 = ___1_mode;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0014;
			}
			case 1:
			{
				goto IL_001c;
			}
			case 2:
			{
				goto IL_0024;
			}
		}
	}
	{
		goto IL_002c;
	}

IL_0014:
	{
		V_0 = 3;
		V_1 = 1;
		V_2 = 1;
		goto IL_0037;
	}

IL_001c:
	{
		V_0 = 1;
		V_1 = 2;
		V_2 = 0;
		goto IL_0037;
	}

IL_0024:
	{
		V_0 = 4;
		V_1 = 3;
		V_2 = 0;
		goto IL_0037;
	}

IL_002c:
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_1 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_1);
		ArgumentOutOfRangeException__ctor_mBC1D5DEEA1BA41DE77228CB27D6BAFEB6DCCBF4A(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralAF248E82BE9EBA1ADBF067429FAEE5A5B6E05A74)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D_RuntimeMethod_var)));
	}

IL_0037:
	{
		String_t* L_2 = ___0_archiveFileName;
		int32_t L_3 = V_0;
		int32_t L_4 = V_1;
		int32_t L_5 = V_2;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_6 = (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8*)il2cpp_codegen_object_new(FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		FileStream__ctor_mB51E4FD96A6B396795C835EFD7B0F0018A3A5029(L_6, L_2, L_3, L_4, L_5, ((int32_t)4096), (bool)0, NULL);
		V_3 = L_6;
	}
	try
	{// begin try (depth: 1)
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_7 = V_3;
		int32_t L_8 = ___1_mode;
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_9 = ___2_entryNameEncoding;
		ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_10 = (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41*)il2cpp_codegen_object_new(ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41_il2cpp_TypeInfo_var);
		NullCheck(L_10);
		ZipArchive__ctor_m2706DA413E897A83057237178CCC8E51C07230B5(L_10, L_7, L_8, (bool)0, L_9, NULL);
		V_4 = L_10;
		goto IL_005d;
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0054;
		}
		throw e;
	}

CATCH_0054:
	{// begin catch(System.Object)
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_11 = V_3;
		NullCheck(L_11);
		Stream_Dispose_mCDB42F32A17541CCA6D3A5906827A401570B07A8(L_11, NULL);
		IL2CPP_RETHROW_MANAGED_EXCEPTION(IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*));
	}// end catch (depth: 1)

IL_005d:
	{
		ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_12 = V_4;
		return L_12;
	}
}
// System.Void System.IO.Compression.ZipFile::CreateFromDirectory(System.String,System.String,System.IO.Compression.CompressionLevel,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFile_CreateFromDirectory_m3DF528A8127C8C0CA942AA223FA153B61778F5ED (String_t* ___0_sourceDirectoryName, String_t* ___1_destinationArchiveFileName, int32_t ___2_compressionLevel, bool ___3_includeBaseDirectory, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1__ctor_m96D8F60EE929504A306033187F6FD0535FB8380A_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___0_sourceDirectoryName;
		String_t* L_1 = ___1_destinationArchiveFileName;
		int32_t L_2 = ___2_compressionLevel;
		Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 L_3;
		memset((&L_3), 0, sizeof(L_3));
		Nullable_1__ctor_m96D8F60EE929504A306033187F6FD0535FB8380A((&L_3), L_2, /*hidden argument*/Nullable_1__ctor_m96D8F60EE929504A306033187F6FD0535FB8380A_RuntimeMethod_var);
		bool L_4 = ___3_includeBaseDirectory;
		ZipFile_DoCreateFromDirectory_m3225FCB59A0EDA74A3FED3858155FC2923DBD863(L_0, L_1, L_3, L_4, (Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095*)NULL, NULL);
		return;
	}
}
// System.Void System.IO.Compression.ZipFile::DoCreateFromDirectory(System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>,System.Boolean,System.Text.Encoding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFile_DoCreateFromDirectory_m3225FCB59A0EDA74A3FED3858155FC2923DBD863 (String_t* ___0_sourceDirectoryName, String_t* ___1_destinationArchiveFileName, Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 ___2_compressionLevel, bool ___3_includeBaseDirectory, Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* ___4_entryNameEncoding, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_1_t8D7AC720F84EFB74460403413F0F6BE54649BAF0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tB2588994D1BF27F8465E01E530B6EC04F04ED369_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE280D065A824A791F8305234D3E093FC9A5A90C7);
		s_Il2CppMethodInitialized = true;
	}
	ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* V_0 = NULL;
	bool V_1 = false;
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_2 = NULL;
	String_t* V_3 = NULL;
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* V_6 = NULL;
	int32_t V_7 = 0;
	String_t* V_8 = NULL;
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_9 = NULL;
	String_t* V_10 = NULL;
	{
		String_t* L_0 = ___0_sourceDirectoryName;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = Path_GetFullPath_m9E485D7D38A868A6A5863CBD24677231288EECE2(L_0, NULL);
		___0_sourceDirectoryName = L_1;
		String_t* L_2 = ___1_destinationArchiveFileName;
		String_t* L_3;
		L_3 = Path_GetFullPath_m9E485D7D38A868A6A5863CBD24677231288EECE2(L_2, NULL);
		___1_destinationArchiveFileName = L_3;
		String_t* L_4 = ___1_destinationArchiveFileName;
		Encoding_t65CDEF28CF20A7B8C92E85A4E808920C2465F095* L_5 = ___4_entryNameEncoding;
		ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_6;
		L_6 = ZipFile_Open_m6F83ACFED32799E052503C5CEAE6DD0D145FCC8D(L_4, 1, L_5, NULL);
		V_0 = L_6;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0147:
			{// begin finally (depth: 1)
				{
					ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_7 = V_0;
					if (!L_7)
					{
						goto IL_0150;
					}
				}
				{
					ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_8 = V_0;
					NullCheck(L_8);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_8);
				}

IL_0150:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				V_1 = (bool)1;
				String_t* L_9 = ___0_sourceDirectoryName;
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_10 = (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)il2cpp_codegen_object_new(DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
				NullCheck(L_10);
				DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9(L_10, L_9, NULL);
				V_2 = L_10;
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_11 = V_2;
				NullCheck(L_11);
				String_t* L_12;
				L_12 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_11);
				V_3 = L_12;
				bool L_13 = ___3_includeBaseDirectory;
				if (!L_13)
				{
					goto IL_0041_1;
				}
			}
			{
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_14 = V_2;
				NullCheck(L_14);
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_15;
				L_15 = DirectoryInfo_get_Parent_m2B95E4D3CBA22F8DAA259247ED791F1411D93347(L_14, NULL);
				if (!L_15)
				{
					goto IL_0041_1;
				}
			}
			{
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_16 = V_2;
				NullCheck(L_16);
				DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_17;
				L_17 = DirectoryInfo_get_Parent_m2B95E4D3CBA22F8DAA259247ED791F1411D93347(L_16, NULL);
				NullCheck(L_17);
				String_t* L_18;
				L_18 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_17);
				V_3 = L_18;
			}

IL_0041_1:
			{
				il2cpp_codegen_runtime_class_init_inline(ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var);
				ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* L_19;
				L_19 = ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_inline(ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
				NullCheck(L_19);
				CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_20;
				L_20 = VirtualFuncInvoker1< CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*, int32_t >::Invoke(4 /* T[] System.Buffers.ArrayPool`1<System.Char>::Rent(System.Int32) */, L_19, ((int32_t)260));
				V_4 = L_20;
			}
			{
				auto __finallyBlock = il2cpp::utils::Finally([&]
				{

FINALLY_0139_1:
					{// begin finally (depth: 2)
						il2cpp_codegen_runtime_class_init_inline(ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var);
						ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* L_21;
						L_21 = ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_inline(ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
						CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_22 = V_4;
						NullCheck(L_21);
						VirtualActionInvoker2< CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*, bool >::Invoke(5 /* System.Void System.Buffers.ArrayPool`1<System.Char>::Return(T[],System.Boolean) */, L_21, L_22, (bool)0);
						return;
					}// end finally (depth: 2)
				});
				try
				{// begin try (depth: 2)
					{
						DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_23 = V_2;
						NullCheck(L_23);
						RuntimeObject* L_24;
						L_24 = DirectoryInfo_EnumerateFileSystemInfos_m63DB502DF1805313E60569E012AA90B190BD3149(L_23, _stringLiteralE280D065A824A791F8305234D3E093FC9A5A90C7, 1, NULL);
						NullCheck(L_24);
						RuntimeObject* L_25;
						L_25 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>::GetEnumerator() */, IEnumerable_1_t8D7AC720F84EFB74460403413F0F6BE54649BAF0_il2cpp_TypeInfo_var, L_24);
						V_5 = L_25;
					}
					{
						auto __finallyBlock = il2cpp::utils::Finally([&]
						{

FINALLY_0105_2:
							{// begin finally (depth: 3)
								{
									RuntimeObject* L_26 = V_5;
									if (!L_26)
									{
										goto IL_0110_2;
									}
								}
								{
									RuntimeObject* L_27 = V_5;
									NullCheck(L_27);
									InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_27);
								}

IL_0110_2:
								{
									return;
								}
							}// end finally (depth: 3)
						});
						try
						{// begin try (depth: 3)
							{
								goto IL_00f7_3;
							}

IL_006a_3:
							{
								RuntimeObject* L_28 = V_5;
								NullCheck(L_28);
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_29;
								L_29 = InterfaceFuncInvoker0< FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.IO.FileSystemInfo>::get_Current() */, IEnumerator_1_tB2588994D1BF27F8465E01E530B6EC04F04ED369_il2cpp_TypeInfo_var, L_28);
								V_6 = L_29;
								V_1 = (bool)0;
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_30 = V_6;
								NullCheck(L_30);
								String_t* L_31;
								L_31 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_30);
								NullCheck(L_31);
								int32_t L_32;
								L_32 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_31, NULL);
								String_t* L_33 = V_3;
								NullCheck(L_33);
								int32_t L_34;
								L_34 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_33, NULL);
								V_7 = ((int32_t)il2cpp_codegen_subtract(L_32, L_34));
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_35 = V_6;
								if (!((FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C*)IsInstSealed((RuntimeObject*)L_35, FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C_il2cpp_TypeInfo_var)))
								{
									goto IL_00bf_3;
								}
							}
							{
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_36 = V_6;
								NullCheck(L_36);
								String_t* L_37;
								L_37 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_36);
								String_t* L_38 = V_3;
								NullCheck(L_38);
								int32_t L_39;
								L_39 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_38, NULL);
								int32_t L_40 = V_7;
								String_t* L_41;
								L_41 = ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A(L_37, L_39, L_40, (&V_4), (bool)0, NULL);
								V_8 = L_41;
								ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_42 = V_0;
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_43 = V_6;
								NullCheck(L_43);
								String_t* L_44;
								L_44 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_43);
								String_t* L_45 = V_8;
								Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 L_46 = ___2_compressionLevel;
								ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_47;
								L_47 = ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26(L_42, L_44, L_45, L_46, NULL);
								goto IL_00f7_3;
							}

IL_00bf_3:
							{
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_48 = V_6;
								V_9 = ((DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)IsInstSealed((RuntimeObject*)L_48, DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var));
								DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_49 = V_9;
								if (!L_49)
								{
									goto IL_00f7_3;
								}
							}
							{
								DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_50 = V_9;
								bool L_51;
								L_51 = ZipFile_IsDirEmpty_m047A2732228B0C7A9CCEC311958381DCB264635C(L_50, NULL);
								if (!L_51)
								{
									goto IL_00f7_3;
								}
							}
							{
								FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_52 = V_6;
								NullCheck(L_52);
								String_t* L_53;
								L_53 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_52);
								String_t* L_54 = V_3;
								NullCheck(L_54);
								int32_t L_55;
								L_55 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_54, NULL);
								int32_t L_56 = V_7;
								String_t* L_57;
								L_57 = ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A(L_53, L_55, L_56, (&V_4), (bool)1, NULL);
								V_10 = L_57;
								ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_58 = V_0;
								String_t* L_59 = V_10;
								NullCheck(L_58);
								ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_60;
								L_60 = ZipArchive_CreateEntry_m52C487BC25504F8951CE8927F64778DC417CE88E(L_58, L_59, NULL);
							}

IL_00f7_3:
							{
								RuntimeObject* L_61 = V_5;
								NullCheck(L_61);
								bool L_62;
								L_62 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_61);
								if (L_62)
								{
									goto IL_006a_3;
								}
							}
							{
								goto IL_0111_2;
							}
						}// end try (depth: 3)
						catch(Il2CppExceptionWrapper& e)
						{
							__finallyBlock.StoreException(e.ex);
						}
					}

IL_0111_2:
					{
						bool L_63 = ___3_includeBaseDirectory;
						bool L_64 = V_1;
						if (!((int32_t)((int32_t)L_63&(int32_t)L_64)))
						{
							goto IL_0137_2;
						}
					}
					{
						ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_65 = V_0;
						DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_66 = V_2;
						NullCheck(L_66);
						String_t* L_67;
						L_67 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_66);
						DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_68 = V_2;
						NullCheck(L_68);
						String_t* L_69;
						L_69 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_68);
						NullCheck(L_69);
						int32_t L_70;
						L_70 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_69, NULL);
						String_t* L_71;
						L_71 = ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A(L_67, 0, L_70, (&V_4), (bool)1, NULL);
						NullCheck(L_65);
						ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_72;
						L_72 = ZipArchive_CreateEntry_m52C487BC25504F8951CE8927F64778DC417CE88E(L_65, L_71, NULL);
					}

IL_0137_2:
					{
						goto IL_0151;
					}
				}// end try (depth: 2)
				catch(Il2CppExceptionWrapper& e)
				{
					__finallyBlock.StoreException(e.ex);
				}
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0151:
	{
		return;
	}
}
// System.String System.IO.Compression.ZipFile::EntryFromPath(System.String,System.Int32,System.Int32,System.Char[]&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ZipFile_EntryFromPath_m86DD579B0B7191BD2C961B8E47BC3832A82FCE7A (String_t* ___0_entry, int32_t ___1_offset, int32_t ___2_length, CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** ___3_buffer, bool ___4_appendPathSeparator, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Il2CppChar V_1 = 0x0;
	int32_t V_2 = 0;
	Il2CppChar V_3 = 0x0;
	int32_t G_B12_0 = 0;
	{
		goto IL_0028;
	}

IL_0002:
	{
		String_t* L_0 = ___0_entry;
		int32_t L_1 = ___1_offset;
		NullCheck(L_0);
		Il2CppChar L_2;
		L_2 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_0, L_1, NULL);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		Il2CppChar L_3 = ((Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_StaticFields*)il2cpp_codegen_static_fields_for(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var))->___DirectorySeparatorChar_2;
		if ((((int32_t)L_2) == ((int32_t)L_3)))
		{
			goto IL_001e;
		}
	}
	{
		String_t* L_4 = ___0_entry;
		int32_t L_5 = ___1_offset;
		NullCheck(L_4);
		Il2CppChar L_6;
		L_6 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_4, L_5, NULL);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		Il2CppChar L_7 = ((Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_StaticFields*)il2cpp_codegen_static_fields_for(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var))->___AltDirectorySeparatorChar_1;
		if ((!(((uint32_t)L_6) == ((uint32_t)L_7))))
		{
			goto IL_002c;
		}
	}

IL_001e:
	{
		int32_t L_8 = ___1_offset;
		___1_offset = ((int32_t)il2cpp_codegen_add(L_8, 1));
		int32_t L_9 = ___2_length;
		___2_length = ((int32_t)il2cpp_codegen_subtract(L_9, 1));
	}

IL_0028:
	{
		int32_t L_10 = ___2_length;
		if ((((int32_t)L_10) > ((int32_t)0)))
		{
			goto IL_0002;
		}
	}

IL_002c:
	{
		int32_t L_11 = ___2_length;
		if (L_11)
		{
			goto IL_0044;
		}
	}
	{
		bool L_12 = ___4_appendPathSeparator;
		if (L_12)
		{
			goto IL_0039;
		}
	}
	{
		String_t* L_13 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		return L_13;
	}

IL_0039:
	{
		V_1 = ((int32_t)47);
		String_t* L_14;
		L_14 = Char_ToString_m2A308731F9577C06AF3C0901234E2EAC8327410C((&V_1), NULL);
		return L_14;
	}

IL_0044:
	{
		bool L_15 = ___4_appendPathSeparator;
		if (L_15)
		{
			goto IL_004b;
		}
	}
	{
		int32_t L_16 = ___2_length;
		G_B12_0 = L_16;
		goto IL_004e;
	}

IL_004b:
	{
		int32_t L_17 = ___2_length;
		G_B12_0 = ((int32_t)il2cpp_codegen_add(L_17, 1));
	}

IL_004e:
	{
		V_0 = G_B12_0;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_18 = ___3_buffer;
		int32_t L_19 = V_0;
		ZipFile_EnsureCapacity_m61A3D212DC6CBACFE57140BF095A849607493604(L_18, L_19, NULL);
		String_t* L_20 = ___0_entry;
		int32_t L_21 = ___1_offset;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_22 = ___3_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_23 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_22);
		int32_t L_24 = ___2_length;
		NullCheck(L_20);
		String_CopyTo_m6E1DE99F2A6481B3B9839C8A026C74887C10A1DC(L_20, L_21, L_23, 0, L_24, NULL);
		V_2 = 0;
		goto IL_0084;
	}

IL_0065:
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_25 = ___3_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_26 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_25);
		int32_t L_27 = V_2;
		NullCheck(L_26);
		int32_t L_28 = L_27;
		uint16_t L_29 = (uint16_t)(L_26)->GetAt(static_cast<il2cpp_array_size_t>(L_28));
		V_3 = L_29;
		Il2CppChar L_30 = V_3;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		Il2CppChar L_31 = ((Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_StaticFields*)il2cpp_codegen_static_fields_for(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var))->___DirectorySeparatorChar_2;
		if ((((int32_t)L_30) == ((int32_t)L_31)))
		{
			goto IL_007a;
		}
	}
	{
		Il2CppChar L_32 = V_3;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		Il2CppChar L_33 = ((Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_StaticFields*)il2cpp_codegen_static_fields_for(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var))->___AltDirectorySeparatorChar_1;
		if ((!(((uint32_t)L_32) == ((uint32_t)L_33))))
		{
			goto IL_0080;
		}
	}

IL_007a:
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_34 = ___3_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_35 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_34);
		int32_t L_36 = V_2;
		NullCheck(L_35);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(L_36), (Il2CppChar)((int32_t)47));
	}

IL_0080:
	{
		int32_t L_37 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_37, 1));
	}

IL_0084:
	{
		int32_t L_38 = V_2;
		int32_t L_39 = ___2_length;
		if ((((int32_t)L_38) < ((int32_t)L_39)))
		{
			goto IL_0065;
		}
	}
	{
		bool L_40 = ___4_appendPathSeparator;
		if (!L_40)
		{
			goto IL_0092;
		}
	}
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_41 = ___3_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_42 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_41);
		int32_t L_43 = ___2_length;
		NullCheck(L_42);
		(L_42)->SetAt(static_cast<il2cpp_array_size_t>(L_43), (Il2CppChar)((int32_t)47));
	}

IL_0092:
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_44 = ___3_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_45 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_44);
		int32_t L_46 = V_0;
		String_t* L_47;
		L_47 = String_CreateString_mB7B3AC2AF28010538650051A9000369B1CD6BAB6(NULL, L_45, 0, L_46, NULL);
		return L_47;
	}
}
// System.Void System.IO.Compression.ZipFile::EnsureCapacity(System.Char[]&,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ZipFile_EnsureCapacity_m61A3D212DC6CBACFE57140BF095A849607493604 (CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** ___0_buffer, int32_t ___1_min, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_0 = ___0_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_1 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_0);
		NullCheck(L_1);
		int32_t L_2 = ___1_min;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))) >= ((int32_t)L_2)))
		{
			goto IL_002e;
		}
	}
	{
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_3 = ___0_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_4 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_3);
		NullCheck(L_4);
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)(((RuntimeArray*)L_4)->max_length)), 2));
		int32_t L_5 = V_0;
		int32_t L_6 = ___1_min;
		if ((((int32_t)L_5) >= ((int32_t)L_6)))
		{
			goto IL_0014;
		}
	}
	{
		int32_t L_7 = ___1_min;
		V_0 = L_7;
	}

IL_0014:
	{
		il2cpp_codegen_runtime_class_init_inline(ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_il2cpp_TypeInfo_var);
		ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* L_8;
		L_8 = ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_inline(ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_9 = ___0_buffer;
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_10 = *((CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB**)L_9);
		NullCheck(L_8);
		VirtualActionInvoker2< CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*, bool >::Invoke(5 /* System.Void System.Buffers.ArrayPool`1<System.Char>::Return(T[],System.Boolean) */, L_8, L_10, (bool)0);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB** L_11 = ___0_buffer;
		ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* L_12;
		L_12 = ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_inline(ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_RuntimeMethod_var);
		int32_t L_13 = V_0;
		NullCheck(L_12);
		CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* L_14;
		L_14 = VirtualFuncInvoker1< CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB*, int32_t >::Invoke(4 /* T[] System.Buffers.ArrayPool`1<System.Char>::Rent(System.Int32) */, L_12, L_13);
		*((RuntimeObject**)L_11) = (RuntimeObject*)L_14;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_11, (void*)(RuntimeObject*)L_14);
	}

IL_002e:
	{
		return;
	}
}
// System.Boolean System.IO.Compression.ZipFile::IsDirEmpty(System.IO.DirectoryInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ZipFile_IsDirEmpty_m047A2732228B0C7A9CCEC311958381DCB264635C (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* ___0_possiblyEmptyDir, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	{
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_0 = ___0_possiblyEmptyDir;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_0);
		RuntimeObject* L_2;
		L_2 = Directory_EnumerateFileSystemEntries_mFC14748938E7979CA5472FB025BABE5448E9E216(L_1, NULL);
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.IEnumerable`1<System.String>::GetEnumerator() */, IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var, L_2);
		V_0 = L_3;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_001d:
			{// begin finally (depth: 1)
				{
					RuntimeObject* L_4 = V_0;
					if (!L_4)
					{
						goto IL_0026;
					}
				}
				{
					RuntimeObject* L_5 = V_0;
					NullCheck(L_5);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_5);
				}

IL_0026:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			RuntimeObject* L_6 = V_0;
			NullCheck(L_6);
			bool L_7;
			L_7 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_6);
			V_1 = (bool)((((int32_t)L_7) == ((int32_t)0))? 1 : 0);
			goto IL_0027;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0027:
	{
		bool L_8 = V_1;
		return L_8;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.IO.Compression.ZipArchiveEntry System.IO.Compression.ZipFileExtensions::DoCreateEntryFromFile(System.IO.Compression.ZipArchive,System.String,System.String,System.Nullable`1<System.IO.Compression.CompressionLevel>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26 (ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* ___0_destination, String_t* ___1_sourceFileName, String_t* ___2_entryName, Nullable_1_tAC8899D7718BEF36A8590184EFBCA842A1BC9AB1 ___3_compressionLevel, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mEBB6F9CB853B438D075BB555958691054B188001_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_mE771FFC5C0CA05BC9996418326C1D36E8A33DB2A_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* V_0 = NULL;
	ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* V_1 = NULL;
	DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D V_2;
	memset((&V_2), 0, sizeof(V_2));
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* V_3 = NULL;
	ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* V_4 = NULL;
	ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* G_B10_0 = NULL;
	{
		ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_0 = ___0_destination;
		if (L_0)
		{
			goto IL_000e;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_1 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_1);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_1, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralD89ADD2DB1FBF30630EEA02FAAF144060CA0E908)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26_RuntimeMethod_var)));
	}

IL_000e:
	{
		String_t* L_2 = ___1_sourceFileName;
		if (L_2)
		{
			goto IL_001c;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_3 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral56F96CA2C7CD86A940882DB30231478A10E0B61F)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26_RuntimeMethod_var)));
	}

IL_001c:
	{
		String_t* L_4 = ___2_entryName;
		if (L_4)
		{
			goto IL_002a;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_5 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_5);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEC39AAB8B28BCEDAFA6F3285CC603CE852769989)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ZipFileExtensions_DoCreateEntryFromFile_m0B0768102927FBBB004A43ECE057BE6680B91F26_RuntimeMethod_var)));
	}

IL_002a:
	{
		String_t* L_6 = ___1_sourceFileName;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_7 = (FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8*)il2cpp_codegen_object_new(FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_il2cpp_TypeInfo_var);
		NullCheck(L_7);
		FileStream__ctor_mB51E4FD96A6B396795C835EFD7B0F0018A3A5029(L_7, L_6, 3, 1, 1, ((int32_t)4096), (bool)0, NULL);
		V_0 = L_7;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00ba:
			{// begin finally (depth: 1)
				{
					Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_8 = V_0;
					if (!L_8)
					{
						goto IL_00c3;
					}
				}
				{
					Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_9 = V_0;
					NullCheck(L_9);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_9);
				}

IL_00c3:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				bool L_10;
				L_10 = Nullable_1_get_HasValue_mEBB6F9CB853B438D075BB555958691054B188001_inline((&___3_compressionLevel), Nullable_1_get_HasValue_mEBB6F9CB853B438D075BB555958691054B188001_RuntimeMethod_var);
				if (L_10)
				{
					goto IL_004c_1;
				}
			}
			{
				ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_11 = ___0_destination;
				String_t* L_12 = ___2_entryName;
				NullCheck(L_11);
				ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_13;
				L_13 = ZipArchive_CreateEntry_m52C487BC25504F8951CE8927F64778DC417CE88E(L_11, L_12, NULL);
				G_B10_0 = L_13;
				goto IL_005a_1;
			}

IL_004c_1:
			{
				ZipArchive_t6469B8DB5F18FB4C7E24F625D0E53EA635D31C41* L_14 = ___0_destination;
				String_t* L_15 = ___2_entryName;
				int32_t L_16;
				L_16 = Nullable_1_get_Value_mE771FFC5C0CA05BC9996418326C1D36E8A33DB2A((&___3_compressionLevel), Nullable_1_get_Value_mE771FFC5C0CA05BC9996418326C1D36E8A33DB2A_RuntimeMethod_var);
				NullCheck(L_14);
				ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_17;
				L_17 = ZipArchive_CreateEntry_m52B44886A7D190AA27F6CA6C56BF5BBA39AE16D3(L_14, L_15, L_16, NULL);
				G_B10_0 = L_17;
			}

IL_005a_1:
			{
				V_1 = G_B10_0;
				String_t* L_18 = ___1_sourceFileName;
				DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D L_19;
				L_19 = File_GetLastWriteTime_m5DD0EAF55C3F704DDB7AC9919504C6FCB6DD6621(L_18, NULL);
				V_2 = L_19;
				int32_t L_20;
				L_20 = DateTime_get_Year_m00A88C4CEE07B7906F5F7F75C254B769808F5138((&V_2), NULL);
				if ((((int32_t)L_20) < ((int32_t)((int32_t)1980))))
				{
					goto IL_007e_1;
				}
			}
			{
				int32_t L_21;
				L_21 = DateTime_get_Year_m00A88C4CEE07B7906F5F7F75C254B769808F5138((&V_2), NULL);
				if ((((int32_t)L_21) <= ((int32_t)((int32_t)2107))))
				{
					goto IL_008f_1;
				}
			}

IL_007e_1:
			{
				DateTime__ctor_m1F66A4327FE6B127F0F0E83A70CED25DB0DFFB00((&V_2), ((int32_t)1980), 1, 1, 0, 0, 0, NULL);
			}

IL_008f_1:
			{
				ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_22 = V_1;
				DateTime_t66193957C73913903DDAD89FEDC46139BCA5802D L_23 = V_2;
				il2cpp_codegen_runtime_class_init_inline(DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4_il2cpp_TypeInfo_var);
				DateTimeOffset_t4EE701FE2F386D6F932FAC9B11E4B74A5B30F0A4 L_24;
				L_24 = DateTimeOffset_op_Implicit_m7BFCB56BB3714FA7E58AA0ECEE92B8455A0CEDA5(L_23, NULL);
				NullCheck(L_22);
				ZipArchiveEntry_set_LastWriteTime_mB37B15E966275E236647AC8F23EC9D03B7C124A7(L_22, L_24, NULL);
				ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_25 = V_1;
				NullCheck(L_25);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_26;
				L_26 = ZipArchiveEntry_Open_m1D0EFB9AD33BA96AAF0C624EADA3E58CD6CC67FF(L_25, NULL);
				V_3 = L_26;
			}
			{
				auto __finallyBlock = il2cpp::utils::Finally([&]
				{

FINALLY_00ab_1:
					{// begin finally (depth: 2)
						{
							Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_27 = V_3;
							if (!L_27)
							{
								goto IL_00b4_1;
							}
						}
						{
							Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_28 = V_3;
							NullCheck(L_28);
							InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_28);
						}

IL_00b4_1:
						{
							return;
						}
					}// end finally (depth: 2)
				});
				try
				{// begin try (depth: 2)
					Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_29 = V_0;
					Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_30 = V_3;
					NullCheck(L_29);
					Stream_CopyTo_m61DC54FF3708C2B8AB5C5D63D300AA57ADA01999(L_29, L_30, NULL);
					goto IL_00b5_1;
				}// end try (depth: 2)
				catch(Il2CppExceptionWrapper& e)
				{
					__finallyBlock.StoreException(e.ex);
				}
			}

IL_00b5_1:
			{
				ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_31 = V_1;
				V_4 = L_31;
				goto IL_00c4;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00c4:
	{
		ZipArchiveEntry_tEFD75A0570102F8A3DF70A038302146B46071DD4* L_32 = V_4;
		return L_32;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____stringLength_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* ArrayPool_1_get_Shared_m8EB88B4EDF81135B55DB0F33A749B8087FE4646F_gshared_inline (const RuntimeMethod* method) 
{
	{
		il2cpp_codegen_runtime_class_init_inline(il2cpp_rgctx_data(InitializedTypeInfo(method->klass)->rgctx_data, 0));
		ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B* L_0 = ((ArrayPool_1_t3CE8332C9DFE03FF160AB0CE0FF17DF7792E0E4B_StaticFields*)il2cpp_codegen_static_fields_for(il2cpp_rgctx_data(InitializedTypeInfo(method->klass)->rgctx_data, 0)))->___U3CSharedU3Ek__BackingField_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mB1F55188CDD50D6D725D41F55D2F2540CD15FB20_gshared_inline (Nullable_1_t163D49A1147F217B7BD43BE8ACC8A5CC6B846D14* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = (bool)__this->___hasValue_0;
		return L_0;
	}
}
