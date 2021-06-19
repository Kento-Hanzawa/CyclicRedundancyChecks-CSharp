 
using System;

namespace CyclicRedundancyChecks
{
    public sealed partial class CRC8 : CRC
    {
        private const int SizeAsByte = sizeof(global::System.Byte);
        private const int SizeAsBit = SizeAsByte * 8;

        private global::System.Byte result;
        private readonly global::System.Byte[] lookupTableBuffer;

        public global::System.Byte Polynomial { get; }
        public global::System.Byte InitialValue { get; }
        public global::System.Byte FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.Byte> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC8(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = SizeAsBit;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;
            this.result = InitialValue;
            lookupTableBuffer = System.Buffers.ArrayPool<global::System.Byte>.Shared.Rent(TableSize);
            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
        }

        public override void Initialize()
        {
            result = InitialValue;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (ReversedData)
                {
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.Byte)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (SizeAsBit - 8)) & 0xFF) ^ source[i]);
                    result = (global::System.Byte)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[SizeAsByte];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < SizeAsByte)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.Byte) * 8) > SizeAsBit)
            {
                result = (global::System.Byte)(result & ((global::System.Byte)1 << SizeAsBit) - 1);
            }

            if (ReversedOut)
                result = (global::System.Byte)(~result ^ FinalXorValue);
            else
                result = (global::System.Byte)(result ^ FinalXorValue);

            var shift = SizeAsBit - 8;
            for (var i = 0; i < SizeAsByte; i++)
            {
                destination[i] = (byte)(result >> shift);
                shift -= 8;
            }
            bytesWritten = SizeAsByte;
            return true;
        }

        #region IDisposable
        private bool disposedValue = false;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                        System.Buffers.ArrayPool<global::System.Byte>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    public sealed partial class CRC16 : CRC
    {
        private const int SizeAsByte = sizeof(global::System.UInt16);
        private const int SizeAsBit = SizeAsByte * 8;

        private global::System.UInt16 result;
        private readonly global::System.UInt16[] lookupTableBuffer;

        public global::System.UInt16 Polynomial { get; }
        public global::System.UInt16 InitialValue { get; }
        public global::System.UInt16 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt16> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC16(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = SizeAsBit;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;
            this.result = InitialValue;
            lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt16>.Shared.Rent(TableSize);
            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
        }

        public override void Initialize()
        {
            result = InitialValue;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (ReversedData)
                {
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt16)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (SizeAsBit - 8)) & 0xFF) ^ source[i]);
                    result = (global::System.UInt16)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[SizeAsByte];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < SizeAsByte)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt16) * 8) > SizeAsBit)
            {
                result = (global::System.UInt16)(result & ((global::System.UInt16)1 << SizeAsBit) - 1);
            }

            if (ReversedOut)
                result = (global::System.UInt16)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt16)(result ^ FinalXorValue);

            var shift = SizeAsBit - 8;
            for (var i = 0; i < SizeAsByte; i++)
            {
                destination[i] = (byte)(result >> shift);
                shift -= 8;
            }
            bytesWritten = SizeAsByte;
            return true;
        }

        #region IDisposable
        private bool disposedValue = false;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                        System.Buffers.ArrayPool<global::System.UInt16>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    public sealed partial class CRC32 : CRC
    {
        private const int SizeAsByte = sizeof(global::System.UInt32);
        private const int SizeAsBit = SizeAsByte * 8;

        private global::System.UInt32 result;
        private readonly global::System.UInt32[] lookupTableBuffer;

        public global::System.UInt32 Polynomial { get; }
        public global::System.UInt32 InitialValue { get; }
        public global::System.UInt32 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt32> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC32(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = SizeAsBit;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;
            this.result = InitialValue;
            lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt32>.Shared.Rent(TableSize);
            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
        }

        public override void Initialize()
        {
            result = InitialValue;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (ReversedData)
                {
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt32)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (SizeAsBit - 8)) & 0xFF) ^ source[i]);
                    result = (global::System.UInt32)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[SizeAsByte];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < SizeAsByte)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt32) * 8) > SizeAsBit)
            {
                result = (global::System.UInt32)(result & ((global::System.UInt32)1 << SizeAsBit) - 1);
            }

            if (ReversedOut)
                result = (global::System.UInt32)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt32)(result ^ FinalXorValue);

            var shift = SizeAsBit - 8;
            for (var i = 0; i < SizeAsByte; i++)
            {
                destination[i] = (byte)(result >> shift);
                shift -= 8;
            }
            bytesWritten = SizeAsByte;
            return true;
        }

        #region IDisposable
        private bool disposedValue = false;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                        System.Buffers.ArrayPool<global::System.UInt32>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    public sealed partial class CRC64 : CRC
    {
        private const int SizeAsByte = sizeof(global::System.UInt64);
        private const int SizeAsBit = SizeAsByte * 8;

        private global::System.UInt64 result;
        private readonly global::System.UInt64[] lookupTableBuffer;

        public global::System.UInt64 Polynomial { get; }
        public global::System.UInt64 InitialValue { get; }
        public global::System.UInt64 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt64> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC64(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = SizeAsBit;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;
            this.result = InitialValue;
            lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt64>.Shared.Rent(TableSize);
            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
        }

        public override void Initialize()
        {
            result = InitialValue;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (ReversedData)
                {
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt64)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (SizeAsBit - 8)) & 0xFF) ^ source[i]);
                    result = (global::System.UInt64)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[SizeAsByte];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < SizeAsByte)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt64) * 8) > SizeAsBit)
            {
                result = (global::System.UInt64)(result & ((global::System.UInt64)1 << SizeAsBit) - 1);
            }

            if (ReversedOut)
                result = (global::System.UInt64)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt64)(result ^ FinalXorValue);

            var shift = SizeAsBit - 8;
            for (var i = 0; i < SizeAsByte; i++)
            {
                destination[i] = (byte)(result >> shift);
                shift -= 8;
            }
            bytesWritten = SizeAsByte;
            return true;
        }

        #region IDisposable
        private bool disposedValue = false;
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                        System.Buffers.ArrayPool<global::System.UInt64>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

}
