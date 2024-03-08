// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace CsBindgen
{
    internal static unsafe partial class LibZstd
    {
        const string __DllName = "libzsd";



        /// <summary>ZSTD_versionNumber() :  Return runtime library version, the value is (MAJOR*100*100 + MINOR*100 + RELEASE).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_versionNumber", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_versionNumber();

        /// <summary>ZSTD_versionString() :  Return runtime library version, like \"1.4.5\". Requires v1.3.0+.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_versionString", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* ZSTD_versionString();

        /// <summary>Simple API//*! ZSTD_compress() :  Compresses `src` content as a single zstd compressed frame into already allocated `dst`.  Hint : compression runs faster if `dstCapacity` &gt;=  `ZSTD_compressBound(srcSize)`.  @return : compressed size written into `dst` (&lt;= `dstCapacity),            or an error code if it fails (which can be tested using ZSTD_isError()).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compress", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compress(void* dst, nuint dstCapacity, void* src, nuint srcSize, int compressionLevel);

        /// <summary>ZSTD_decompress() :  `compressedSize` : must be the _exact_ size of some number of compressed and/or skippable frames.  `dstCapacity` is an upper bound of originalSize to regenerate.  If user cannot imply a maximum upper bound, it's better to use streaming mode to decompress data.  @return : the number of bytes decompressed into `dst` (&lt;= `dstCapacity`),            or an errorCode if it fails (which can be tested using ZSTD_isError()).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_decompress", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_decompress(void* dst, nuint dstCapacity, void* src, nuint compressedSize);

        [DllImport(__DllName, EntryPoint = "ZSTD_getFrameContentSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong ZSTD_getFrameContentSize(void* src, nuint srcSize);

        /// <summary>ZSTD_getDecompressedSize() :  NOTE: This function is now obsolete, in favor of ZSTD_getFrameContentSize().  Both functions work the same way, but ZSTD_getDecompressedSize() blends  \"empty\", \"unknown\" and \"error\" results to the same return value (0),  while ZSTD_getFrameContentSize() gives them separate return values. @return : decompressed size of `src` frame content _if known and not empty_, 0 otherwise.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_getDecompressedSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong ZSTD_getDecompressedSize(void* src, nuint srcSize);

        /// <summary>ZSTD_findFrameCompressedSize() : Requires v1.4.0+ `src` should point to the start of a ZSTD frame or skippable frame. `srcSize` must be &gt;= first frame size @return : the compressed size of the first frame starting at `src`,           suitable to pass as `srcSize` to `ZSTD_decompress` or similar,        or an error code if input is invalid</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_findFrameCompressedSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_findFrameCompressedSize(void* src, nuint srcSize);

        [DllImport(__DllName, EntryPoint = "ZSTD_compressBound", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compressBound(nuint srcSize);

        [DllImport(__DllName, EntryPoint = "ZSTD_isError", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_isError(nuint code);

        [DllImport(__DllName, EntryPoint = "ZSTD_getErrorName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern byte* ZSTD_getErrorName(nuint code);

        [DllImport(__DllName, EntryPoint = "ZSTD_minCLevel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ZSTD_minCLevel();

        [DllImport(__DllName, EntryPoint = "ZSTD_maxCLevel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ZSTD_maxCLevel();

        [DllImport(__DllName, EntryPoint = "ZSTD_defaultCLevel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ZSTD_defaultCLevel();

        [DllImport(__DllName, EntryPoint = "ZSTD_createCCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_CCtx_s* ZSTD_createCCtx();

        [DllImport(__DllName, EntryPoint = "ZSTD_freeCCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeCCtx(ZSTD_CCtx_s* cctx);

        /// <summary>ZSTD_compressCCtx() :  Same as ZSTD_compress(), using an explicit ZSTD_CCtx.  Important : in order to behave similarly to `ZSTD_compress()`,  this function compresses at requested compression level,  __ignoring any other parameter__ .  If any advanced parameter was set using the advanced API,  they will all be reset. Only `compressionLevel` remains.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compressCCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compressCCtx(ZSTD_CCtx_s* cctx, void* dst, nuint dstCapacity, void* src, nuint srcSize, int compressionLevel);

        [DllImport(__DllName, EntryPoint = "ZSTD_createDCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_DCtx_s* ZSTD_createDCtx();

        [DllImport(__DllName, EntryPoint = "ZSTD_freeDCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeDCtx(ZSTD_DCtx_s* dctx);

        /// <summary>ZSTD_decompressDCtx() :  Same as ZSTD_decompress(),  requires an allocated ZSTD_DCtx.  Compatible with sticky parameters.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_decompressDCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_decompressDCtx(ZSTD_DCtx_s* dctx, void* dst, nuint dstCapacity, void* src, nuint srcSize);

        /// <summary>ZSTD_cParam_getBounds() :  All parameters must belong to an interval with lower and upper bounds,  otherwise they will either trigger an error or be automatically clamped. @return : a structure, ZSTD_bounds, which contains         - an error status field, which must be tested using ZSTD_isError()         - lower and upper bounds, both inclusive</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_cParam_getBounds", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_bounds ZSTD_cParam_getBounds(int cParam);

        /// <summary>ZSTD_CCtx_setParameter() :  Set one compression parameter, selected by enum ZSTD_cParameter.  All parameters have valid bounds. Bounds can be queried using ZSTD_cParam_getBounds().  Providing a value beyond bound will either clamp it, or trigger an error (depending on parameter).  Setting a parameter is generally only possible during frame initialization (before starting compression).  Exception : when using multi-threading mode (nbWorkers &gt;= 1),              the following parameters can be updated _during_ compression (within same frame):              =&gt; compressionLevel, hashLog, chainLog, searchLog, minMatch, targetLength and strategy.              new parameters will be active for next job only (after a flush()). @return : an error code (which can be tested using ZSTD_isError()).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_setParameter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_setParameter(ZSTD_CCtx_s* cctx, int param, int value);

        /// <summary>ZSTD_CCtx_setPledgedSrcSize() :  Total input data size to be compressed as a single frame.  Value will be written in frame header, unless if explicitly forbidden using ZSTD_c_contentSizeFlag.  This value will also be controlled at end of frame, and trigger an error if not respected. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Note 1 : pledgedSrcSize==0 actually means zero, aka an empty frame.           In order to mean \"unknown content size\", pass constant ZSTD_CONTENTSIZE_UNKNOWN.           ZSTD_CONTENTSIZE_UNKNOWN is default value for any new frame.  Note 2 : pledgedSrcSize is only valid once, for the next frame.           It's discarded at the end of the frame, and replaced by ZSTD_CONTENTSIZE_UNKNOWN.  Note 3 : Whenever all input data is provided and consumed in a single round,           for example with ZSTD_compress2(),           or invoking immediately ZSTD_compressStream2(,,,ZSTD_e_end),           this value is automatically overridden by srcSize instead.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_setPledgedSrcSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_setPledgedSrcSize(ZSTD_CCtx_s* cctx, ulong pledgedSrcSize);

        /// <summary>ZSTD_CCtx_reset() :  There are 2 different things that can be reset, independently or jointly :  - The session : will stop compressing current frame, and make CCtx ready to start a new one.                  Useful after an error, or to interrupt any ongoing compression.                  Any internal data not yet flushed is cancelled.                  Compression parameters and dictionary remain unchanged.                  They will be used to compress next frame.                  Resetting session never fails.  - The parameters : changes all parameters back to \"default\".                  This also removes any reference to any dictionary or external sequence producer.                  Parameters can only be changed between 2 sessions (i.e. no compression is currently ongoing)                  otherwise the reset fails, and function returns an error value (which can be tested using ZSTD_isError())  - Both : similar to resetting the session, followed by resetting parameters.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_reset", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_reset(ZSTD_CCtx_s* cctx, int reset);

        /// <summary>ZSTD_compress2() :  Behave the same as ZSTD_compressCCtx(), but compression parameters are set using the advanced API.  ZSTD_compress2() always starts a new frame.  Should cctx hold data from a previously unfinished frame, everything about it is forgotten.  - Compression parameters are pushed into CCtx before starting compression, using ZSTD_CCtx_set*()  - The function is always blocking, returns when compression is completed.  Hint : compression runs faster if `dstCapacity` &gt;=  `ZSTD_compressBound(srcSize)`. @return : compressed size written into `dst` (&lt;= `dstCapacity),           or an error code if it fails (which can be tested using ZSTD_isError()).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compress2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compress2(ZSTD_CCtx_s* cctx, void* dst, nuint dstCapacity, void* src, nuint srcSize);

        /// <summary>ZSTD_dParam_getBounds() :  All parameters must belong to an interval with lower and upper bounds,  otherwise they will either trigger an error or be automatically clamped. @return : a structure, ZSTD_bounds, which contains         - an error status field, which must be tested using ZSTD_isError()         - both lower and upper bounds, inclusive</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_dParam_getBounds", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_bounds ZSTD_dParam_getBounds(int dParam);

        /// <summary>ZSTD_DCtx_setParameter() :  Set one compression parameter, selected by enum ZSTD_dParameter.  All parameters have valid bounds. Bounds can be queried using ZSTD_dParam_getBounds().  Providing a value beyond bound will either clamp it, or trigger an error (depending on parameter).  Setting a parameter is only possible during frame initialization (before starting decompression). @return : 0, or an error code (which can be tested using ZSTD_isError()).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_DCtx_setParameter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DCtx_setParameter(ZSTD_DCtx_s* dctx, int param, int value);

        /// <summary>ZSTD_DCtx_reset() :  Return a DCtx to clean state.  Session and parameters can be reset jointly or separately.  Parameters can only be reset when no active frame is being decompressed. @return : 0, or an error code, which can be tested with ZSTD_isError()</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_DCtx_reset", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DCtx_reset(ZSTD_DCtx_s* dctx, int reset);

        [DllImport(__DllName, EntryPoint = "ZSTD_createCStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_CCtx_s* ZSTD_createCStream();

        [DllImport(__DllName, EntryPoint = "ZSTD_freeCStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeCStream(ZSTD_CCtx_s* zcs);

        /// <summary>ZSTD_compressStream2() : Requires v1.4.0+  Behaves about the same as ZSTD_compressStream, with additional control on end directive.  - Compression parameters are pushed into CCtx before starting compression, using ZSTD_CCtx_set*()  - Compression parameters cannot be changed once compression is started (save a list of exceptions in multi-threading mode)  - output-&gt;pos must be &lt;= dstCapacity, input-&gt;pos must be &lt;= srcSize  - output-&gt;pos and input-&gt;pos will be updated. They are guaranteed to remain below their respective limit.  - endOp must be a valid directive  - When nbWorkers==0 (default), function is blocking : it completes its job before returning to caller.  - When nbWorkers&gt;=1, function is non-blocking : it copies a portion of input, distributes jobs to internal worker threads, flush to output whatever is available,                                                  and then immediately returns, just indicating that there is some data remaining to be flushed.                                                  The function nonetheless guarantees forward progress : it will return only after it reads or write at least 1+ byte.  - Exception : if the first call requests a ZSTD_e_end directive and provides enough dstCapacity, the function delegates to ZSTD_compress2() which is always blocking.  - @return provides a minimum amount of data remaining to be flushed from internal buffers            or an error code, which can be tested using ZSTD_isError().            if @return != 0, flush is not fully completed, there is still some data left within internal buffers.            This is useful for ZSTD_e_flush, since in this case more flushes are necessary to empty all buffers.            For ZSTD_e_end, @return == 0 when internal buffers are fully flushed and frame is completed.  - after a ZSTD_e_end directive, if internal buffer is not fully flushed (@return != 0),            only ZSTD_e_end or ZSTD_e_flush operations are allowed.            Before starting a new compression job, or changing compression parameters,            it is required to fully flush internal buffers.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compressStream2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compressStream2(ZSTD_CCtx_s* cctx, ZSTD_outBuffer_s* output, ZSTD_inBuffer_s* input, int endOp);

        [DllImport(__DllName, EntryPoint = "ZSTD_CStreamInSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CStreamInSize();

        [DllImport(__DllName, EntryPoint = "ZSTD_CStreamOutSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CStreamOutSize();

        /// <summary>Equivalent to:     ZSTD_CCtx_reset(zcs, ZSTD_reset_session_only);     ZSTD_CCtx_refCDict(zcs, NULL); // clear the dictionary (if any)     ZSTD_CCtx_setParameter(zcs, ZSTD_c_compressionLevel, compressionLevel); Note that ZSTD_initCStream() clears any previously set dictionary. Use the new API to compress with a dictionary.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_initCStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_initCStream(ZSTD_CCtx_s* zcs, int compressionLevel);

        /// <summary>Alternative for ZSTD_compressStream2(zcs, output, input, ZSTD_e_continue). NOTE: The return value is different. ZSTD_compressStream() returns a hint for the next read size (if non-zero and not an error). ZSTD_compressStream2() returns the minimum nb of bytes left to flush (if non-zero and not an error).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compressStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compressStream(ZSTD_CCtx_s* zcs, ZSTD_outBuffer_s* output, ZSTD_inBuffer_s* input);

        /// <summary>Equivalent to ZSTD_compressStream2(zcs, output, &amp;emptyInput, ZSTD_e_flush).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_flushStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_flushStream(ZSTD_CCtx_s* zcs, ZSTD_outBuffer_s* output);

        /// <summary>Equivalent to ZSTD_compressStream2(zcs, output, &amp;emptyInput, ZSTD_e_end).</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_endStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_endStream(ZSTD_CCtx_s* zcs, ZSTD_outBuffer_s* output);

        [DllImport(__DllName, EntryPoint = "ZSTD_createDStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_DCtx_s* ZSTD_createDStream();

        [DllImport(__DllName, EntryPoint = "ZSTD_freeDStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeDStream(ZSTD_DCtx_s* zds);

        /// <summary>ZSTD_initDStream() : Initialize/reset DStream state for new decompression operation. Call before new decompression operation using same DStream. Note : This function is redundant with the advanced API and equivalent to:     ZSTD_DCtx_reset(zds, ZSTD_reset_session_only);     ZSTD_DCtx_refDDict(zds, NULL);</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_initDStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_initDStream(ZSTD_DCtx_s* zds);

        /// <summary>ZSTD_decompressStream() : Streaming decompression function. Call repetitively to consume full input updating it as necessary. Function will update both input and output `pos` fields exposing current state via these fields: - `input.pos &lt; input.size`, some input remaining and caller should provide remaining input   on the next call. - `output.pos &lt; output.size`, decoder finished and flushed all remaining buffers. - `output.pos == output.size`, potentially uncflushed data present in the internal buffers,   call ZSTD_decompressStream() again to flush remaining data to output. Note : with no additional input, amount of data flushed &lt;= ZSTD_BLOCKSIZE_MAX. @return : 0 when a frame is completely decoded and fully flushed,           or an error code, which can be tested using ZSTD_isError(),           or any other value &gt; 0, which means there is some decoding or flushing to do to complete current frame.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_decompressStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_decompressStream(ZSTD_DCtx_s* zds, ZSTD_outBuffer_s* output, ZSTD_inBuffer_s* input);

        [DllImport(__DllName, EntryPoint = "ZSTD_DStreamInSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DStreamInSize();

        [DllImport(__DllName, EntryPoint = "ZSTD_DStreamOutSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DStreamOutSize();

        /// <summary>Simple dictionary API//*! ZSTD_compress_usingDict() :  Compression at an explicit compression level using a Dictionary.  A dictionary can be any arbitrary data segment (also called a prefix),  or a buffer with specified information (see zdict.h).  Note : This function loads the dictionary, resulting in significant startup delay.         It's intended for a dictionary used only once.  Note 2 : When `dict == NULL || dictSize &lt; 8` no dictionary is used.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compress_usingDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compress_usingDict(ZSTD_CCtx_s* ctx, void* dst, nuint dstCapacity, void* src, nuint srcSize, void* dict, nuint dictSize, int compressionLevel);

        /// <summary>ZSTD_decompress_usingDict() :  Decompression using a known Dictionary.  Dictionary must be identical to the one used during compression.  Note : This function loads the dictionary, resulting in significant startup delay.         It's intended for a dictionary used only once.  Note : When `dict == NULL || dictSize &lt; 8` no dictionary is used.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_decompress_usingDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_decompress_usingDict(ZSTD_DCtx_s* dctx, void* dst, nuint dstCapacity, void* src, nuint srcSize, void* dict, nuint dictSize);

        /// <summary>ZSTD_createCDict() :  When compressing multiple messages or blocks using the same dictionary,  it's recommended to digest the dictionary only once, since it's a costly operation.  ZSTD_createCDict() will create a state from digesting a dictionary.  The resulting state can be used for future compression operations with very limited startup cost.  ZSTD_CDict can be created once and shared by multiple threads concurrently, since its usage is read-only. @dictBuffer can be released after ZSTD_CDict creation, because its content is copied within CDict.  Note 1 : Consider experimental function `ZSTD_createCDict_byReference()` if you prefer to not duplicate @dictBuffer content.  Note 2 : A ZSTD_CDict can be created from an empty @dictBuffer,      in which case the only thing that it transports is the @compressionLevel.      This can be useful in a pipeline featuring ZSTD_compress_usingCDict() exclusively,      expecting a ZSTD_CDict parameter with any data, including those without a known dictionary.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_createCDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_CDict_s* ZSTD_createCDict(void* dictBuffer, nuint dictSize, int compressionLevel);

        /// <summary>ZSTD_freeCDict() :  Function frees memory allocated by ZSTD_createCDict().  If a NULL pointer is passed, no operation is performed.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_freeCDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeCDict(ZSTD_CDict_s* CDict);

        /// <summary>ZSTD_compress_usingCDict() :  Compression using a digested Dictionary.  Recommended when same dictionary is used multiple times.  Note : compression level is _decided at dictionary creation time_,     and frame parameters are hardcoded (dictID=yes, contentSize=yes, checksum=no)</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_compress_usingCDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_compress_usingCDict(ZSTD_CCtx_s* cctx, void* dst, nuint dstCapacity, void* src, nuint srcSize, ZSTD_CDict_s* cdict);

        /// <summary>ZSTD_createDDict() :  Create a digested dictionary, ready to start decompression operation without startup delay.  dictBuffer can be released after DDict creation, as its content is copied inside DDict.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_createDDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ZSTD_DDict_s* ZSTD_createDDict(void* dictBuffer, nuint dictSize);

        /// <summary>ZSTD_freeDDict() :  Function frees memory allocated with ZSTD_createDDict()  If a NULL pointer is passed, no operation is performed.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_freeDDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_freeDDict(ZSTD_DDict_s* ddict);

        /// <summary>ZSTD_decompress_usingDDict() :  Decompression using a digested Dictionary.  Recommended when same dictionary is used multiple times.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_decompress_usingDDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_decompress_usingDDict(ZSTD_DCtx_s* dctx, void* dst, nuint dstCapacity, void* src, nuint srcSize, ZSTD_DDict_s* ddict);

        /// <summary>ZSTD_getDictID_fromDict() : Requires v1.4.0+  Provides the dictID stored within dictionary.  if @return == 0, the dictionary is not conformant with Zstandard specification.  It can still be loaded, but as a content-only dictionary.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_getDictID_fromDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_getDictID_fromDict(void* dict, nuint dictSize);

        /// <summary>ZSTD_getDictID_fromCDict() : Requires v1.5.0+  Provides the dictID of the dictionary loaded into `cdict`.  If @return == 0, the dictionary is not conformant to Zstandard specification, or empty.  Non-conformant dictionaries can still be loaded, but as content-only dictionaries.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_getDictID_fromCDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_getDictID_fromCDict(ZSTD_CDict_s* cdict);

        /// <summary>ZSTD_getDictID_fromDDict() : Requires v1.4.0+  Provides the dictID of the dictionary loaded into `ddict`.  If @return == 0, the dictionary is not conformant to Zstandard specification, or empty.  Non-conformant dictionaries can still be loaded, but as content-only dictionaries.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_getDictID_fromDDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_getDictID_fromDDict(ZSTD_DDict_s* ddict);

        /// <summary>ZSTD_getDictID_fromFrame() : Requires v1.4.0+  Provides the dictID required to decompressed the frame stored within `src`.  If @return == 0, the dictID could not be decoded.  This could for one of the following reasons :  - The frame does not require a dictionary to be decoded (most common case).  - The frame was built with dictID intentionally removed. Whatever dictionary is necessary is a hidden piece of information.    Note : this use case also happens when using a non-conformant dictionary.  - `srcSize` is too small, and as a result, the frame header could not be decoded (only possible if `srcSize &lt; ZSTD_FRAMEHEADERSIZE_MAX`).  - This is not a Zstandard frame.  When identifying the exact failure cause, it's possible to use ZSTD_getFrameHeader(), which will provide a more precise error code.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_getDictID_fromFrame", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern uint ZSTD_getDictID_fromFrame(void* src, nuint srcSize);

        /// <summary>ZSTD_CCtx_loadDictionary() : Requires v1.4.0+  Create an internal CDict from `dict` buffer.  Decompression will have to use same dictionary. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Special: Loading a NULL (or 0-size) dictionary invalidates previous dictionary,           meaning \"return to no-dictionary mode\".  Note 1 : Dictionary is sticky, it will be used for all future compressed frames,           until parameters are reset, a new dictionary is loaded, or the dictionary           is explicitly invalidated by loading a NULL dictionary.  Note 2 : Loading a dictionary involves building tables.           It's also a CPU consuming operation, with non-negligible impact on latency.           Tables are dependent on compression parameters, and for this reason,           compression parameters can no longer be changed after loading a dictionary.  Note 3 :`dict` content will be copied internally.           Use experimental ZSTD_CCtx_loadDictionary_byReference() to reference content instead.           In such a case, dictionary buffer must outlive its users.  Note 4 : Use ZSTD_CCtx_loadDictionary_advanced()           to precisely select how dictionary content must be interpreted.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_loadDictionary", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_loadDictionary(ZSTD_CCtx_s* cctx, void* dict, nuint dictSize);

        /// <summary>ZSTD_CCtx_refCDict() : Requires v1.4.0+  Reference a prepared dictionary, to be used for all future compressed frames.  Note that compression parameters are enforced from within CDict,  and supersede any compression parameter previously set within CCtx.  The parameters ignored are labelled as \"superseded-by-cdict\" in the ZSTD_cParameter enum docs.  The ignored parameters will be used again if the CCtx is returned to no-dictionary mode.  The dictionary will remain valid for future compressed frames using same CCtx. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Special : Referencing a NULL CDict means \"return to no-dictionary mode\".  Note 1 : Currently, only one dictionary can be managed.           Referencing a new dictionary effectively \"discards\" any previous one.  Note 2 : CDict is just referenced, its lifetime must outlive its usage within CCtx.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_refCDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_refCDict(ZSTD_CCtx_s* cctx, ZSTD_CDict_s* cdict);

        /// <summary>ZSTD_CCtx_refPrefix() : Requires v1.4.0+  Reference a prefix (single-usage dictionary) for next compressed frame.  A prefix is **only used once**. Tables are discarded at end of frame (ZSTD_e_end).  Decompression will need same prefix to properly regenerate data.  Compressing with a prefix is similar in outcome as performing a diff and compressing it,  but performs much faster, especially during decompression (compression speed is tunable with compression level). @result : 0, or an error code (which can be tested with ZSTD_isError()).  Special: Adding any prefix (including NULL) invalidates any previous prefix or dictionary  Note 1 : Prefix buffer is referenced. It **must** outlive compression.           Its content must remain unmodified during compression.  Note 2 : If the intention is to diff some large src data blob with some prior version of itself,           ensure that the window size is large enough to contain the entire source.           See ZSTD_c_windowLog.  Note 3 : Referencing a prefix involves building tables, which are dependent on compression parameters.           It's a CPU consuming operation, with non-negligible impact on latency.           If there is a need to use the same prefix multiple times, consider loadDictionary instead.  Note 4 : By default, the prefix is interpreted as raw content (ZSTD_dct_rawContent).           Use experimental ZSTD_CCtx_refPrefix_advanced() to alter dictionary interpretation.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_CCtx_refPrefix", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_CCtx_refPrefix(ZSTD_CCtx_s* cctx, void* prefix, nuint prefixSize);

        /// <summary>ZSTD_DCtx_loadDictionary() : Requires v1.4.0+  Create an internal DDict from dict buffer, to be used to decompress all future frames.  The dictionary remains valid for all future frames, until explicitly invalidated, or  a new dictionary is loaded. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Special : Adding a NULL (or 0-size) dictionary invalidates any previous dictionary,            meaning \"return to no-dictionary mode\".  Note 1 : Loading a dictionary involves building tables,           which has a non-negligible impact on CPU usage and latency.           It's recommended to \"load once, use many times\", to amortize the cost  Note 2 :`dict` content will be copied internally, so `dict` can be released after loading.           Use ZSTD_DCtx_loadDictionary_byReference() to reference dictionary content instead.  Note 3 : Use ZSTD_DCtx_loadDictionary_advanced() to take control of           how dictionary content is loaded and interpreted.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_DCtx_loadDictionary", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DCtx_loadDictionary(ZSTD_DCtx_s* dctx, void* dict, nuint dictSize);

        /// <summary>ZSTD_DCtx_refDDict() : Requires v1.4.0+  Reference a prepared dictionary, to be used to decompress next frames.  The dictionary remains active for decompression of future frames using same DCtx.  If called with ZSTD_d_refMultipleDDicts enabled, repeated calls of this function  will store the DDict references in a table, and the DDict used for decompression  will be determined at decompression time, as per the dict ID in the frame.  The memory for the table is allocated on the first call to refDDict, and can be  freed with ZSTD_freeDCtx().  If called with ZSTD_d_refMultipleDDicts disabled (the default), only one dictionary  will be managed, and referencing a dictionary effectively \"discards\" any previous one. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Special: referencing a NULL DDict means \"return to no-dictionary mode\".  Note 2 : DDict is just referenced, its lifetime must outlive its usage from DCtx.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_DCtx_refDDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DCtx_refDDict(ZSTD_DCtx_s* dctx, ZSTD_DDict_s* ddict);

        /// <summary>ZSTD_DCtx_refPrefix() : Requires v1.4.0+  Reference a prefix (single-usage dictionary) to decompress next frame.  This is the reverse operation of ZSTD_CCtx_refPrefix(),  and must use the same prefix as the one used during compression.  Prefix is **only used once**. Reference is discarded at end of frame.  End of frame is reached when ZSTD_decompressStream() returns 0. @result : 0, or an error code (which can be tested with ZSTD_isError()).  Note 1 : Adding any prefix (including NULL) invalidates any previously set prefix or dictionary  Note 2 : Prefix buffer is referenced. It **must** outlive decompression.           Prefix buffer must remain unmodified up to the end of frame,           reached when ZSTD_decompressStream() returns 0.  Note 3 : By default, the prefix is treated as raw content (ZSTD_dct_rawContent).           Use ZSTD_CCtx_refPrefix_advanced() to alter dictMode (Experimental section)  Note 4 : Referencing a raw content prefix has almost no cpu nor memory cost.           A full dictionary is more costly, as it requires building tables.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_DCtx_refPrefix", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_DCtx_refPrefix(ZSTD_DCtx_s* dctx, void* prefix, nuint prefixSize);

        /// <summary>ZSTD_sizeof_*() : Requires v1.4.0+  These functions give the _current_ memory usage of selected object.  Note that object memory usage can evolve (increase or decrease) over time.</summary>
        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_CCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_CCtx(ZSTD_CCtx_s* cctx);

        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_DCtx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_DCtx(ZSTD_DCtx_s* dctx);

        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_CStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_CStream(ZSTD_CCtx_s* zcs);

        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_DStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_DStream(ZSTD_DCtx_s* zds);

        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_CDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_CDict(ZSTD_CDict_s* cdict);

        [DllImport(__DllName, EntryPoint = "ZSTD_sizeof_DDict", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern nuint ZSTD_sizeof_DDict(ZSTD_DDict_s* ddict);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_CCtx_s
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_DCtx_s
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_bounds
    {
        public nuint error;
        public int lowerBound;
        public int upperBound;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_inBuffer_s
    {
        public void* src;
        public nuint size;
        public nuint pos;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_outBuffer_s
    {
        public void* dst;
        public nuint size;
        public nuint pos;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_CDict_s
    {
        public fixed byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct ZSTD_DDict_s
    {
        public fixed byte _unused[1];
    }



}
