﻿using Harmonic.Buffers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Harmonic.NetWorking.Amf.Data
{
    public interface IExternalizable
    {
        bool TryDecodeData(Span<byte> buffer, out int consumed);

        bool TryEncodeData(ByteBuffer buffer);
    }
}
