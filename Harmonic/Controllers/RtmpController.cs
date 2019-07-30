﻿using Harmonic.NetWorking.Rtmp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Harmonic.Controllers
{
    public abstract class RtmpController
    {
        public RtmpMessageStream MessageStream { get; internal set; } = null;
        public RtmpChunkStream ChunkStream { get; internal set; } = null;
        public RtmpSession RtmpSession { get; internal set; } = null;
    }
}
