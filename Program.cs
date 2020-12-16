using System;
using static nilibddc;

namespace access_ni_tdm_c_dll_with_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!System.Environment.Is64BitProcess)
            {
                throw new ApplicationException("Example only works with 64bit version of ddclib!");
            }

            string fileType = "TDMS";
            string tdmsFilepath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "example_filewritten_with_dot_net.tdms");
            if (System.IO.File.Exists(tdmsFilepath))
            {
                System.IO.File.Delete(tdmsFilepath);
            }

            System.Console.WriteLine($"Create file: {tdmsFilepath}");
            WriteFile(fileType, tdmsFilepath);
            System.Console.WriteLine($"Read file  : {tdmsFilepath}");
            ReadFile(fileType, tdmsFilepath);
        }

        private static void ReadFile(string fileType, string tdmsFilePath)
        {
            IntPtr file = new IntPtr();
            ddcChk(DDC_OpenFileEx(tdmsFilePath, fileType, 1, ref file));
            try
            {
                {
                    // read file properties
                    uint number_of_properties = 0;
                    ddcChk(DDC_GetNumFileProperties(file, ref number_of_properties));
                    for (ulong prop_index = 0; prop_index < number_of_properties; ++prop_index)
                    {
                        ulong prop_name_length = 0;
                        ddcChk(DDC_GetFilePropertyNameLengthFromIndex(file, prop_index, ref prop_name_length));
                        ++prop_name_length; // null termination
                        IntPtr prop_name_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_name_length);
                        ddcChk(DDC_GetFilePropertyNameFromIndex(file, prop_index, prop_name_buf, prop_name_length));
                        string prop_name = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_name_buf, (int)prop_name_length);

                        DDCDataType prop_data_type = DDCDataType.DDC_UInt8;
                        ddcChk(DDC_GetFilePropertyType(file, prop_name, ref prop_data_type));
                        switch (prop_data_type)
                        {
                            case DDCDataType.DDC_String:
                                {
                                    uint prop_value_string_length = 0;
                                    if (ddcChkProp(DDC_GetFileStringPropertyLength(file, prop_name, ref prop_value_string_length)))
                                    {
                                        ++prop_value_string_length; // null termination
                                        IntPtr prop_value_string_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_value_string_length);
                                        ddcChk(DDC_GetFilePropertyString(file, prop_name, prop_value_string_buf, prop_value_string_length));
                                        string prop_value_string = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_value_string_buf, (int)prop_value_string_length);
                                    }
                                }
                                break;
                            case DDCDataType.DDC_Double:
                                {
                                    double prop_value = 0.0;
                                    ddcChkProp(DDC_GetFilePropertyDouble(file, prop_name, ref prop_value));
                                }
                                break;
                        }
                    }
                }

                uint number_of_groups = 0;
                ddcChk(DDC_GetNumChannelGroups(file, ref number_of_groups));
                for (uint group_index = 0; group_index < number_of_groups; ++group_index) ;

                IntPtr[] groups = new IntPtr[number_of_groups];
                ddcChk(DDC_GetChannelGroups(file, groups, number_of_groups));

                foreach (var group in groups)
                {
                    {
                        // read group properties
                        uint number_of_properties = 0;
                        ddcChk(DDC_GetNumChannelGroupProperties(group, ref number_of_properties));
                        for (ulong prop_index = 0; prop_index < number_of_properties; ++prop_index)
                        {
                            ulong prop_name_length = 0;
                            ddcChk(DDC_GetChannelGroupPropertyNameLengthFromIndex(group, prop_index, ref prop_name_length));
                            ++prop_name_length; // null termination
                            IntPtr prop_name_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_name_length);
                            ddcChk(DDC_GetChannelGroupPropertyNameFromIndex(group, prop_index, prop_name_buf, prop_name_length));
                            string prop_name = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_name_buf, (int)prop_name_length);

                            DDCDataType prop_data_type = DDCDataType.DDC_UInt8;
                            ddcChk(DDC_GetChannelGroupPropertyType(group, prop_name, ref prop_data_type));
                            switch (prop_data_type)
                            {
                                case DDCDataType.DDC_String:
                                    {
                                        uint prop_value_string_length = 0;
                                        if(ddcChkProp(DDC_GetChannelGroupStringPropertyLength(group, prop_name, ref prop_value_string_length)))
                                        {
                                            ++prop_value_string_length; // null termination
                                            IntPtr prop_value_string_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_value_string_length);
                                            ddcChk(DDC_GetChannelGroupPropertyString(group, prop_name, prop_value_string_buf, prop_value_string_length));
                                            string prop_value_string = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_value_string_buf, (int)prop_value_string_length);
                                        }
                                    }
                                    break;
                                case DDCDataType.DDC_Double:
                                    {
                                        double prop_value = 0.0;
                                        ddcChkProp(DDC_GetChannelGroupPropertyDouble(group, prop_name, ref prop_value));
                                    }
                                    break;
                            }
                        }
                    }

                    uint number_of_channels = 0;
                    ddcChk(DDC_GetNumChannels(group, ref number_of_channels));

                    IntPtr[] channels = new IntPtr[number_of_channels];
                    ddcChk(DDC_GetChannels(group, channels, number_of_channels));

                    foreach( var channel in channels)
                    {
                        {
                            // read channel properties
                            uint number_of_properties = 0;
                            ddcChk(DDC_GetNumChannelProperties(channel, ref number_of_properties));
                            for (ulong prop_index = 0; prop_index < number_of_properties; ++prop_index)
                            {
                                ulong prop_name_length = 0;
                                ddcChk(DDC_GetChannelPropertyNameLengthFromIndex(channel, prop_index, ref prop_name_length));
                                ++prop_name_length; // null termination
                                IntPtr prop_name_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_name_length);
                                ddcChk(DDC_GetChannelPropertyNameFromIndex(channel, prop_index, prop_name_buf, prop_name_length));
                                string prop_name = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_name_buf, (int)prop_name_length);

                                DDCDataType prop_data_type = DDCDataType.DDC_UInt8;
                                ddcChk(DDC_GetChannelPropertyType(channel, prop_name, ref prop_data_type));
                                switch (prop_data_type)
                                {
                                    case DDCDataType.DDC_String:
                                        {
                                            uint prop_value_string_length = 0;
                                            if(ddcChkProp(DDC_GetChannelStringPropertyLength(channel, prop_name, ref prop_value_string_length)))
                                            {
                                                ++prop_value_string_length; // null termination
                                                IntPtr prop_value_string_buf = System.Runtime.InteropServices.Marshal.AllocHGlobal((int)prop_value_string_length);
                                                ddcChk(DDC_GetChannelPropertyString(channel, prop_name, prop_value_string_buf, prop_value_string_length));
                                                string prop_value_string = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(prop_value_string_buf, (int)prop_value_string_length);
                                            }
                                        }
                                        break;
                                    case DDCDataType.DDC_Double:
                                        {
                                            double prop_value = 0.0;
                                            ddcChkProp(DDC_GetChannelPropertyDouble(channel, prop_name, ref prop_value));
                                        }
                                        break;
                                }
                            }
                        }

                        DDCDataType channelType = DDCDataType.DDC_UInt8;
                        ddcChk(DDC_GetDataType(channel, ref channelType));

                        ulong number_of_values = 0;
                        ddcChk(DDC_GetNumDataValues(channel, ref number_of_values));

                        switch (channelType)
                        {
                            case DDCDataType.DDC_Double:
                                {
                                    double[] values = new double[3];
                                    ddcChk(DDC_GetDataValuesDouble(channel, 0, (ulong)values.Length, values));
                                }
                                break;
                            case DDCDataType.DDC_Int32:
                                {
                                    int[] values = new int[3];
                                    ddcChk(DDC_GetDataValuesInt32(channel, 0, (ulong)values.Length, values));
                                }
                                break;
                        }
                    }
                }

            }
            finally
            {
                ddcChk(DDC_CloseFile(file));
            }
        }

        private static void WriteFile(string fileType, string tdmsFilePath)
        {
            IntPtr file = new IntPtr();
            ddcChk(DDC_CreateFile(tdmsFilePath, fileType, "", "my_desc", "measured file", "me", ref file));
            try
            {
                IntPtr group1 = new IntPtr();
                ddcChk(DDC_AddChannelGroup(file, "my_first_group", "my_desc", ref group1));
                ddcChk(DDC_CreateChannelGroupPropertyDouble(group1, "my_r64_prop", 1.234));
                ddcChk(DDC_CreateChannelGroupPropertyString(group1, "my_string_prop", "my_string_val"));

                IntPtr channel1_1 = new IntPtr();
                ddcChk(DDC_AddChannel(group1, DDCDataType.DDC_Double, "channel1", "my_channel_desc", "m", ref channel1_1));
                IntPtr channel1_2 = new IntPtr();
                ddcChk(DDC_AddChannel(group1, DDCDataType.DDC_Double, "channel2", "my_channel_desc", "kg", ref channel1_2));

                double[] channel1_1Data = new double[] { 1.1, 2.1, 3.1 };
                double[] channel1_2Data = new double[] { 1.2, 2.2, 3.2 };

                ddcChk(DDC_SetDataValuesDouble(channel1_1, channel1_1Data, (System.UInt64)channel1_1Data.Length));
                ddcChk(DDC_SetDataValuesDouble(channel1_2, channel1_2Data, (System.UInt64)channel1_2Data.Length));

                ddcChk(DDC_AppendDataValuesDouble(channel1_1, channel1_1Data, (System.UInt64)channel1_1Data.Length));
                ddcChk(DDC_AppendDataValuesDouble(channel1_2, channel1_2Data, (System.UInt64)channel1_2Data.Length));

                IntPtr group2 = new IntPtr();
                ddcChk(DDC_AddChannelGroup(file, "my_second_group", "my_desc", ref group2));

                IntPtr channel2_1 = new IntPtr();
                ddcChk(DDC_AddChannel(group2, DDCDataType.DDC_Int32, "channel1", "my_channel_desc", "m", ref channel2_1));

                int[] channel2_1Data = new int[] { 1, 2, 3 };
                ddcChk(DDC_SetDataValuesInt32(channel2_1, channel2_1Data, (System.UInt64)channel2_1Data.Length));

                ddcChk(DDC_SaveFile(file));
            }
            finally
            {
                ddcChk(DDC_CloseFile(file));
            }
        }

        private static void ddcChk(int status)
        {
            if((int)DDCError.DDC_NoError != status)
            {
                IntPtr error_buffer = DDC_GetLibraryErrorDescription(status);
                string error_string = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(error_buffer);
                throw new ApplicationException($"DDCError({status}):{error_string}");
            }
        }
        private static bool ddcChkProp(int status)
        {
            if((int)DDCError.DDC_PropertyDoesNotContainData == status)
            {
                return false;
            }

            ddcChk(status);

            return true;
        }
    }
}