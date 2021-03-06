// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
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

namespace SharpDX.XAudio2
{
    public partial struct VoiceSendDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSendDescriptor"/> struct.
        /// </summary>
        /// <param name="outputVoice">The output voice.</param>
        public VoiceSendDescriptor(Voice outputVoice) : this(VoiceSendFlags.None, outputVoice)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSendDescriptor"/> struct.
        /// </summary>
        /// <param name="flags">The send flags.</param>
        /// <param name="outputVoice">The output voice.</param>
        public VoiceSendDescriptor(VoiceSendFlags flags, Voice outputVoice)
        {
            Flags = flags;
            OutputVoicePointer = IntPtr.Zero;
            OutputVoice = outputVoice;
        }


        /// <summary>
        /// Gets or sets the output voice. This parameter cannot be null.
        /// </summary>
        /// <value>The output voice.</value>
        public Voice OutputVoice
        {
            get
            {
                return OutputVoicePointer==IntPtr.Zero?null:new Voice(OutputVoicePointer);
            }
            set
            {
                OutputVoicePointer = value.NativePointer;                
            }
        }
    }
}