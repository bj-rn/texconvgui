namespace TexConvGui
{
    public static class TexConvGuiEnums
    {

        public enum SupportedInputFileTypes
        {
            bmp,
            dds,
            exr,
            hdr,
            heic,
            heif,
            jpg,
            jpeg,
            png,
            tga,
            tiff,
            tif,
        }

        // https://github.com/microsoft/DirectXTex/blob/main/Texconv/texconv.cpp#L236
        public enum DXGI_FORMAT
        {
            R32G32B32A32_FLOAT,
            R32G32B32A32_UINT,
            R32G32B32A32_SINT,
            R32G32B32_FLOAT,
            R32G32B32_UINT,
            R32G32B32_SINT,
            R16G16B16A16_FLOAT,
            R16G16B16A16_UNORM,
            R16G16B16A16_UINT,
            R16G16B16A16_SNORM,
            R16G16B16A16_SINT,
            R32G32_FLOAT,
            R32G32_UINT,
            R32G32_SINT,
            R10G10B10A2_UNORM,
            R10G10B10A2_UINT,
            R11G11B10_FLOAT,
            R8G8B8A8_UNORM,
            R8G8B8A8_UNORM_SRGB,
            R8G8B8A8_UINT,
            R8G8B8A8_SNORM,
            R8G8B8A8_SINT,
            R16G16_FLOAT,
            R16G16_UNORM,
            R16G16_UINT,
            R16G16_SNORM,
            R16G16_SINT,
            R32_FLOAT,
            R32_UINT,
            R32_SINT,
            R8G8_UNORM,
            R8G8_UINT,
            R8G8_SNORM,
            R8G8_SINT,
            R16_FLOAT,
            R16_UNORM,
            R16_UINT,
            R16_SNORM,
            R16_SINT,
            R8_UNORM,
            R8_UINT,
            R8_SNORM,
            R8_SINT,
            A8_UNORM,
            R9G9B9E5_SHAREDEXP,
            R8G8_B8G8_UNORM,
            G8R8_G8B8_UNORM,
            BC1_UNORM,
            BC1_UNORM_SRGB,
            BC2_UNORM,
            BC2_UNORM_SRGB,
            BC3_UNORM,
            BC3_UNORM_SRGB,
            BC4_UNORM,
            BC4_SNORM,
            BC5_UNORM,
            BC5_SNORM,
            B5G6R5_UNORM,
            B5G5R5A1_UNORM,

            // DXGI 1.1 formats
            B8G8R8A8_UNORM,
            B8G8R8X8_UNORM,
            R10G10B10_XR_BIAS_A2_UNORM,
            B8G8R8A8_UNORM_SRGB,
            B8G8R8X8_UNORM_SRGB,
            BC6H_UF16,
            BC6H_SF16,
            BC7_UNORM,
            BC7_UNORM_SRGB,

            // DXGI 1.2 formats
            AYUV,
            Y410,
            Y416,
            YUY2,
            Y210,
            Y216,
            // No support for legacy paletted video formats (AI44, IA44, P8, A8P8)
            B4G4R4A4_UNORM,

            // D3D11on12 format
            A4B4G4R4_UNORM,

            // Special Formats
            BC3n, // FORMAT_DXT5_NM
            DXT5nm, // FORMAT_DXT5_NM
            RXGB, //FORMAT_DXT5_RXGB


            //DXGI_FORMAT_UNKNOWN
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
