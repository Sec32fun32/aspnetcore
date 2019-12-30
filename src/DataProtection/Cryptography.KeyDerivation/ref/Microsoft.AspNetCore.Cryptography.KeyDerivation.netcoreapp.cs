// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Cryptography.KeyDerivation
{
    public static partial class KeyDerivation
    {
        public static byte[] Pbkdf2(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested) { throw null; }
    }
    public enum KeyDerivationPrf
    {
        HMACSHA1 = 0,
        HMACSHA256 = 1,
        HMACSHA512 = 2,
    }
}
namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
    internal partial interface IPbkdf2Provider
    {
        byte[] DeriveKey(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested);
    }
    internal sealed partial class ManagedPbkdf2Provider : Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2.IPbkdf2Provider
    {
        public ManagedPbkdf2Provider() { }
        public byte[] DeriveKey(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested) { throw null; }
    }
    internal sealed partial class NetCorePbkdf2Provider : Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2.IPbkdf2Provider
    {
        public NetCorePbkdf2Provider() { }
        public byte[] DeriveKey(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested) { throw null; }
    }
    internal static partial class Pbkdf2Util
    {
        public static readonly Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2.IPbkdf2Provider Pbkdf2Provider;
    }
    internal sealed partial class Win7Pbkdf2Provider : Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2.IPbkdf2Provider
    {
        public Win7Pbkdf2Provider() { }
        public byte[] DeriveKey(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested) { throw null; }
    }
    internal sealed partial class Win8Pbkdf2Provider : Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2.IPbkdf2Provider
    {
        public Win8Pbkdf2Provider() { }
        public byte[] DeriveKey(string password, byte[] salt, Microsoft.AspNetCore.Cryptography.KeyDerivation.KeyDerivationPrf prf, int iterationCount, int numBytesRequested) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static uint GetTotalByteLengthIncludingNullTerminator(string input) { throw null; }
    }
}
