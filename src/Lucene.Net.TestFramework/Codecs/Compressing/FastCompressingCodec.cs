using Lucene.Net.Codecs.Lucene42;
using Lucene.Net.Util.Packed;

namespace Lucene.Net.Codecs.Compressing
{
    /*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */

    /// <summary>
    /// CompressionCodec that uses <see cref="CompressionMode.FAST"/>. </summary>
    [CodecName("FastCompressingStoredFields")]
    public class FastCompressingCodec : CompressingCodec
    {
        /// <summary>
        /// Constructor that allows to configure the chunk size. </summary>
        public FastCompressingCodec(int chunkSize, bool withSegmentSuffix)
            : base(withSegmentSuffix ? "FastCompressingStoredFields" : "", CompressionMode.FAST, chunkSize)
        { }

        /// <summary>
        /// Default constructor. </summary>
        public FastCompressingCodec()
            : this(1 << 14, false)
        { }

        public override NormsFormat NormsFormat => new Lucene42NormsFormat(PackedInt32s.FAST);
    }
}