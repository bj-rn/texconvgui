namespace TexConvGui
{
    public static class Tooltips
    {
        //https://github.com/Microsoft/DirectXTex/wiki/Texconv

        public const string Source = "Input directory";
        public const string Destination = "[-o] Output directory";
        public const string Recursive = "[-r]  If this switch is used, subdirectories are also searched.\nDefault is -r:flatten: The resulting output directory just includes the files";
        public const string KeepDirStruct = "[-r:keep ] If this switch is used, the output directory includes the subdirectory structure of the source tree.";

        public const string Width = "[-w] Width of the output texture in pixels.\n 0 = use original Size.";
        public const string Height = "[-h] Height of the output texture in pixels.\n 0 = use original Size.";
        public const string ImageFilter = "[-if] The image filter used for resizing.\n Filters with DITHER in their name indicate that the 4x4 ordered dither algorithm, while DITHER_DIFFUSION is error diffusion dithering.";
        public const string AddressingMode = "[-wrap | -mirror] Sets the texture addressing mode for filtering, otherwise defaults to clamp.";

        public const string Pow2 = "[-pow2] Fits each texture to a power-of-2 for width and height, minimizing changes to the aspect ratio.";
        public const string StraightAlpha = "[-alpha] Converts a premultiplied alpha image to non-premultiplied alpha (a.k.a. straight alpha).";
        public const string PremultipliedAlpha = "[-pmalpha] If checked the final texture data is converted to use premultiplied alpha.\n This sets an alpha mode of DDS_ALPHA_MODE_PREMULTIPLIED unless the entire alpha channel is fully opaque.";

        public const string BCDither = "[-bc d] Uses dithering (BC1-BC3).";
        public const string BCUniformWeight = "[-bc u] Uses uniform weighting rather than perceptual (BC1-BC3).";
        public const string BCMinCompress= "[-bc q] Uses minimum compression (BC7).";
        public const string BCMaxCompress = "[-bc x] Uses maximum compression (BC7).";

        public const string OutputFormat = "[-f] Specifies the DXGI format.";
        public const string MipMapLevel = "[-m] Number of mipmap levels to generate in the output texture.\n A setting of 0 will generate all mipmaps. Use 1 to remove mipmaps.";
    }
}


