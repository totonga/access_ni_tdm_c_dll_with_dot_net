// basics generated using nilibddc.h inside of pinvoke-interop-assistant and some cleanup
// this example will only work with 64bit process
// make sure "nilibddc.dll" can be found in the PATH or is beneath the executable

internal class nilibddc {
public enum DDCDataType {
    DDC_UInt8 = 5,
    DDC_Int16 = 2,
    DDC_Int32 = 3,
    DDC_Float = 9,
    DDC_Double = 10,
    DDC_String = 23,
    DDC_Timestamp = 30
}

public enum DDCError {
    DDC_NoError = 0,
    DDC_ErrorBegin = -6201,
    DDC_OutOfMemory = -6201,
    DDC_InvalidArgument = -6202,
    DDC_InvalidDataType = -6203,
    DDC_UnexpectedError = -6204,
    DDC_UsiCouldNotBeLoaded = -6205,
    DDC_InvalidFileHandle = -6206,
    DDC_InvalidChannelGroupHandle = -6207,
    DDC_InvalidChannelHandle = -6208,
    DDC_FileDoesNotExist = -6209,
    DDC_CannotWriteToReadOnlyFile = -6210,
    DDC_StorageCouldNotBeOpened = -6211,
    DDC_FileAlreadyExists = -6212,
    DDC_PropertyDoesNotExist = -6213,
    DDC_PropertyDoesNotContainData = -6214,
    DDC_PropertyIsNotAScalar = -6215,
    DDC_DataObjectTypeNotFound = -6216,
    DDC_NotImplemented = -6217,
    DDC_CouldNotSaveFile = -6218,
    DDC_MaximumNumberOfDataValuesExceeded = -6219,
    DDC_InvalidChannelName = -6220,
    DDC_DuplicateChannelName = -6221,
    DDC_DataTypeNotSupported = -6222,
    DDC_FileAccessDenied = -6224,
    DDC_InvalidTimeValue = -6225,
    DDC_ReplaceNotSupportedForSavedTDMSData = -6226,
    DDC_PropertyDataTypeMismatch = -6227,
    DDC_ChannelDataTypeMismatch = -6228,
    DDC_ErrorEnd = -6228,
    DDC_ErrorForceSizeTo32Bits = -1
}
    
    /// Return Type: int
    ///filePath: char*
    ///fileType: char*
    ///name: char*
    ///description: char*
    ///title: char*
    ///author: char*
    ///file: DDCFileHandle*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFile", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFile([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filePath, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fileType, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string description, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string title, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string author, ref System.IntPtr file) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///name: char*
    ///description: char*
    ///channelGroup: DDCChannelGroupHandle*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AddChannelGroup", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AddChannelGroup(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string description, ref System.IntPtr channelGroup) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///dataType: DDCDataType->Anonymous_0b877285_5a13_4093_be53_b3e8831936f9
    ///name: char*
    ///description: char*
    ///unitString: char*
    ///channel: DDCChannelHandle*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AddChannel", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AddChannel(System.IntPtr channelGroup, DDCDataType dataType, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string name, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string description, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string unitString, ref System.IntPtr channel) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SaveFile", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SaveFile(System.IntPtr file) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CloseFile", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CloseFile(System.IntPtr file) ;

    
    /// Return Type: int
    ///filePath: char*
    ///fileType: char*
    ///readOnly: int
    ///file: DDCFileHandle*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_OpenFileEx", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_OpenFileEx([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filePath, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string fileType, int readOnly, ref System.IntPtr file) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_RemoveChannelGroup", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_RemoveChannelGroup(System.IntPtr channelGroup) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_RemoveChannel", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_RemoveChannel(System.IntPtr channel) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CloseChannelGroup", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CloseChannelGroup(System.IntPtr channelGroup) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CloseChannel", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CloseChannel(System.IntPtr channel) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: void*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValues", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValues(System.IntPtr channel, System.IntPtr values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesTimestampComponents(System.IntPtr channel, uint[] year, uint[] month, uint[] day, uint[] hour, uint[] minute, uint[] second, double[] milliSecond, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: void*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValues", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValues(System.IntPtr channel, System.IntPtr values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesTimestampComponents(System.IntPtr channel, uint[] year, uint[] month, uint[] day, uint[] hour, uint[] minute, uint[] second, double[] milliSecond, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///numChannelGroups: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumChannelGroups", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumChannelGroups(System.IntPtr file, ref uint numChannelGroups) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///channelGroupsBuf: DDCChannelGroupHandle*
    ///numChannelGroups: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroups", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroups(System.IntPtr file, System.IntPtr[] channelGroupsBuf, System.UInt64 numChannelGroups) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///numChannels: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumChannels", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumChannels(System.IntPtr channelGroup, ref uint numChannels) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///channelsBuf: DDCChannelHandle*
    ///numChannels: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannels", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannels(System.IntPtr channelGroup, System.IntPtr[] channelsBuf, System.UInt64 numChannels) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///numValues: unsigned __int64*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumDataValues", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumDataValues(System.IntPtr channel, ref ulong numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValues", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValues(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, System.IntPtr values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///weekDay: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesTimestampComponents(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, uint[] year, uint[] month, uint[] day, uint[] hour, uint[] minute, uint[] second, double[] milliSecond, uint[] weekDay) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///dataType: DDCDataType*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataType", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataType(System.IntPtr channel, ref DDCDataType dataType) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyTimestampComponents(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyV", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyV(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr args) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: void*
    ///valueSizeInBytes: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFileProperty", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFileProperty(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSizeInBytes) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///weekDay: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyTimestampComponents(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint year, ref uint month, ref uint day, ref uint hour, ref uint minute, ref uint second, ref double milliSecond, ref uint weekDay) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///length: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFileStringPropertyLength", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFileStringPropertyLength(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint length) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyTimestampComponents(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///exists: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_FilePropertyExists", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_FilePropertyExists(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int exists) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///numProperties: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumFileProperties", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumFileProperties(System.IntPtr file, ref uint numProperties) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///propertyNames: char**
    ///numPropertyNames: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyNames", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyNames(System.IntPtr file, ref System.IntPtr propertyNames, System.UInt64 numPropertyNames) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///dataType: DDCDataType*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyType", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyType(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref DDCDataType dataType) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyTimestampComponents(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyV", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyV(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr args) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: void*
    ///valueSizeInBytes: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupProperty", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupProperty(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSizeInBytes) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///weekDay: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyTimestampComponents(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint year, ref uint month, ref uint day, ref uint hour, ref uint minute, ref uint second, ref double milliSecond, ref uint weekDay) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///length: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupStringPropertyLength", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupStringPropertyLength(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint length) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyTimestampComponents(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///exists: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_ChannelGroupPropertyExists", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_ChannelGroupPropertyExists(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int exists) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///numProperties: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumChannelGroupProperties", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumChannelGroupProperties(System.IntPtr channelGroup, ref uint numProperties) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///propertyNames: char**
    ///numPropertyNames: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyNames", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyNames(System.IntPtr channelGroup, ref System.IntPtr propertyNames, System.UInt64 numPropertyNames) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///dataType: DDCDataType*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyType", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyType(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref DDCDataType dataType) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyTimestampComponents(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: void*
    ///valueSizeInBytes: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelProperty", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelProperty(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSizeInBytes) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///year: unsigned int*
    ///month: unsigned int*
    ///day: unsigned int*
    ///hour: unsigned int*
    ///minute: unsigned int*
    ///second: unsigned int*
    ///milliSecond: double*
    ///weekDay: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyTimestampComponents(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint year, ref uint month, ref uint day, ref uint hour, ref uint minute, ref uint second, ref double milliSecond, ref uint weekDay) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///length: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelStringPropertyLength", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelStringPropertyLength(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref uint length) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///year: unsigned int
    ///month: unsigned int
    ///day: unsigned int
    ///hour: unsigned int
    ///minute: unsigned int
    ///second: unsigned int
    ///milliSecond: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyTimestampComponents", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyTimestampComponents(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, uint year, uint month, uint day, uint hour, uint minute, uint second, double milliSecond) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///dataType: DDCDataType->Anonymous_0b877285_5a13_4093_be53_b3e8831936f9
    ///args: va_list->char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyV", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyV(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, DDCDataType dataType, System.IntPtr args) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///exists: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_ChannelPropertyExists", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_ChannelPropertyExists(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int exists) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///numProperties: unsigned int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetNumChannelProperties", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetNumChannelProperties(System.IntPtr channel, ref uint numProperties) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///propertyNames: char**
    ///numPropertyNames: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyNames", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyNames(System.IntPtr channel, ref System.IntPtr propertyNames, System.UInt64 numPropertyNames) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///dataType: DDCDataType*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyType", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyType(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref DDCDataType dataType) ;

    
    /// Return Type: char*
    ///errorCode: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetLibraryErrorDescription", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  System.IntPtr DDC_GetLibraryErrorDescription(int errorCode) ;

    
    /// Return Type: void
    ///memoryPointer: void*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_FreeMemory", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  void DDC_FreeMemory(System.IntPtr memoryPointer) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: unsigned char*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesUInt8(System.IntPtr channel, System.Byte[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: short*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesInt16(System.IntPtr channel, short[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: int*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesInt32(System.IntPtr channel, System.Int32[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: float*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesFloat(System.IntPtr channel, float[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: double*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesDouble(System.IntPtr channel, double[] values, ulong numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: char**
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetDataValuesString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetDataValuesString(System.IntPtr channel, ref System.IntPtr values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: unsigned char*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesUInt8(System.IntPtr channel, System.Byte[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: short*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesInt16(System.IntPtr channel, short[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: int*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesInt32(System.IntPtr channel, int[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: float*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesFloat(System.IntPtr channel, float[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: double*
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesDouble(System.IntPtr channel, double[] values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///values: char**
    ///numValues: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_AppendDataValuesString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_AppendDataValuesString(System.IntPtr channel, ref System.IntPtr values, System.UInt64 numValues) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: unsigned char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesUInt8(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, System.Byte[] values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: short*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesInt16(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, short[] values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesInt32(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, System.Int32[] values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: float*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesFloat(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, float[] values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: double*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesDouble(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, double[] values) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///indexOfFirstValueToGet: size_t->System.UInt64
    ///numValuesToGet: size_t->System.UInt64
    ///values: char**
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetDataValuesString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetDataValuesString(System.IntPtr channel, System.UInt64 indexOfFirstValueToGet, System.UInt64 numValuesToGet, ref System.IntPtr values) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyUInt8(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyInt16(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyInt32(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyFloat(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyDouble(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateFilePropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateFilePropertyString(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyUInt8(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyInt16(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyInt32(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyFloat(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyDouble(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetFilePropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetFilePropertyString(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: unsigned char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyUInt8(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: short*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyInt16(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref short value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyInt32(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: float*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyFloat(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref float value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: double*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyDouble(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref double value) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///property: char*
    ///value: char*
    ///valueSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyString(System.IntPtr file, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSize) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyUInt8(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyInt16(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyInt32(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyFloat(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyDouble(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelGroupPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelGroupPropertyString(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyUInt8(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyInt16(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyInt32(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyFloat(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyDouble(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelGroupPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelGroupPropertyString(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: unsigned char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyUInt8(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: short*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyInt16(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref short value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyInt32(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: float*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyFloat(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref float value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: double*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyDouble(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref double value) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///property: char*
    ///value: char*
    ///valueSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyString(System.IntPtr channelGroup, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSize) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyUInt8(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyInt16(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyInt32(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyFloat(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyDouble(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_CreateChannelPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_CreateChannelPropertyString(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: unsigned char
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyUInt8(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, byte value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: short
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyInt16(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, short value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: int
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyInt32(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, int value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: float
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyFloat(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, float value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: double
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyDouble(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, double value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_SetChannelPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_SetChannelPropertyString(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: unsigned char*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyUInt8", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyUInt8(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: short*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyInt16", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyInt16(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref short value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: int*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyInt32", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyInt32(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref int value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: float*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyFloat", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyFloat(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref float value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: double*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyDouble", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyDouble(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, ref double value) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///property: char*
    ///value: char*
    ///valueSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyString", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyString(System.IntPtr channel, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string property, System.IntPtr value, System.UInt64 valueSize) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///index: size_t->System.UInt64
    ///propertyName: char*
    ///propertyNameSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyNameFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyNameFromIndex(System.IntPtr file, System.UInt64 index, System.IntPtr propertyName, System.UInt64 propertyNameSize) ;

    
    /// Return Type: int
    ///file: DDCFileHandle->void*
    ///index: size_t->System.UInt64
    ///propertyNameLength: size_t*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetFilePropertyNameLengthFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetFilePropertyNameLengthFromIndex(System.IntPtr file, System.UInt64 index, ref System.UInt64 propertyNameLength) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///index: size_t->System.UInt64
    ///propertyName: char*
    ///propertyNameSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyNameFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyNameFromIndex(System.IntPtr channelGroup, System.UInt64 index, System.IntPtr propertyName, System.UInt64 propertyNameSize) ;

    
    /// Return Type: int
    ///channelGroup: DDCChannelGroupHandle->void*
    ///index: size_t->System.UInt64
    ///propertyNameLength: size_t*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelGroupPropertyNameLengthFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelGroupPropertyNameLengthFromIndex(System.IntPtr channelGroup, System.UInt64 index, ref System.UInt64 propertyNameLength) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///index: size_t->System.UInt64
    ///propertyName: char*
    ///propertyNameSize: size_t->System.UInt64
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyNameFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyNameFromIndex(System.IntPtr channel, System.UInt64 index, System.IntPtr propertyName, System.UInt64 propertyNameSize) ;

    
    /// Return Type: int
    ///channel: DDCChannelHandle->void*
    ///index: size_t->System.UInt64
    ///propertyNameLength: size_t*
    [System.Runtime.InteropServices.DllImportAttribute(NILIBDDC_DLL_PATH, EntryPoint="DDC_GetChannelPropertyNameLengthFromIndex", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int DDC_GetChannelPropertyNameLengthFromIndex(System.IntPtr channel, System.UInt64 index, ref System.UInt64 propertyNameLength) ;

private const string NILIBDDC_DLL_PATH = "nilibddc.dll";
}
