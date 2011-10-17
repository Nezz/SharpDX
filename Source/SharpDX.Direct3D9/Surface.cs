// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.IO;

using SharpDX.Direct3D;

namespace SharpDX.Direct3D9
{
    public partial class Surface
    {

        /// <summary>
        /// Creates a depth-stencil surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="discard">if set to <c>true</c> [discard].</param>
        /// <returns>A reference to a <see cref="Surface"/>, representing the created depth-stencil surface resource. </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateDepthStencilSurface([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Discard,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateDepthStencil(Device device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool discard)
        {
            return device.CreateDepthStencilSurface(width, height, format, multisampleType, multisampleQuality, discard, IntPtr.Zero);
        }

        /// <summary>
        /// Creates a depth-stencil surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="discard">if set to <c>true</c> [discard].</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>A reference to a <see cref="Surface"/>, representing the created depth-stencil surface resource. </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateDepthStencilSurface([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Discard,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateDepthStencil(Device device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool discard, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateDepthStencilSurface(width, height, format, multisampleType, multisampleQuality, discard, (IntPtr)pSharedHandle);
            }           
        }

        /// <summary>
        /// Creates a depth-stencil surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="discard">if set to <c>true</c> [discard].</param>
        /// <param name="usage">The usage.</param>
        /// <returns>A reference to a <see cref="Surface"/>, representing the created depth-stencil surface resource. </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateDepthStencilSurfaceEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Discard,[Out, Fast] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateDepthStencilEx(DeviceEx device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool discard, Usage usage)
        {
            return device.CreateDepthStencilSurfaceEx(width, height, format, multisampleType, multisampleQuality, discard, IntPtr.Zero, (int)usage);
        }

        /// <summary>
        /// Creates a depth-stencil surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="discard">if set to <c>true</c> [discard].</param>
        /// <param name="usage">The usage.</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>A reference to a <see cref="Surface"/>, representing the created depth-stencil surface resource. </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateDepthStencilSurfaceEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Discard,[Out, Fast] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateDepthStencilEx(DeviceEx device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool discard, Usage usage, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateDepthStencilSurfaceEx(width, height, format, multisampleType, multisampleQuality, discard, (IntPtr)pSharedHandle, (int)usage);
            }
        }

        /// <summary>
        /// Create an off-screen surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="pool">The pool.</param>
        /// <returns>A <see cref="Surface"/> created.</returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateOffscreenPlainSurface([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DPOOL Pool,[Out, Fast] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateOffscreenPlain(Device device, int width, int height, Format format, Pool pool)
        {
            return device.CreateOffscreenPlainSurface(width, height, format, pool, IntPtr.Zero);
        }

        /// <summary>
        /// Create an off-screen surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="pool">The pool.</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>A <see cref="Surface"/> created.</returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateOffscreenPlainSurface([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DPOOL Pool,[Out, Fast] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateOffscreenPlain(Device device, int width, int height, Format format, Pool pool, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateOffscreenPlainSurface(width, height, format, pool, (IntPtr)pSharedHandle);
            }
        }

        /// <summary>
        /// Create an off-screen surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="pool">The pool.</param>
        /// <param name="usage">The usage.</param>
        /// <returns>
        /// A <see cref="Surface"/> created.
        /// </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateOffscreenPlainSurfaceEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DPOOL Pool,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateOffscreenPlainEx(DeviceEx device, int width, int height, Format format, Pool pool, Usage usage)
        {
            return device.CreateOffscreenPlainSurfaceEx(width, height, format, pool, IntPtr.Zero, (int)usage);
        }

        /// <summary>
        /// Create an off-screen surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="pool">The pool.</param>
        /// <param name="usage">The usage.</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>
        /// A <see cref="Surface"/> created.
        /// </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateOffscreenPlainSurfaceEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DPOOL Pool,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateOffscreenPlainEx(DeviceEx device, int width, int height, Format format, Pool pool, Usage usage, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateOffscreenPlainSurfaceEx(width, height, format, pool, (IntPtr)pSharedHandle, (int)usage);
            }          
        }

        /// <summary>
        /// Creates a render-target surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="lockable">if set to <c>true</c> [lockable].</param>
        /// <returns>
        /// A render-target <see cref="Surface"/>.
        /// </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateRenderTarget([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Lockable,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateRenderTarget(Device device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool lockable)
        {
            return device.CreateRenderTarget(width, height, format, multisampleType, multisampleQuality, lockable, IntPtr.Zero);
        }

        /// <summary>
        /// Creates a render-target surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="lockable">if set to <c>true</c> [lockable].</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>
        /// A render-target <see cref="Surface"/>.
        /// </returns>
        /// <unmanaged>HRESULT IDirect3DDevice9::CreateRenderTarget([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Lockable,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle)</unmanaged>
        public static Surface CreateRenderTarget(Device device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool lockable, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateRenderTarget(width, height, format, multisampleType, multisampleQuality, lockable, (IntPtr)pSharedHandle);
            }                      
        }

        /// <summary>
        /// Creates a render-target surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="lockable">if set to <c>true</c> [lockable].</param>
        /// <param name="usage">The usage.</param>
        /// <returns>A render-target <see cref="Surface"/>.</returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateRenderTargetEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Lockable,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateRenderTargetEx(DeviceEx device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool lockable, Usage usage)
        {
            return device.CreateRenderTargetEx(width, height, format, multisampleType, multisampleQuality, lockable, IntPtr.Zero, (int)usage);
        }

        /// <summary>
        /// Creates a render-target surface.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="format">The format.</param>
        /// <param name="multisampleType">Type of the multisample.</param>
        /// <param name="multisampleQuality">The multisample quality.</param>
        /// <param name="lockable">if set to <c>true</c> [lockable].</param>
        /// <param name="usage">The usage.</param>
        /// <param name="sharedHandle">The shared handle.</param>
        /// <returns>A render-target <see cref="Surface"/>.</returns>
        /// <unmanaged>HRESULT IDirect3DDevice9Ex::CreateRenderTargetEx([In] unsigned int Width,[In] unsigned int Height,[In] D3DFORMAT Format,[In] D3DMULTISAMPLE_TYPE MultiSample,[In] unsigned int MultisampleQuality,[In] BOOL Lockable,[Out] IDirect3DSurface9** ppSurface,[In] void** pSharedHandle,[In] unsigned int Usage)</unmanaged>
        public static Surface CreateRenderTargetEx(DeviceEx device, int width, int height, Format format, MultisampleType multisampleType, int multisampleQuality, bool lockable, Usage usage, out IntPtr sharedHandle)
        {
            unsafe
            {
                fixed (void* pSharedHandle = &sharedHandle)
                    return device.CreateRenderTargetEx(width, height, format, multisampleType, multisampleQuality, lockable, (IntPtr)pSharedHandle, (int)usage);
            }
        }

        /// <summary>
        /// Loads a surface from a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileW([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const wchar_t* pSrcFile,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFile(Surface surface, string fileName, Filter filter, int colorKey)
        {
            return D3DX9.LoadSurfaceFromFileW(surface, null, IntPtr.Zero, fileName, IntPtr.Zero, filter, colorKey, IntPtr.Zero);
        }

        /// <summary>
        /// Loads a surface from a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileW([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const wchar_t* pSrcFile,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFile(Surface surface, string fileName, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            unsafe
            {
                return D3DX9.LoadSurfaceFromFileW(surface, null, new IntPtr(&destinationRectangle), fileName, new IntPtr(&sourceRectangle), filter, colorKey, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Loads a surface from a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileW([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const wchar_t* pSrcFile,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFile(Surface surface, string fileName, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, out ImageInformation imageInformation)
        {
            return FromFile(surface, fileName, filter, colorKey, sourceRectangle, destinationRectangle, null, out imageInformation);
        }

        /// <summary>
        /// Loads a surface from a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileW([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const wchar_t* pSrcFile,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFile(Surface surface, string fileName, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] palette, out ImageInformation imageInformation)
        {
            unsafe
            {
                fixed (void* pImageInformation = &imageInformation)
                    return D3DX9.LoadSurfaceFromFileW(surface, palette, new IntPtr(&destinationRectangle), fileName, new IntPtr(&sourceRectangle), filter, colorKey, (IntPtr)pImageInformation);
            }
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="memory">The memory.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInMemory(Surface surface, byte[] memory, Filter filter, int colorKey)
        {
            unsafe
            {
                fixed (void* pMemory = memory)
                    return D3DX9.LoadSurfaceFromFileInMemory(surface, null, IntPtr.Zero, (IntPtr)pMemory, memory.Length, IntPtr.Zero, filter, colorKey, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="memory">The memory.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInMemory(Surface surface, byte[] memory, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            unsafe
            {
                fixed (void* pMemory = memory)
                    return D3DX9.LoadSurfaceFromFileInMemory(surface, null, new IntPtr(&destinationRectangle), (IntPtr)pMemory, memory.Length, new IntPtr(&sourceRectangle), filter, colorKey, IntPtr.Zero);
            }
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="memory">The memory.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInMemory(Surface surface, byte[] memory, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, out ImageInformation imageInformation)
        {
            return FromFileInMemory(surface, memory, filter, colorKey, sourceRectangle, destinationRectangle, null, out imageInformation);
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="memory">The memory.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInMemory(Surface surface, byte[] memory, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] palette, out ImageInformation imageInformation)
        {
            unsafe
            {
                fixed (void* pMemory = memory)
                    fixed (void* pImageInformation = &imageInformation)
                        return D3DX9.LoadSurfaceFromFileInMemory(surface, palette, new IntPtr(&destinationRectangle), (IntPtr)pMemory, memory.Length, new IntPtr(&sourceRectangle), filter, colorKey, (IntPtr)pImageInformation);
            }
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInStream(Surface surface, Stream stream, Filter filter, int colorKey)
        {
            unsafe
            {
                if (stream is DataStream)
                {
                    return D3DX9.LoadSurfaceFromFileInMemory(
                        surface,
                        null,
                        IntPtr.Zero,
                        ((DataStream)stream).DataPointer,
                        (int)stream.Length,
                        IntPtr.Zero,
                        filter,
                        colorKey,
                        IntPtr.Zero);
                }

                var data = Utilities.ReadStream(stream);
                fixed (void* pData = data)
                    return D3DX9.LoadSurfaceFromFileInMemory(
                        surface,
                        null,
                        IntPtr.Zero,
                        (IntPtr)pData,
                        data.Length,
                        IntPtr.Zero,
                        filter,
                        colorKey,
                        IntPtr.Zero);
            }
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInStream(Surface surface, Stream stream, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            return CreateFromFileInStream(surface, stream, filter, colorKey, sourceRectangle, destinationRectangle, null, IntPtr.Zero);
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static Result FromFileInStream(Surface surface, Stream stream, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, out ImageInformation imageInformation)
        {
            return FromFileInStream(surface, stream, filter, colorKey, sourceRectangle, destinationRectangle, null, out imageInformation);
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        public static unsafe Result FromFileInStream(Surface surface, Stream stream, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] palette, out ImageInformation imageInformation)
        {
            fixed (void* pImageInformation = &imageInformation)
                return CreateFromFileInStream(surface, stream, filter, colorKey, sourceRectangle, destinationRectangle, palette, (IntPtr)pImageInformation);
        }

        /// <summary>
        /// Loads a surface from a file in memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <param name="imageInformation">The image information.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromFileInMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcData,[In] unsigned int SrcDataSize,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey,[In] void* pSrcInfo)</unmanaged>
        private static unsafe Result CreateFromFileInStream(Surface surface, Stream stream, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] palette, IntPtr imageInformation)
        {
            if (stream is DataStream)
            {
                return D3DX9.LoadSurfaceFromFileInMemory(
                    surface,
                    palette,
                    new IntPtr(&destinationRectangle),
                    ((DataStream)stream).DataPointer,
                    (int)stream.Length,
                    new IntPtr(&sourceRectangle),
                    filter,
                    colorKey,
                    imageInformation);
            }

            var data = Utilities.ReadStream(stream);
            fixed (void* pData = data)
                return D3DX9.LoadSurfaceFromFileInMemory(
                    surface,
                    palette,
                    new IntPtr(&destinationRectangle),
                    (IntPtr)pData,
                    data.Length,
                    new IntPtr(&sourceRectangle),
                    filter,
                    colorKey,
                    imageInformation);
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromMemory(Surface surface, byte[] data, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle)
        {
            return FromMemory(surface, data, filter, colorKey, sourceFormat, sourcePitch, sourceRectangle, null, null);
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromMemory(Surface surface, byte[] data, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            return FromMemory(surface, data, filter, colorKey, sourceFormat, sourcePitch, sourceRectangle, destinationRectangle, null, null);
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="sourcePalette">The source palette.</param>
        /// <param name="destinationPalette">The destination palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromMemory(Surface surface, byte[] data, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, PaletteEntry[] sourcePalette, PaletteEntry[] destinationPalette)
        {
            unsafe
            {
                fixed (void* pData = data)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, IntPtr.Zero, (IntPtr)pData, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);
            }
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="sourcePalette">The source palette.</param>
        /// <param name="destinationPalette">The destination palette.</param>
        /// <returns>A <see cref="SharpDX.Result" /> object describing the result of the operation.</returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromMemory(Surface surface, byte[] data, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] sourcePalette, PaletteEntry[] destinationPalette)
        {
            unsafe
            {
                fixed (void* pData = data)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, new IntPtr(&destinationRectangle), (IntPtr)pData, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);
            }
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromStream(Surface surface, Stream stream, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle)
        {
            return FromStream(surface, stream, filter, colorKey, sourceFormat, sourcePitch, sourceRectangle, null, null);
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromStream(Surface surface, Stream stream, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            return FromStream(surface, stream, filter, colorKey, sourceFormat, sourcePitch, sourceRectangle, destinationRectangle, null, null);
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="sourcePalette">The source palette.</param>
        /// <param name="destinationPalette">The destination palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromStream(Surface surface, Stream stream, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, PaletteEntry[] sourcePalette, PaletteEntry[] destinationPalette)
        {
            unsafe
            {
                if (stream is DataStream)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, IntPtr.Zero, ((DataStream)stream).DataPointer, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);

                var data = Utilities.ReadStream(stream);
                fixed (void* pData = data)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, IntPtr.Zero, (IntPtr)pData, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);
            }
        }

        /// <summary>
        /// Loads a surface from memory.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="stream">The stream.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceFormat">The source format.</param>
        /// <param name="sourcePitch">The source pitch.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="sourcePalette">The source palette.</param>
        /// <param name="destinationPalette">The destination palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromMemory([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] const void* pSrcMemory,[In] D3DFORMAT SrcFormat,[In] unsigned int SrcPitch,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromStream(Surface surface, Stream stream, Filter filter, int colorKey, Format sourceFormat, int sourcePitch, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] sourcePalette, PaletteEntry[] destinationPalette)
        {
            unsafe
            {
                if (stream is DataStream)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, new IntPtr(&destinationRectangle), ((DataStream)stream).DataPointer, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);

                var data = Utilities.ReadStream(stream);
                fixed (void* pData = data)
                    return D3DX9.LoadSurfaceFromMemory(surface, destinationPalette, new IntPtr(&destinationRectangle), (IntPtr)pData, sourceFormat, sourcePitch, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);
            }
        }

        /// <summary>
        /// Loads a surface from a source surface.
        /// </summary>
        /// <param name="destinationSurface">The destination surface.</param>
        /// <param name="sourceSurface">The source surface.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromSurface([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromSurface(Surface destinationSurface, Surface sourceSurface, Filter filter, int colorKey)
        {
            return D3DX9.LoadSurfaceFromSurface(destinationSurface, null, IntPtr.Zero, sourceSurface, null, IntPtr.Zero, filter, colorKey);
        }

        /// <summary>
        /// Loads a surface from a source surface.
        /// </summary>
        /// <param name="destinationSurface">The destination surface.</param>
        /// <param name="sourceSurface">The source surface.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromSurface([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromSurface(Surface destinationSurface, Surface sourceSurface, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            return FromSurface(destinationSurface, sourceSurface, filter, colorKey, sourceRectangle, destinationRectangle, null, null);
        }

        /// <summary>
        /// Loads a surface from a source surface.
        /// </summary>
        /// <param name="destinationSurface">The destination surface.</param>
        /// <param name="sourceSurface">The source surface.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="colorKey">The color key.</param>
        /// <param name="sourceRectangle">The source rectangle.</param>
        /// <param name="destinationRectangle">The destination rectangle.</param>
        /// <param name="destinationPalette">The destination palette.</param>
        /// <param name="sourcePalette">The source palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXLoadSurfaceFromSurface([In] IDirect3DSurface9* pDestSurface,[Out, Buffer] const PALETTEENTRY* pDestPalette,[In] const void* pDestRect,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect,[In] D3DX_FILTER Filter,[In] int ColorKey)</unmanaged>
        public static Result FromSurface(Surface destinationSurface, Surface sourceSurface, Filter filter, int colorKey, Rectangle sourceRectangle, Rectangle destinationRectangle, PaletteEntry[] destinationPalette, PaletteEntry[] sourcePalette)
        {
            unsafe
            {
                return D3DX9.LoadSurfaceFromSurface(destinationSurface, destinationPalette, new IntPtr(&destinationRectangle), sourceSurface, sourcePalette, new IntPtr(&sourceRectangle), filter, colorKey);
            }
        }

        /// <summary>
        /// Saves a surface to a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileW([In] const wchar_t* pDestFile,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static Result ToFile(Surface surface, string fileName, ImageFileFormat format)
        {
            return D3DX9.SaveSurfaceToFileW(fileName, format, surface, null, IntPtr.Zero);            
        }

        /// <summary>
        /// Saves a surface to a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="format">The format.</param>
        /// <param name="rectangle">The rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileW([In] const wchar_t* pDestFile,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static Result ToFile(Surface surface, string fileName, ImageFileFormat format, Rectangle rectangle)
        {
            return ToFile(surface, fileName, format, rectangle, null);
        }

        /// <summary>
        /// Saves a surface to a file.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="format">The format.</param>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileW([In] const wchar_t* pDestFile,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static Result ToFile(Surface surface, string fileName, ImageFileFormat format, Rectangle rectangle, PaletteEntry[] palette)
        {
            unsafe
            {
                return D3DX9.SaveSurfaceToFileW(fileName, format, surface, palette, new IntPtr(&rectangle));
            }            
        }

        /// <summary>
        /// Saves a surface to a stream.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileInMemory([In] ID3DXBuffer** ppDestBuf,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static DataStream ToStream(Surface surface, ImageFileFormat format)
        {
            Blob blob;
            D3DX9.SaveSurfaceToFileInMemory(out blob, format, surface, null, IntPtr.Zero);
            return new DataStream(blob);
        }

        /// <summary>
        /// Saves a surface to a stream.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="format">The format.</param>
        /// <param name="rectangle">The rectangle.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileInMemory([In] ID3DXBuffer** ppDestBuf,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static DataStream ToStream(Surface surface, ImageFileFormat format, Rectangle rectangle)
        {
            return ToStream(surface, format, rectangle, null);
        }

        /// <summary>
        /// Saves a surface to a stream.
        /// </summary>
        /// <param name="surface">The surface.</param>
        /// <param name="format">The format.</param>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="palette">The palette.</param>
        /// <returns>
        /// A <see cref="SharpDX.Result"/> object describing the result of the operation.
        /// </returns>
        /// <unmanaged>HRESULT D3DXSaveSurfaceToFileInMemory([In] ID3DXBuffer** ppDestBuf,[In] D3DXIMAGE_FILEFORMAT DestFormat,[In] IDirect3DSurface9* pSrcSurface,[In, Buffer] const PALETTEENTRY* pSrcPalette,[In] const void* pSrcRect)</unmanaged>
        public static DataStream ToStream(Surface surface, ImageFileFormat format, Rectangle rectangle, PaletteEntry[] palette)
        {
            unsafe
            {
                Blob blob;
                D3DX9.SaveSurfaceToFileInMemory(out blob, format, surface, palette, new IntPtr(&rectangle));
                return new DataStream(blob);
            }
        }
    }
}