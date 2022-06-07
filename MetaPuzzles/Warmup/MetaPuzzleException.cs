using System;
using System.Runtime.Serialization;

namespace MetaPuzzles.Warmup
{
    [Serializable]
    public class MetaPuzzleException : Exception
    {
        public MetaPuzzleException(string message) : base(message)
        {
        }

        protected MetaPuzzleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
