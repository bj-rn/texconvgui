﻿namespace TexConvGui
{
    public static class TexConvGuiEnums
    {

        public enum SupportedInputFileTypes
        {
            bmp,
            dds,
            exr,
            hdr,
            jpg,
            jpeg,
            png,
            tga,
            tiff,
            tif,
        }

        public enum DXGI_FORMAT
        {
            FORCE_UINT = -1, // 0xFFFFFFFF
            UNKNOWN = 0,
            R32G32B32A32_TYPELESS = 1,
            R32G32B32A32_FLOAT = 2,
            R32G32B32A32_UINT = 3,
            R32G32B32A32_SINT = 4,
            R32G32B32_TYPELESS = 5,
            R32G32B32_FLOAT = 6,
            R32G32B32_UINT = 7,
            R32G32B32_SINT = 8,
            R16G16B16A16_TYPELESS = 9,
            R16G16B16A16_FLOAT = 10, // 0x0000000A
            R16G16B16A16_UNORM = 11, // 0x0000000B
            R16G16B16A16_UINT = 12, // 0x0000000C
            R16G16B16A16_SNORM = 13, // 0x0000000D
            R16G16B16A16_SINT = 14, // 0x0000000E
            R32G32_TYPELESS = 15, // 0x0000000F
            R32G32_FLOAT = 16, // 0x00000010
            R32G32_UINT = 17, // 0x00000011
            R32G32_SINT = 18, // 0x00000012
            R32G8X24_TYPELESS = 19, // 0x00000013
            D32_FLOAT_S8X24_UINT = 20, // 0x00000014
            R32_FLOAT_X8X24_TYPELESS = 21, // 0x00000015
            X32_TYPELESS_G8X24_UINT = 22, // 0x00000016
            R10G10B10A2_TYPELESS = 23, // 0x00000017
            R10G10B10A2_UNORM = 24, // 0x00000018
            R10G10B10A2_UINT = 25, // 0x00000019
            R11G11B10_FLOAT = 26, // 0x0000001A
            R8G8B8A8_TYPELESS = 27, // 0x0000001B
            R8G8B8A8_UNORM = 28, // 0x0000001C
            R8G8B8A8_UNORM_SRGB = 29, // 0x0000001D
            R8G8B8A8_UINT = 30, // 0x0000001E
            R8G8B8A8_SNORM = 31, // 0x0000001F
            R8G8B8A8_SINT = 32, // 0x00000020
            R16G16_TYPELESS = 33, // 0x00000021
            R16G16_FLOAT = 34, // 0x00000022
            R16G16_UNORM = 35, // 0x00000023
            R16G16_UINT = 36, // 0x00000024
            R16G16_SNORM = 37, // 0x00000025
            R16G16_SINT = 38, // 0x00000026
            R32_TYPELESS = 39, // 0x00000027
            D32_FLOAT = 40, // 0x00000028
            R32_FLOAT = 41, // 0x00000029
            R32_UINT = 42, // 0x0000002A
            R32_SINT = 43, // 0x0000002B
            R24G8_TYPELESS = 44, // 0x0000002C
            D24_UNORM_S8_UINT = 45, // 0x0000002D
            R24_UNORM_X8_TYPELESS = 46, // 0x0000002E
            X24_TYPELESS_G8_UINT = 47, // 0x0000002F
            R8G8_TYPELESS = 48, // 0x00000030
            R8G8_UNORM = 49, // 0x00000031
            R8G8_UINT = 50, // 0x00000032
            R8G8_SNORM = 51, // 0x00000033
            R8G8_SINT = 52, // 0x00000034
            R16_TYPELESS = 53, // 0x00000035
            R16_FLOAT = 54, // 0x00000036
            D16_UNORM = 55, // 0x00000037
            R16_UNORM = 56, // 0x00000038
            R16_UINT = 57, // 0x00000039
            R16_SNORM = 58, // 0x0000003A
            R16_SINT = 59, // 0x0000003B
            R8_TYPELESS = 60, // 0x0000003C
            R8_UNORM = 61, // 0x0000003D
            R8_UINT = 62, // 0x0000003E
            R8_SNORM = 63, // 0x0000003F
            R8_SINT = 64, // 0x00000040
            A8_UNORM = 65, // 0x00000041
            R1_UNORM = 66, // 0x00000042
            R9G9B9E5_SHAREDEXP = 67, // 0x00000043
            R8G8_B8G8_UNORM = 68, // 0x00000044
            G8R8_G8B8_UNORM = 69, // 0x00000045
            BC1_TYPELESS = 70, // 0x00000046
            BC1_UNORM = 71, // 0x00000047
            BC1_UNORM_SRGB = 72, // 0x00000048
            BC2_TYPELESS = 73, // 0x00000049
            BC2_UNORM = 74, // 0x0000004A
            BC2_UNORM_SRGB = 75, // 0x0000004B
            BC3_TYPELESS = 76, // 0x0000004C
            BC3_UNORM = 77, // 0x0000004D
            BC3_UNORM_SRGB = 78, // 0x0000004E
            BC4_TYPELESS = 79, // 0x0000004F
            BC4_UNORM = 80, // 0x00000050
            BC4_SNORM = 81, // 0x00000051
            BC5_TYPELESS = 82, // 0x00000052
            BC5_UNORM = 83, // 0x00000053
            BC5_SNORM = 84, // 0x00000054
            B5G6R5_UNORM = 85, // 0x00000055
            B5G5R5A1_UNORM = 86, // 0x00000056
            B8G8R8A8_UNORM = 87, // 0x00000057
            B8G8R8X8_UNORM = 88, // 0x00000058
            R10G10B10_XR_BIAS_A2_UNORM = 89, // 0x00000059
            B8G8R8A8_TYPELESS = 90, // 0x0000005A
            B8G8R8A8_UNORM_SRGB = 91, // 0x0000005B
            B8G8R8X8_TYPELESS = 92, // 0x0000005C
            B8G8R8X8_UNORM_SRGB = 93, // 0x0000005D
            BC6H_TYPELESS = 94, // 0x0000005E
            BC6H_UF16 = 95, // 0x0000005F
            BC6H_SF16 = 96, // 0x00000060
            BC7_TYPELESS = 97, // 0x00000061
            BC7_UNORM = 98, // 0x00000062
            BC7_UNORM_SRGB = 99, // 0x00000063
            AYUV = 100, // 0x00000064
            Y410 = 101, // 0x00000065
            Y416 = 102, // 0x00000066
            NV12 = 103, // 0x00000067
            P010 = 104, // 0x00000068
            P016 = 105, // 0x00000069
            YUY2 = 107, // 0x0000006B
            Y210 = 108, // 0x0000006C
            Y216 = 109, // 0x0000006D
            NV11 = 110, // 0x0000006E
            AI44 = 111, // 0x0000006F
            IA44 = 112, // 0x00000070
            P8 = 113, // 0x00000071
            A8P8 = 114, // 0x00000072
            B4G4R4A4_UNORM = 115, // 0x00000073
            P208 = 130, // 0x00000082
            V208 = 131, // 0x00000083
            V408 = 132, // 0x00000084
        }

        public enum ImageFilter
        {
            POINT,
            LINEAR,
            CUBIC,
            FANT,
            BOX,
            TRIANGLE,
            POINT_DITHER,
            LINEAR_DITHER,
            CUBIC_DITHER,
            FANT_DITHER,
            BOX_DITHER,
            TRIANGLE_DITHER,
            POINT_DITHER_DIFFUSION,
            LINEAR_DITHER_DIFFUSION,
            CUBIC_DITHER_DIFFUSION,
            FANT_DITHER_DIFFUSION,
            BOX_DITHER_DIFFUSION,
            TRIANGLE_DITHER_DIFFUSION,
        }

        public enum TextureAddressingMode
        {
            clamp,
            wrap,
            mirror,
        }

        public static string SupportedInputFileTypesEnum(TexConvGuiEnums.SupportedInputFileTypes e) => e.ToString();

        public static string DXGI_FORMATEnum(TexConvGuiEnums.DXGI_FORMAT e) => e.ToString();

        public static string ImageFilterEnum(TexConvGuiEnums.ImageFilter e) => e.ToString();

        public static string TextureAdressingModeEnum(TexConvGuiEnums.TextureAddressingMode e) => e.ToString();
    }
}
