# TexconvGui

Simple GUI for [MS Texconv](https://github.com/Microsoft/DirectXTex/wiki/Texconv).

Build with vvvv, the visual live-programming environment for .NET  
Download: http://visualprogramming.net


It's based on a preview version of vvvv that introduces .net6 (v 2022.5.0-0101) 
and makes use of the bleeding edge [VL.ImGui](https://github.com/vvvv/VL.ImGui) library.

So while fully working now, it should be considered highly experimental, any update to VL.ImGui  will likely break stuff.
Latest known working commit is [6d399d62af2d1c74e1f49b6db75f5e9e937b8cf8](https://github.com/vvvv/VL.ImGui/commit/6d399d62af2d1c74e1f49b6db75f5e9e937b8cf8).

Unfortunately exporting seems to be broken in the used vvvv version, so no compiled binary can be provided.
To get the patch to run, follow the installation instructions of VL.ImGui first.
