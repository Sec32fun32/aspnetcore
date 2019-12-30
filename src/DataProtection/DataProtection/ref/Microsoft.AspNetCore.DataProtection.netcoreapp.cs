// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.DataProtection
{
    internal static partial class ActivatorExtensions
    {
        public static T CreateInstance<T>(this Microsoft.AspNetCore.DataProtection.Internal.IActivator activator, string implementationTypeName) where T : class { throw null; }
        public static Microsoft.AspNetCore.DataProtection.Internal.IActivator GetActivator(this System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property, AllowMultiple=false, Inherited=false)]
    internal sealed partial class ApplyPolicyAttribute : System.Attribute
    {
        public ApplyPolicyAttribute() { }
    }
    internal static partial class ArraySegmentExtensions
    {
        public static byte[] AsStandaloneArray(this System.ArraySegment<byte> arraySegment) { throw null; }
        public static void Validate<T>(this System.ArraySegment<T> arraySegment) { }
    }
    internal static partial class BitHelpers
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public unsafe static void WriteTo(ref byte* ptr, uint value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static void WriteTo(byte[] buffer, ref int idx, int value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static void WriteTo(byte[] buffer, ref int idx, uint value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public unsafe static void WriteTo(void* ptr, uint value) { }
    }
    public static partial class DataProtectionBuilderExtensions
    {
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddKeyEscrowSink(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink sink) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddKeyEscrowSink(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.Func<System.IServiceProvider, Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink> factory) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddKeyEscrowSink<TImplementation>(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder) where TImplementation : class, Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddKeyManagementOptions(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.Action<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> setupAction) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder DisableAutomaticKeyGeneration(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder PersistKeysToFileSystem(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.IO.DirectoryInfo directory) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder PersistKeysToRegistry(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.Win32.RegistryKey registryKey) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithCertificate(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithCertificate(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, string thumbprint) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithDpapi(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithDpapi(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, bool protectToLocalMachine) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithDpapiNG(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder ProtectKeysWithDpapiNG(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, string protectionDescriptorRule, Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiNGProtectionDescriptorFlags flags) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder SetApplicationName(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, string applicationName) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder SetDefaultKeyLifetime(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, System.TimeSpan lifetime) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UnprotectKeysWithAnyCertificate(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, params System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UseCryptographicAlgorithms(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration configuration) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UseCustomCryptographicAlgorithms(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorConfiguration configuration) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UseCustomCryptographicAlgorithms(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngGcmAuthenticatedEncryptorConfiguration configuration) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UseCustomCryptographicAlgorithms(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorConfiguration configuration) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder UseEphemeralDataProtectionProvider(this Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder builder) { throw null; }
    }
    public partial class DataProtectionOptions
    {
        public DataProtectionOptions() { }
        public string ApplicationDiscriminator { get { throw null; } set { } }
    }
    public static partial class DataProtectionUtilityExtensions
    {
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static string GetApplicationUniqueIdentifier(this System.IServiceProvider services) { throw null; }
    }
    internal static partial class EncodingUtil
    {
        public static readonly System.Text.UTF8Encoding SecureUtf8Encoding;
    }
    public sealed partial class EphemeralDataProtectionProvider : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider
    {
        public EphemeralDataProtectionProvider() { }
        public EphemeralDataProtectionProvider(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(string purpose) { throw null; }
    }
    internal static partial class Error
    {
        public static System.InvalidOperationException CertificateXmlEncryptor_CertificateNotFound(string thumbprint) { throw null; }
        public static System.ArgumentException Common_ArgumentCannotBeNullOrEmpty(string parameterName) { throw null; }
        public static System.ArgumentException Common_BufferIncorrectlySized(string parameterName, int actualSize, int expectedSize) { throw null; }
        public static System.Security.Cryptography.CryptographicException Common_EncryptionFailed(System.Exception inner = null) { throw null; }
        public static System.Security.Cryptography.CryptographicException Common_KeyNotFound(System.Guid id) { throw null; }
        public static System.Security.Cryptography.CryptographicException Common_KeyRevoked(System.Guid id) { throw null; }
        public static System.InvalidOperationException Common_PropertyCannotBeNullOrEmpty(string propertyName) { throw null; }
        public static System.InvalidOperationException Common_PropertyMustBeNonNegative(string propertyName) { throw null; }
        public static System.ArgumentOutOfRangeException Common_ValueMustBeNonNegative(string paramName) { throw null; }
        public static System.Security.Cryptography.CryptographicException CryptCommon_GenericError(System.Exception inner = null) { throw null; }
        public static System.Security.Cryptography.CryptographicException CryptCommon_PayloadInvalid() { throw null; }
        public static System.Security.Cryptography.CryptographicException DecryptionFailed(System.Exception inner) { throw null; }
        public static System.Security.Cryptography.CryptographicException ProtectionProvider_BadMagicHeader() { throw null; }
        public static System.Security.Cryptography.CryptographicException ProtectionProvider_BadVersion() { throw null; }
        public static System.InvalidOperationException XmlKeyManager_DuplicateKey(System.Guid keyId) { throw null; }
    }
    internal static partial class ExceptionExtensions
    {
        public static bool RequiresHomogenization(this System.Exception ex) { throw null; }
    }
    public partial interface IDataProtectionBuilder
    {
        Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get; }
    }
    public partial interface IPersistedDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider, Microsoft.AspNetCore.DataProtection.IDataProtector
    {
        byte[] DangerousUnprotect(byte[] protectedData, bool ignoreRevocationErrors, out bool requiresMigration, out bool wasRevoked);
    }
    internal partial interface IRegistryPolicyResolver
    {
        Microsoft.AspNetCore.DataProtection.RegistryPolicy ResolvePolicy();
    }
    public partial interface ISecret : System.IDisposable
    {
        int Length { get; }
        void WriteSecretIntoBuffer(System.ArraySegment<byte> buffer);
    }
    internal static partial class MemoryProtection
    {
        public static void CryptProtectMemory(System.Runtime.InteropServices.SafeHandle pBuffer, uint byteCount) { }
        public unsafe static void CryptUnprotectMemory(byte* pBuffer, uint byteCount) { }
        public static void CryptUnprotectMemory(System.Runtime.InteropServices.SafeHandle pBuffer, uint byteCount) { }
    }
    internal partial class RegistryPolicy
    {
        public RegistryPolicy(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration configuration, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink> keyEscrowSinks, int? defaultKeyLifetime) { }
        public int? DefaultKeyLifetime { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration EncryptorConfiguration { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink> KeyEscrowSinks { get { throw null; } }
    }
    internal sealed partial class RegistryPolicyResolver : Microsoft.AspNetCore.DataProtection.IRegistryPolicyResolver
    {
        public RegistryPolicyResolver(Microsoft.AspNetCore.DataProtection.Internal.IActivator activator) { }
        internal RegistryPolicyResolver(Microsoft.Win32.RegistryKey policyRegKey, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator) { }
        public Microsoft.AspNetCore.DataProtection.RegistryPolicy ResolvePolicy() { throw null; }
    }
    internal static partial class Resources
    {
        internal static string AlgorithmAssert_BadBlockSize { get { throw null; } }
        internal static string AlgorithmAssert_BadDigestSize { get { throw null; } }
        internal static string AlgorithmAssert_BadKeySize { get { throw null; } }
        internal static string CertificateXmlEncryptor_CertificateNotFound { get { throw null; } }
        internal static string Common_ArgumentCannotBeNullOrEmpty { get { throw null; } }
        internal static string Common_BufferIncorrectlySized { get { throw null; } }
        internal static string Common_DecryptionFailed { get { throw null; } }
        internal static string Common_EncryptionFailed { get { throw null; } }
        internal static string Common_KeyNotFound { get { throw null; } }
        internal static string Common_KeyRevoked { get { throw null; } }
        internal static string Common_PropertyCannotBeNullOrEmpty { get { throw null; } }
        internal static string Common_PropertyMustBeNonNegative { get { throw null; } }
        internal static string Common_ValueMustBeNonNegative { get { throw null; } }
        internal static string CryptCommon_GenericError { get { throw null; } }
        internal static string CryptCommon_PayloadInvalid { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        internal static string EncryptedXmlDecryptor_DoesNotWorkOnCoreClr { get { throw null; } }
        internal static string FileSystem_EphemeralKeysLocationInContainer { get { throw null; } }
        internal static string KeyManagementOptions_MinNewKeyLifetimeViolated { get { throw null; } }
        internal static string KeyRingProvider_NoDefaultKey_AutoGenerateDisabled { get { throw null; } }
        internal static string LifetimeMustNotBeNegative { get { throw null; } }
        internal static string Platform_WindowsRequiredForGcm { get { throw null; } }
        internal static string ProtectionProvider_BadMagicHeader { get { throw null; } }
        internal static string ProtectionProvider_BadVersion { get { throw null; } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string TypeExtensions_BadCast { get { throw null; } }
        internal static string XmlKeyManager_DuplicateKey { get { throw null; } }
        internal static string XmlKeyManager_IXmlRepositoryNotFound { get { throw null; } }
        internal static string FormatAlgorithmAssert_BadBlockSize(object p0) { throw null; }
        internal static string FormatAlgorithmAssert_BadDigestSize(object p0) { throw null; }
        internal static string FormatAlgorithmAssert_BadKeySize(object p0) { throw null; }
        internal static string FormatCertificateXmlEncryptor_CertificateNotFound(object p0) { throw null; }
        internal static string FormatCommon_BufferIncorrectlySized(object p0, object p1) { throw null; }
        internal static string FormatCommon_PropertyCannotBeNullOrEmpty(object p0) { throw null; }
        internal static string FormatCommon_PropertyMustBeNonNegative(object p0) { throw null; }
        internal static string FormatFileSystem_EphemeralKeysLocationInContainer(object path) { throw null; }
        internal static string FormatLifetimeMustNotBeNegative(object p0) { throw null; }
        internal static string FormatTypeExtensions_BadCast(object p0, object p1) { throw null; }
        internal static string FormatXmlKeyManager_IXmlRepositoryNotFound(object p0, object p1) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
    public sealed partial class Secret : Microsoft.AspNetCore.DataProtection.ISecret, System.IDisposable
    {
        public Secret(Microsoft.AspNetCore.DataProtection.ISecret secret) { }
        public Secret(System.ArraySegment<byte> value) { }
        public unsafe Secret(byte* secret, int secretLength) { }
        public Secret(byte[] value) { }
        public int Length { get { throw null; } }
        public void Dispose() { }
        public static Microsoft.AspNetCore.DataProtection.Secret Random(int numBytes) { throw null; }
        public void WriteSecretIntoBuffer(System.ArraySegment<byte> buffer) { }
        public unsafe void WriteSecretIntoBuffer(byte* buffer, int bufferLength) { }
    }
    internal partial class SimpleActivator : Microsoft.AspNetCore.DataProtection.Internal.IActivator
    {
        internal static readonly Microsoft.AspNetCore.DataProtection.SimpleActivator DefaultWithoutServices;
        public SimpleActivator(System.IServiceProvider services) { }
        public virtual object CreateInstance(System.Type expectedBaseType, string implementationTypeName) { throw null; }
    }
    internal static partial class TypeExtensions
    {
        public static void AssertIsAssignableFrom(this System.Type expectedBaseType, System.Type implementationType) { }
    }
    internal partial class TypeForwardingActivator : Microsoft.AspNetCore.DataProtection.SimpleActivator
    {
        public TypeForwardingActivator(System.IServiceProvider services) : base (default(System.IServiceProvider)) { }
        public TypeForwardingActivator(System.IServiceProvider services, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) : base (default(System.IServiceProvider)) { }
        public override object CreateInstance(System.Type expectedBaseType, string originalTypeName) { throw null; }
        internal object CreateInstance(System.Type expectedBaseType, string originalTypeName, out bool forwarded) { throw null; }
        protected string RemoveVersionFromAssemblyName(string forwardedTypeName) { throw null; }
    }
    internal static partial class XmlConstants
    {
        internal static readonly System.Xml.Linq.XName DecryptorTypeAttributeName;
        internal static readonly System.Xml.Linq.XName DeserializerTypeAttributeName;
        internal static readonly System.Xml.Linq.XName EncryptedSecretElementName;
        internal static readonly System.Xml.Linq.XName RequiresEncryptionAttributeName;
    }
    internal static partial class XmlExtensions
    {
        public static System.Xml.Linq.XElement WithoutChildNodes(this System.Xml.Linq.XElement element) { throw null; }
    }
}
namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
    internal static partial class AlgorithmAssert
    {
        public static void IsAllowableSymmetricAlgorithmBlockSize(uint blockSizeInBits) { }
        public static void IsAllowableSymmetricAlgorithmKeySize(uint keySizeInBits) { }
        public static void IsAllowableValidationAlgorithmDigestSize(uint digestSizeInBits) { }
    }
    internal static partial class AuthenticatedEncryptorExtensions
    {
        public static byte[] Encrypt(this Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor encryptor, System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData, uint preBufferSize, uint postBufferSize) { throw null; }
        public static void PerformSelfTest(this Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor encryptor) { }
    }
    public sealed partial class AuthenticatedEncryptorFactory : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory
    {
        public AuthenticatedEncryptorFactory(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(Microsoft.AspNetCore.DataProtection.ISecret secret, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration authenticatedConfiguration) { throw null; }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptorInstance(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key) { throw null; }
        internal static bool IsGcmAlgorithm(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm algorithm) { throw null; }
    }
    public sealed partial class CngCbcAuthenticatedEncryptorFactory : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory
    {
        public CngCbcAuthenticatedEncryptorFactory(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.DataProtection.Cng.CbcAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(Microsoft.AspNetCore.DataProtection.ISecret secret, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorConfiguration configuration) { throw null; }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptorInstance(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key) { throw null; }
    }
    public sealed partial class CngGcmAuthenticatedEncryptorFactory : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory
    {
        public CngGcmAuthenticatedEncryptorFactory(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.DataProtection.Cng.GcmAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(Microsoft.AspNetCore.DataProtection.ISecret secret, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngGcmAuthenticatedEncryptorConfiguration configuration) { throw null; }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptorInstance(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key) { throw null; }
    }
    public enum EncryptionAlgorithm
    {
        AES_128_CBC = 0,
        AES_192_CBC = 1,
        AES_256_CBC = 2,
        AES_128_GCM = 3,
        AES_192_GCM = 4,
        AES_256_GCM = 5,
    }
    public partial interface IAuthenticatedEncryptor
    {
        byte[] Decrypt(System.ArraySegment<byte> ciphertext, System.ArraySegment<byte> additionalAuthenticatedData);
        byte[] Encrypt(System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData);
    }
    public partial interface IAuthenticatedEncryptorFactory
    {
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptorInstance(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key);
    }
    internal partial interface IOptimizedAuthenticatedEncryptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor
    {
        byte[] Encrypt(System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData, uint preBufferSize, uint postBufferSize);
    }
    public sealed partial class ManagedAuthenticatedEncryptorFactory : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory
    {
        public ManagedAuthenticatedEncryptorFactory(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal Microsoft.AspNetCore.DataProtection.Managed.ManagedAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(Microsoft.AspNetCore.DataProtection.ISecret secret, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorConfiguration configuration) { throw null; }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptorInstance(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key) { throw null; }
    }
    public enum ValidationAlgorithm
    {
        HMACSHA256 = 0,
        HMACSHA512 = 1,
    }
}
namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
    public abstract partial class AlgorithmConfiguration
    {
        internal const int KDK_SIZE_IN_BYTES = 64;
        protected AlgorithmConfiguration() { }
        public abstract Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateNewDescriptor();
    }
    public sealed partial class AuthenticatedEncryptorConfiguration : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration
    {
        public AuthenticatedEncryptorConfiguration() { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.EncryptionAlgorithm EncryptionAlgorithm { get { throw null; } set { } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ValidationAlgorithm ValidationAlgorithm { get { throw null; } set { } }
        public override Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateNewDescriptor() { throw null; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.CreateDescriptorFromSecret(Microsoft.AspNetCore.DataProtection.ISecret secret) { throw null; }
        void Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.Validate() { }
    }
    public sealed partial class AuthenticatedEncryptorDescriptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor
    {
        public AuthenticatedEncryptorDescriptor(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration configuration, Microsoft.AspNetCore.DataProtection.ISecret masterKey) { }
        internal Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration Configuration { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.ISecret MasterKey { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo ExportToXml() { throw null; }
    }
    public sealed partial class AuthenticatedEncryptorDescriptorDeserializer : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer
    {
        public AuthenticatedEncryptorDescriptorDeserializer() { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor ImportFromXml(System.Xml.Linq.XElement element) { throw null; }
    }
    public sealed partial class CngCbcAuthenticatedEncryptorConfiguration : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration
    {
        public CngCbcAuthenticatedEncryptorConfiguration() { }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string EncryptionAlgorithm { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public int EncryptionAlgorithmKeySize { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string EncryptionAlgorithmProvider { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string HashAlgorithm { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string HashAlgorithmProvider { get { throw null; } set { } }
        public override Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateNewDescriptor() { throw null; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.CreateDescriptorFromSecret(Microsoft.AspNetCore.DataProtection.ISecret secret) { throw null; }
        void Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.Validate() { }
    }
    public sealed partial class CngCbcAuthenticatedEncryptorDescriptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor
    {
        public CngCbcAuthenticatedEncryptorDescriptor(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorConfiguration configuration, Microsoft.AspNetCore.DataProtection.ISecret masterKey) { }
        internal Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorConfiguration Configuration { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.ISecret MasterKey { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo ExportToXml() { throw null; }
    }
    public sealed partial class CngCbcAuthenticatedEncryptorDescriptorDeserializer : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer
    {
        public CngCbcAuthenticatedEncryptorDescriptorDeserializer() { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor ImportFromXml(System.Xml.Linq.XElement element) { throw null; }
    }
    public sealed partial class CngGcmAuthenticatedEncryptorConfiguration : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration
    {
        public CngGcmAuthenticatedEncryptorConfiguration() { }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string EncryptionAlgorithm { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public int EncryptionAlgorithmKeySize { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public string EncryptionAlgorithmProvider { get { throw null; } set { } }
        public override Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateNewDescriptor() { throw null; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.CreateDescriptorFromSecret(Microsoft.AspNetCore.DataProtection.ISecret secret) { throw null; }
        void Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.Validate() { }
    }
    public sealed partial class CngGcmAuthenticatedEncryptorDescriptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor
    {
        public CngGcmAuthenticatedEncryptorDescriptor(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngGcmAuthenticatedEncryptorConfiguration configuration, Microsoft.AspNetCore.DataProtection.ISecret masterKey) { }
        internal Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngGcmAuthenticatedEncryptorConfiguration Configuration { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.ISecret MasterKey { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo ExportToXml() { throw null; }
    }
    public sealed partial class CngGcmAuthenticatedEncryptorDescriptorDeserializer : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer
    {
        public CngGcmAuthenticatedEncryptorDescriptorDeserializer() { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor ImportFromXml(System.Xml.Linq.XElement element) { throw null; }
    }
    public partial interface IAuthenticatedEncryptorDescriptor
    {
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo ExportToXml();
    }
    public partial interface IAuthenticatedEncryptorDescriptorDeserializer
    {
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor ImportFromXml(System.Xml.Linq.XElement element);
    }
    internal partial interface IInternalAlgorithmConfiguration
    {
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateDescriptorFromSecret(Microsoft.AspNetCore.DataProtection.ISecret secret);
        void Validate();
    }
    public sealed partial class ManagedAuthenticatedEncryptorConfiguration : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration
    {
        public ManagedAuthenticatedEncryptorConfiguration() { }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public int EncryptionAlgorithmKeySize { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public System.Type EncryptionAlgorithmType { get { throw null; } set { } }
        [Microsoft.AspNetCore.DataProtection.ApplyPolicyAttribute]
        public System.Type ValidationAlgorithmType { get { throw null; } set { } }
        public override Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor CreateNewDescriptor() { throw null; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.CreateDescriptorFromSecret(Microsoft.AspNetCore.DataProtection.ISecret secret) { throw null; }
        void Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IInternalAlgorithmConfiguration.Validate() { }
    }
    public sealed partial class ManagedAuthenticatedEncryptorDescriptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor
    {
        public ManagedAuthenticatedEncryptorDescriptor(Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorConfiguration configuration, Microsoft.AspNetCore.DataProtection.ISecret masterKey) { }
        internal Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorConfiguration Configuration { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.ISecret MasterKey { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo ExportToXml() { throw null; }
    }
    public sealed partial class ManagedAuthenticatedEncryptorDescriptorDeserializer : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer
    {
        public ManagedAuthenticatedEncryptorDescriptorDeserializer() { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor ImportFromXml(System.Xml.Linq.XElement element) { throw null; }
    }
    internal static partial class SecretExtensions
    {
        public static System.Xml.Linq.XElement ToMasterKeyElement(this Microsoft.AspNetCore.DataProtection.ISecret secret) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.Secret ToSecret(this string base64String) { throw null; }
    }
    public static partial class XmlExtensions
    {
        internal static bool IsMarkedAsRequiringEncryption(this System.Xml.Linq.XElement element) { throw null; }
        public static void MarkAsRequiresEncryption(this System.Xml.Linq.XElement element) { }
    }
    public sealed partial class XmlSerializedDescriptorInfo
    {
        public XmlSerializedDescriptorInfo(System.Xml.Linq.XElement serializedDescriptorElement, System.Type deserializerType) { }
        public System.Type DeserializerType { get { throw null; } }
        public System.Xml.Linq.XElement SerializedDescriptorElement { get { throw null; } }
    }
}
namespace Microsoft.AspNetCore.DataProtection.Cng
{
    internal sealed partial class BCryptGenRandomImpl : Microsoft.AspNetCore.DataProtection.Cng.IBCryptGenRandom
    {
        private BCryptGenRandomImpl() { }
        public static readonly Microsoft.AspNetCore.DataProtection.Cng.BCryptGenRandomImpl Instance;
        public unsafe void GenRandom(byte* pbBuffer, uint cbBuffer) { }
    }
    internal sealed partial class CbcAuthenticatedEncryptor : Microsoft.AspNetCore.DataProtection.Cng.Internal.CngAuthenticatedEncryptorBase
    {
        public CbcAuthenticatedEncryptor(Microsoft.AspNetCore.DataProtection.Secret keyDerivationKey, Microsoft.AspNetCore.Cryptography.SafeHandles.BCryptAlgorithmHandle symmetricAlgorithmHandle, uint symmetricAlgorithmKeySizeInBytes, Microsoft.AspNetCore.Cryptography.SafeHandles.BCryptAlgorithmHandle hmacAlgorithmHandle, Microsoft.AspNetCore.DataProtection.Cng.IBCryptGenRandom genRandom = null) { }
        protected unsafe override byte[] DecryptImpl(byte* pbCiphertext, uint cbCiphertext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData) { throw null; }
        public override void Dispose() { }
        protected unsafe override byte[] EncryptImpl(byte* pbPlaintext, uint cbPlaintext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData, uint cbPreBuffer, uint cbPostBuffer) { throw null; }
    }
    internal static partial class DpapiSecretSerializerHelper
    {
        public static bool CanProtectToCurrentUserAccount() { throw null; }
        public static string GetRuleFromDpapiNGProtectedPayload(byte[] protectedData) { throw null; }
        public static byte[] ProtectWithDpapi(Microsoft.AspNetCore.DataProtection.ISecret secret, bool protectToLocalMachine = false) { throw null; }
        internal unsafe static byte[] ProtectWithDpapiCore(byte* pbSecret, uint cbSecret, byte* pbOptionalEntropy, uint cbOptionalEntropy, bool fLocalMachine = false) { throw null; }
        public static byte[] ProtectWithDpapiNG(Microsoft.AspNetCore.DataProtection.ISecret secret, Microsoft.AspNetCore.Cryptography.SafeHandles.NCryptDescriptorHandle protectionDescriptorHandle) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.Secret UnprotectWithDpapi(byte[] protectedSecret) { throw null; }
        internal unsafe static Microsoft.AspNetCore.DataProtection.Secret UnprotectWithDpapiCore(byte* pbProtectedData, uint cbProtectedData, byte* pbOptionalEntropy, uint cbOptionalEntropy) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.Secret UnprotectWithDpapiNG(byte[] protectedData) { throw null; }
    }
    internal sealed partial class GcmAuthenticatedEncryptor : Microsoft.AspNetCore.DataProtection.Cng.Internal.CngAuthenticatedEncryptorBase
    {
        public GcmAuthenticatedEncryptor(Microsoft.AspNetCore.DataProtection.Secret keyDerivationKey, Microsoft.AspNetCore.Cryptography.SafeHandles.BCryptAlgorithmHandle symmetricAlgorithmHandle, uint symmetricAlgorithmKeySizeInBytes, Microsoft.AspNetCore.DataProtection.Cng.IBCryptGenRandom genRandom = null) { }
        protected unsafe override byte[] DecryptImpl(byte* pbCiphertext, uint cbCiphertext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData) { throw null; }
        public override void Dispose() { }
        protected unsafe override byte[] EncryptImpl(byte* pbPlaintext, uint cbPlaintext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData, uint cbPreBuffer, uint cbPostBuffer) { throw null; }
    }
    internal partial interface IBCryptGenRandom
    {
        unsafe void GenRandom(byte* pbBuffer, uint cbBuffer);
    }
}
namespace Microsoft.AspNetCore.DataProtection.Cng.Internal
{
    internal abstract partial class CngAuthenticatedEncryptorBase : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IOptimizedAuthenticatedEncryptor, System.IDisposable
    {
        protected CngAuthenticatedEncryptorBase() { }
        public byte[] Decrypt(System.ArraySegment<byte> ciphertext, System.ArraySegment<byte> additionalAuthenticatedData) { throw null; }
        protected unsafe abstract byte[] DecryptImpl(byte* pbCiphertext, uint cbCiphertext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData);
        public abstract void Dispose();
        public byte[] Encrypt(System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData) { throw null; }
        public byte[] Encrypt(System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData, uint preBufferSize, uint postBufferSize) { throw null; }
        protected unsafe abstract byte[] EncryptImpl(byte* pbPlaintext, uint cbPlaintext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData, uint cbPreBuffer, uint cbPostBuffer);
    }
}
namespace Microsoft.AspNetCore.DataProtection.Internal
{
    internal static partial class ContainerUtils
    {
        public static bool IsContainer { get { throw null; } }
        internal static bool IsDirectoryMounted(System.IO.DirectoryInfo directory, System.Collections.Generic.IEnumerable<string> fstab) { throw null; }
        public static bool IsVolumeMountedFolder(System.IO.DirectoryInfo directory) { throw null; }
    }
    internal partial class DataProtectionBuilder : Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder
    {
        public DataProtectionBuilder(Microsoft.Extensions.DependencyInjection.IServiceCollection services) { }
        public Microsoft.Extensions.DependencyInjection.IServiceCollection Services { get { throw null; } }
    }
    internal partial class DataProtectionHostedService : Microsoft.Extensions.Hosting.IHostedService
    {
        public DataProtectionHostedService(Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRingProvider keyRingProvider) { }
        public DataProtectionHostedService(Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRingProvider keyRingProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken token) { throw null; }
        public System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken token) { throw null; }
    }
    internal partial class DataProtectionOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.DataProtection.DataProtectionOptions>
    {
        public DataProtectionOptionsSetup(System.IServiceProvider provider) { }
        public void Configure(Microsoft.AspNetCore.DataProtection.DataProtectionOptions options) { }
    }
    internal partial class HostingApplicationDiscriminator : Microsoft.AspNetCore.DataProtection.Infrastructure.IApplicationDiscriminator
    {
        public HostingApplicationDiscriminator() { }
        public HostingApplicationDiscriminator(Microsoft.Extensions.Hosting.IHostEnvironment hosting) { }
        public string Discriminator { get { throw null; } }
    }
    public partial interface IActivator
    {
        object CreateInstance(System.Type expectedBaseType, string implementationTypeName);
    }
    internal partial class KeyManagementOptionsSetup : Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions>
    {
        public KeyManagementOptionsSetup() { }
        public KeyManagementOptionsSetup(Microsoft.AspNetCore.DataProtection.IRegistryPolicyResolver registryPolicyResolver) { }
        public KeyManagementOptionsSetup(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public KeyManagementOptionsSetup(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.DataProtection.IRegistryPolicyResolver registryPolicyResolver) { }
        public void Configure(Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions options) { }
    }
}
namespace Microsoft.AspNetCore.DataProtection.KeyManagement
{
    internal sealed partial class DefaultKeyResolver : Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IDefaultKeyResolver
    {
        public DefaultKeyResolver(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions) { }
        public DefaultKeyResolver(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.DefaultKeyResolution ResolveDefaultKeyPolicy(System.DateTimeOffset now, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> allKeys) { throw null; }
    }
    internal sealed partial class DeferredKey : Microsoft.AspNetCore.DataProtection.KeyManagement.KeyBase
    {
        public DeferredKey(System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager keyManager, System.Xml.Linq.XElement keyElement, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory> encryptorFactories) : base (default(System.Guid), default(System.DateTimeOffset), default(System.DateTimeOffset), default(System.DateTimeOffset), default(System.Lazy<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor>), default(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory>)) { }
    }
    public partial interface IKey
    {
        System.DateTimeOffset ActivationDate { get; }
        System.DateTimeOffset CreationDate { get; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Descriptor { get; }
        System.DateTimeOffset ExpirationDate { get; }
        bool IsRevoked { get; }
        System.Guid KeyId { get; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptor();
    }
    public partial interface IKeyEscrowSink
    {
        void Store(System.Guid keyId, System.Xml.Linq.XElement element);
    }
    public partial interface IKeyManager
    {
        Microsoft.AspNetCore.DataProtection.KeyManagement.IKey CreateNewKey(System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate);
        System.Collections.Generic.IReadOnlyCollection<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> GetAllKeys();
        System.Threading.CancellationToken GetCacheExpirationToken();
        void RevokeAllKeys(System.DateTimeOffset revocationDate, string reason = null);
        void RevokeKey(System.Guid keyId, string reason = null);
    }
    internal sealed partial class Key : Microsoft.AspNetCore.DataProtection.KeyManagement.KeyBase
    {
        public Key(System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate, Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor descriptor, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory> encryptorFactories) : base (default(System.Guid), default(System.DateTimeOffset), default(System.DateTimeOffset), default(System.DateTimeOffset), default(System.Lazy<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor>), default(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory>)) { }
    }
    internal abstract partial class KeyBase : Microsoft.AspNetCore.DataProtection.KeyManagement.IKey
    {
        public KeyBase(System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate, System.Lazy<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor> lazyDescriptor, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory> encryptorFactories) { }
        public System.DateTimeOffset ActivationDate { get { throw null; } }
        public System.DateTimeOffset CreationDate { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Descriptor { get { throw null; } }
        public System.DateTimeOffset ExpirationDate { get { throw null; } }
        public bool IsRevoked { get { throw null; } }
        public System.Guid KeyId { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor CreateEncryptor() { throw null; }
        internal void SetRevoked() { }
    }
    internal static partial class KeyEscrowServiceProviderExtensions
    {
        public static Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink GetKeyEscrowSink(this System.IServiceProvider services) { throw null; }
    }
    internal static partial class KeyExtensions
    {
        public static bool IsExpired(this Microsoft.AspNetCore.DataProtection.KeyManagement.IKey key, System.DateTimeOffset now) { throw null; }
    }
    public partial class KeyManagementOptions
    {
        public KeyManagementOptions() { }
        internal KeyManagementOptions(Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions other) { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AlgorithmConfiguration AuthenticatedEncryptorConfiguration { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory> AuthenticatedEncryptorFactories { get { throw null; } }
        public bool AutoGenerateKeys { get { throw null; } set { } }
        public System.Collections.Generic.IList<Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyEscrowSink> KeyEscrowSinks { get { throw null; } }
        internal System.TimeSpan KeyPropagationWindow { get { throw null; } }
        internal System.TimeSpan KeyRingRefreshPeriod { get { throw null; } }
        internal System.TimeSpan MaxServerClockSkew { get { throw null; } }
        public System.TimeSpan NewKeyLifetime { get { throw null; } set { } }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor XmlEncryptor { get { throw null; } set { } }
        public Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository XmlRepository { get { throw null; } set { } }
    }
    internal sealed partial class KeyRing : Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing
    {
        public KeyRing(Microsoft.AspNetCore.DataProtection.KeyManagement.IKey defaultKey, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> allKeys) { }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor DefaultAuthenticatedEncryptor { get { throw null; } }
        public System.Guid DefaultKeyId { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor GetAuthenticatedEncryptorByKeyId(System.Guid keyId, out bool isRevoked) { throw null; }
    }
    internal sealed partial class KeyRingBasedDataProtectionProvider : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider
    {
        public KeyRingBasedDataProtectionProvider(Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRingProvider keyRingProvider, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(string purpose) { throw null; }
    }
    internal sealed partial class KeyRingBasedDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider, Microsoft.AspNetCore.DataProtection.IDataProtector, Microsoft.AspNetCore.DataProtection.IPersistedDataProtector
    {
        public KeyRingBasedDataProtector(Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRingProvider keyRingProvider, Microsoft.Extensions.Logging.ILogger logger, string[] originalPurposes, string newPurpose) { }
        internal string[] Purposes { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.IDataProtector CreateProtector(string purpose) { throw null; }
        public byte[] DangerousUnprotect(byte[] protectedData, bool ignoreRevocationErrors, out bool requiresMigration, out bool wasRevoked) { throw null; }
        public byte[] Protect(byte[] plaintext) { throw null; }
        public byte[] Unprotect(byte[] protectedData) { throw null; }
    }
    internal sealed partial class KeyRingProvider : Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.ICacheableKeyRingProvider, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRingProvider
    {
        public KeyRingProvider(Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyManager keyManager, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IDefaultKeyResolver defaultKeyResolver) { }
        public KeyRingProvider(Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyManager keyManager, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IDefaultKeyResolver defaultKeyResolver, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal System.DateTime AutoRefreshWindowEnd { get { throw null; } set { } }
        internal Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.ICacheableKeyRingProvider CacheableKeyRingProvider { get { throw null; } set { } }
        public Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing GetCurrentKeyRing() { throw null; }
        internal Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing GetCurrentKeyRingCore(System.DateTime utcNow, bool forceRefresh = false) { throw null; }
        internal bool InAutoRefreshWindow() { throw null; }
        Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.CacheableKeyRing Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.ICacheableKeyRingProvider.GetCacheableKeyRing(System.DateTimeOffset now) { throw null; }
        internal Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing RefreshCurrentKeyRing() { throw null; }
    }
    public sealed partial class XmlKeyManager : Microsoft.AspNetCore.DataProtection.KeyManagement.IKeyManager, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager
    {
        internal static readonly System.Xml.Linq.XName ActivationDateElementName;
        internal static readonly System.Xml.Linq.XName CreationDateElementName;
        internal static readonly System.Xml.Linq.XName DescriptorElementName;
        internal static readonly System.Xml.Linq.XName DeserializerTypeAttributeName;
        internal static readonly System.Xml.Linq.XName ExpirationDateElementName;
        internal static readonly System.Xml.Linq.XName IdAttributeName;
        internal static readonly System.Xml.Linq.XName KeyElementName;
        internal static readonly System.Xml.Linq.XName ReasonElementName;
        internal static readonly System.Xml.Linq.XName RevocationDateElementName;
        internal static readonly System.Xml.Linq.XName RevocationElementName;
        internal static readonly System.Xml.Linq.XName VersionAttributeName;
        public XmlKeyManager(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator) { }
        public XmlKeyManager(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        internal XmlKeyManager(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager internalXmlKeyManager) { }
        internal XmlKeyManager(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.KeyManagement.KeyManagementOptions> keyManagementOptions, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.DataProtection.Repositories.IDefaultKeyStorageDirectories keyStorageDirectories) { }
        internal Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor KeyEncryptor { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository KeyRepository { get { throw null; } }
        public Microsoft.AspNetCore.DataProtection.KeyManagement.IKey CreateNewKey(System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate) { throw null; }
        public System.Collections.Generic.IReadOnlyCollection<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> GetAllKeys() { throw null; }
        public System.Threading.CancellationToken GetCacheExpirationToken() { throw null; }
        internal System.Collections.Generic.KeyValuePair<Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository, Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor> GetFallbackKeyRepositoryEncryptorPair() { throw null; }
        Microsoft.AspNetCore.DataProtection.KeyManagement.IKey Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager.CreateNewKey(System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate) { throw null; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager.DeserializeDescriptorFromKeyElement(System.Xml.Linq.XElement keyElement) { throw null; }
        void Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IInternalXmlKeyManager.RevokeSingleKey(System.Guid keyId, System.DateTimeOffset revocationDate, string reason) { }
        public void RevokeAllKeys(System.DateTimeOffset revocationDate, string reason = null) { }
        public void RevokeKey(System.Guid keyId, string reason = null) { }
    }
}
namespace Microsoft.AspNetCore.DataProtection.KeyManagement.Internal
{
    public sealed partial class CacheableKeyRing
    {
        internal CacheableKeyRing(System.Threading.CancellationToken expirationToken, System.DateTimeOffset expirationTime, Microsoft.AspNetCore.DataProtection.KeyManagement.IKey defaultKey, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> allKeys) { }
        internal CacheableKeyRing(System.Threading.CancellationToken expirationToken, System.DateTimeOffset expirationTime, Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing keyRing) { }
        internal System.DateTime ExpirationTimeUtc { get { throw null; } }
        internal Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing KeyRing { get { throw null; } }
        internal static bool IsValid(Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.CacheableKeyRing keyRing, System.DateTime utcNow) { throw null; }
        internal Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.CacheableKeyRing WithTemporaryExtendedLifetime(System.DateTimeOffset now) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DefaultKeyResolution
    {
        public Microsoft.AspNetCore.DataProtection.KeyManagement.IKey DefaultKey;
        public Microsoft.AspNetCore.DataProtection.KeyManagement.IKey FallbackKey;
        public bool ShouldGenerateNewKey;
    }
    public partial interface ICacheableKeyRingProvider
    {
        Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.CacheableKeyRing GetCacheableKeyRing(System.DateTimeOffset now);
    }
    public partial interface IDefaultKeyResolver
    {
        Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.DefaultKeyResolution ResolveDefaultKeyPolicy(System.DateTimeOffset now, System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.DataProtection.KeyManagement.IKey> allKeys);
    }
    public partial interface IInternalXmlKeyManager
    {
        Microsoft.AspNetCore.DataProtection.KeyManagement.IKey CreateNewKey(System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate);
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor DeserializeDescriptorFromKeyElement(System.Xml.Linq.XElement keyElement);
        void RevokeSingleKey(System.Guid keyId, System.DateTimeOffset revocationDate, string reason);
    }
    public partial interface IKeyRing
    {
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor DefaultAuthenticatedEncryptor { get; }
        System.Guid DefaultKeyId { get; }
        Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor GetAuthenticatedEncryptorByKeyId(System.Guid keyId, out bool isRevoked);
    }
    public partial interface IKeyRingProvider
    {
        Microsoft.AspNetCore.DataProtection.KeyManagement.Internal.IKeyRing GetCurrentKeyRing();
    }
}
namespace Microsoft.AspNetCore.DataProtection.Managed
{
    internal static partial class HashAlgorithmExtensions
    {
        public static int GetDigestSizeInBytes(this System.Security.Cryptography.HashAlgorithm hashAlgorithm) { throw null; }
    }
    internal partial interface IManagedGenRandom
    {
        byte[] GenRandom(int numBytes);
    }
    internal sealed partial class ManagedAuthenticatedEncryptor : Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor, System.IDisposable
    {
        public ManagedAuthenticatedEncryptor(Microsoft.AspNetCore.DataProtection.Secret keyDerivationKey, System.Func<System.Security.Cryptography.SymmetricAlgorithm> symmetricAlgorithmFactory, int symmetricAlgorithmKeySizeInBytes, System.Func<System.Security.Cryptography.KeyedHashAlgorithm> validationAlgorithmFactory, Microsoft.AspNetCore.DataProtection.Managed.IManagedGenRandom genRandom = null) { }
        public byte[] Decrypt(System.ArraySegment<byte> protectedPayload, System.ArraySegment<byte> additionalAuthenticatedData) { throw null; }
        public void Dispose() { }
        public byte[] Encrypt(System.ArraySegment<byte> plaintext, System.ArraySegment<byte> additionalAuthenticatedData) { throw null; }
    }
    internal sealed partial class ManagedGenRandomImpl : Microsoft.AspNetCore.DataProtection.Managed.IManagedGenRandom
    {
        private ManagedGenRandomImpl() { }
        public static readonly Microsoft.AspNetCore.DataProtection.Managed.ManagedGenRandomImpl Instance;
        public byte[] GenRandom(int numBytes) { throw null; }
    }
    internal static partial class SymmetricAlgorithmExtensions
    {
        public static int GetBlockSizeInBytes(this System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { throw null; }
    }
}
namespace Microsoft.AspNetCore.DataProtection.Repositories
{
    internal sealed partial class DefaultKeyStorageDirectories : Microsoft.AspNetCore.DataProtection.Repositories.IDefaultKeyStorageDirectories
    {
        private DefaultKeyStorageDirectories() { }
        public static Microsoft.AspNetCore.DataProtection.Repositories.IDefaultKeyStorageDirectories Instance { get { throw null; } }
        public System.IO.DirectoryInfo GetKeyStorageDirectory() { throw null; }
        public System.IO.DirectoryInfo GetKeyStorageDirectoryForAzureWebSites() { throw null; }
    }
    internal partial class EphemeralXmlRepository : Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository
    {
        public EphemeralXmlRepository(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public virtual System.Collections.Generic.IReadOnlyCollection<System.Xml.Linq.XElement> GetAllElements() { throw null; }
        public virtual void StoreElement(System.Xml.Linq.XElement element, string friendlyName) { }
    }
    public partial class FileSystemXmlRepository : Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository
    {
        public FileSystemXmlRepository(System.IO.DirectoryInfo directory, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public static System.IO.DirectoryInfo DefaultKeyStorageDirectory { get { throw null; } }
        public System.IO.DirectoryInfo Directory { get { throw null; } }
        public virtual System.Collections.Generic.IReadOnlyCollection<System.Xml.Linq.XElement> GetAllElements() { throw null; }
        public virtual void StoreElement(System.Xml.Linq.XElement element, string friendlyName) { }
    }
    internal partial interface IDefaultKeyStorageDirectories
    {
        System.IO.DirectoryInfo GetKeyStorageDirectory();
        System.IO.DirectoryInfo GetKeyStorageDirectoryForAzureWebSites();
    }
    public partial interface IXmlRepository
    {
        System.Collections.Generic.IReadOnlyCollection<System.Xml.Linq.XElement> GetAllElements();
        void StoreElement(System.Xml.Linq.XElement element, string friendlyName);
    }
    public partial class RegistryXmlRepository : Microsoft.AspNetCore.DataProtection.Repositories.IXmlRepository
    {
        public RegistryXmlRepository(Microsoft.Win32.RegistryKey registryKey, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public static Microsoft.Win32.RegistryKey DefaultRegistryKey { get { throw null; } }
        public Microsoft.Win32.RegistryKey RegistryKey { get { throw null; } }
        public virtual System.Collections.Generic.IReadOnlyCollection<System.Xml.Linq.XElement> GetAllElements() { throw null; }
        public virtual void StoreElement(System.Xml.Linq.XElement element, string friendlyName) { }
    }
}
namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
    internal partial interface ISP800_108_CTR_HMACSHA512Provider : System.IDisposable
    {
        unsafe void DeriveKey(byte* pbLabel, uint cbLabel, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey);
    }
    internal static partial class ManagedSP800_108_CTR_HMACSHA512
    {
        public static void DeriveKeys(byte[] kdk, System.ArraySegment<byte> label, System.ArraySegment<byte> context, System.Func<byte[], System.Security.Cryptography.HashAlgorithm> prfFactory, System.ArraySegment<byte> output) { }
        public static void DeriveKeysWithContextHeader(byte[] kdk, System.ArraySegment<byte> label, byte[] contextHeader, System.ArraySegment<byte> context, System.Func<byte[], System.Security.Cryptography.HashAlgorithm> prfFactory, System.ArraySegment<byte> output) { }
    }
    internal static partial class SP800_108_CTR_HMACSHA512Extensions
    {
        public unsafe static void DeriveKeyWithContextHeader(this Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider provider, byte* pbLabel, uint cbLabel, byte[] contextHeader, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey) { }
    }
    internal static partial class SP800_108_CTR_HMACSHA512Util
    {
        public static Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider CreateEmptyProvider() { throw null; }
        public static Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider CreateProvider(Microsoft.AspNetCore.DataProtection.Secret kdk) { throw null; }
        public unsafe static Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider CreateProvider(byte* pbKdk, uint cbKdk) { throw null; }
    }
    internal sealed partial class Win7SP800_108_CTR_HMACSHA512Provider : Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider, System.IDisposable
    {
        public unsafe Win7SP800_108_CTR_HMACSHA512Provider(byte* pbKdk, uint cbKdk) { }
        public unsafe void DeriveKey(byte* pbLabel, uint cbLabel, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey) { }
        public void Dispose() { }
    }
    internal sealed partial class Win8SP800_108_CTR_HMACSHA512Provider : Microsoft.AspNetCore.DataProtection.SP800_108.ISP800_108_CTR_HMACSHA512Provider, System.IDisposable
    {
        public unsafe Win8SP800_108_CTR_HMACSHA512Provider(byte* pbKdk, uint cbKdk) { }
        public unsafe void DeriveKey(byte* pbLabel, uint cbLabel, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey) { }
        public void Dispose() { }
    }
}
namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
    public partial class CertificateResolver : Microsoft.AspNetCore.DataProtection.XmlEncryption.ICertificateResolver
    {
        public CertificateResolver() { }
        public virtual System.Security.Cryptography.X509Certificates.X509Certificate2 ResolveCertificate(string thumbprint) { throw null; }
    }
    public sealed partial class CertificateXmlEncryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IInternalCertificateXmlEncryptor, Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor
    {
        internal CertificateXmlEncryptor(Microsoft.Extensions.Logging.ILoggerFactory loggerFactory, Microsoft.AspNetCore.DataProtection.XmlEncryption.IInternalCertificateXmlEncryptor encryptor) { }
        public CertificateXmlEncryptor(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public CertificateXmlEncryptor(string thumbprint, Microsoft.AspNetCore.DataProtection.XmlEncryption.ICertificateResolver certificateResolver, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement) { throw null; }
        System.Security.Cryptography.Xml.EncryptedData Microsoft.AspNetCore.DataProtection.XmlEncryption.IInternalCertificateXmlEncryptor.PerformEncryption(System.Security.Cryptography.Xml.EncryptedXml encryptedXml, System.Xml.XmlElement elementToEncrypt) { throw null; }
    }
    [System.FlagsAttribute]
    public enum DpapiNGProtectionDescriptorFlags
    {
        None = 0,
        NamedDescriptor = 1,
        MachineKey = 32,
    }
    public sealed partial class DpapiNGXmlDecryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor
    {
        public DpapiNGXmlDecryptor() { }
        public DpapiNGXmlDecryptor(System.IServiceProvider services) { }
        public System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement) { throw null; }
    }
    public sealed partial class DpapiNGXmlEncryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor
    {
        public DpapiNGXmlEncryptor(string protectionDescriptorRule, Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiNGProtectionDescriptorFlags flags, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement) { throw null; }
        internal static string GetDefaultProtectionDescriptorString() { throw null; }
    }
    public sealed partial class DpapiXmlDecryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor
    {
        public DpapiXmlDecryptor() { }
        public DpapiXmlDecryptor(System.IServiceProvider services) { }
        public System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement) { throw null; }
    }
    public sealed partial class DpapiXmlEncryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor
    {
        public DpapiXmlEncryptor(bool protectToLocalMachine, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory) { }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement) { throw null; }
    }
    public sealed partial class EncryptedXmlDecryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IInternalEncryptedXmlDecryptor, Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor
    {
        public EncryptedXmlDecryptor() { }
        public EncryptedXmlDecryptor(System.IServiceProvider services) { }
        public System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement) { throw null; }
        void Microsoft.AspNetCore.DataProtection.XmlEncryption.IInternalEncryptedXmlDecryptor.PerformPreDecryptionSetup(System.Security.Cryptography.Xml.EncryptedXml encryptedXml) { }
    }
    public sealed partial class EncryptedXmlInfo
    {
        public EncryptedXmlInfo(System.Xml.Linq.XElement encryptedElement, System.Type decryptorType) { }
        public System.Type DecryptorType { get { throw null; } }
        public System.Xml.Linq.XElement EncryptedElement { get { throw null; } }
    }
    public partial interface ICertificateResolver
    {
        System.Security.Cryptography.X509Certificates.X509Certificate2 ResolveCertificate(string thumbprint);
    }
    internal partial interface IInternalCertificateXmlEncryptor
    {
        System.Security.Cryptography.Xml.EncryptedData PerformEncryption(System.Security.Cryptography.Xml.EncryptedXml encryptedXml, System.Xml.XmlElement elementToEncrypt);
    }
    internal partial interface IInternalEncryptedXmlDecryptor
    {
        void PerformPreDecryptionSetup(System.Security.Cryptography.Xml.EncryptedXml encryptedXml);
    }
    public partial interface IXmlDecryptor
    {
        System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement);
    }
    public partial interface IXmlEncryptor
    {
        Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement);
    }
    public sealed partial class NullXmlDecryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor
    {
        public NullXmlDecryptor() { }
        public System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement) { throw null; }
    }
    public sealed partial class NullXmlEncryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor
    {
        public NullXmlEncryptor() { }
        public NullXmlEncryptor(System.IServiceProvider services) { }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement) { throw null; }
    }
    internal static partial class XmlEncryptionExtensions
    {
        public static System.Xml.Linq.XElement DecryptElement(this System.Xml.Linq.XElement element, Microsoft.AspNetCore.DataProtection.Internal.IActivator activator) { throw null; }
        public static System.Xml.Linq.XElement EncryptIfNecessary(this Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor encryptor, System.Xml.Linq.XElement element) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.Secret ToSecret(this System.Xml.Linq.XElement element) { throw null; }
        public static System.Xml.Linq.XElement ToXElement(this Microsoft.AspNetCore.DataProtection.Secret secret) { throw null; }
    }
    internal partial class XmlKeyDecryptionOptions
    {
        public XmlKeyDecryptionOptions() { }
        public int KeyDecryptionCertificateCount { get { throw null; } }
        public void AddKeyDecryptionCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public bool TryGetKeyDecryptionCertificates(System.Security.Cryptography.X509Certificates.X509Certificate2 certInfo, out System.Collections.Generic.IReadOnlyList<System.Security.Cryptography.X509Certificates.X509Certificate2> keyDecryptionCerts) { throw null; }
    }
}
namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class DataProtectionServiceCollectionExtensions
    {
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddDataProtection(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) { throw null; }
        public static Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder AddDataProtection(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Microsoft.AspNetCore.DataProtection.DataProtectionOptions> setupAction) { throw null; }
    }
}
namespace Microsoft.Extensions.Logging
{
    internal static partial class LoggingExtensions
    {
        public static void AnErrorOccurredWhileEncryptingToX509CertificateWithThumbprint(this Microsoft.Extensions.Logging.ILogger logger, string thumbprint, System.Exception exception) { }
        public static void AnExceptionOccurredWhileProcessingElementDebug(this Microsoft.Extensions.Logging.ILogger logger, System.Xml.Linq.XElement keyElement, System.Exception exception) { }
        public static void ConsideringKeyWithExpirationDateAsDefaultKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, System.DateTimeOffset expirationDate) { }
        public static void CreatingKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, System.DateTimeOffset creationDate, System.DateTimeOffset activationDate, System.DateTimeOffset expirationDate) { }
        public static void DecryptingSecretElementUsingWindowsDPAPI(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void DecryptingSecretElementUsingWindowsDPAPING(this Microsoft.Extensions.Logging.ILogger logger, string protectionDescriptorRule) { }
        public static void DefaultKeyExpirationImminentAndRepository(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void DescriptorDeserializerTypeForKeyIs(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, string assemblyQualifiedName) { }
        public static void EncryptingToWindowsDPAPIForCurrentUserAccount(this Microsoft.Extensions.Logging.ILogger logger, string name) { }
        public static void EncryptingToWindowsDPAPIForLocalMachineAccount(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void EncryptingToWindowsDPAPINGUsingProtectionDescriptorRule(this Microsoft.Extensions.Logging.ILogger logger, string protectionDescriptorRuleString) { }
        public static void EncryptingToX509CertificateWithThumbprint(this Microsoft.Extensions.Logging.ILogger logger, string thumbprint) { }
        public static void EncryptingUsingNullEncryptor(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ErrorOccurredWhileEncryptingToWindowsDPAPI(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ErrorOccurredWhileEncryptingToWindowsDPAPING(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ErrorOccurredWhileReadingKeyRing(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ErrorOccurredWhileRefreshingKeyRing(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ExceptionOccurredTryingToDecryptElement(this Microsoft.Extensions.Logging.ILogger logger, System.Exception exception) { }
        public static void ExceptionWhileProcessingKeyElement(this Microsoft.Extensions.Logging.ILogger logger, System.Xml.Linq.XElement keyElement, System.Exception exception) { }
        public static void ExceptionWhileProcessingRevocationElement(this Microsoft.Extensions.Logging.ILogger logger, System.Xml.Linq.XElement revocationElement, System.Exception exception) { }
        public static void ExceptionWhileTryingToResolveCertificateWithThumbprint(this Microsoft.Extensions.Logging.ILogger logger, string thumbprint, System.Exception exception) { }
        public static void ExistingCachedKeyRingIsExpired(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void FoundKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void FoundRevocationOfAllKeysCreatedPriorTo(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset massRevocationDate) { }
        public static void FoundRevocationOfKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsDebugLevelEnabled(this Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsErrorLevelEnabled(this Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsInformationLevelEnabled(this Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsTraceLevelEnabled(this Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]public static bool IsWarningLevelEnabled(this Microsoft.Extensions.Logging.ILogger logger) { throw null; }
        public static void KeyCacheExpirationTokenTriggeredByOperation(this Microsoft.Extensions.Logging.ILogger logger, string opName) { }
        public static void KeyEscrowSinkFoundWritingKeyToEscrow(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void KeyIsIneligibleToBeTheDefaultKeyBecauseItsMethodFailed(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, string p0, System.Exception exception) { }
        public static void KeyIsNoLongerUnderConsiderationAsDefault(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void KeyRingDoesNotContainValidDefaultKey(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void KeyRingFailedToLoadOnStartup(this Microsoft.Extensions.Logging.ILogger logger, System.Exception innerException) { }
        public static void KeyRingWasLoadedOnStartup(this Microsoft.Extensions.Logging.ILogger logger, System.Guid defaultKeyId) { }
        public static void KeyWasNotFoundInTheKeyRingUnprotectOperationCannotProceed(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyIdFromPayload) { }
        public static void KeyWasRevokedCallerRequestedUnprotectOperationProceedRegardless(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyIdFromPayload) { }
        public static void KeyWasRevokedUnprotectOperationCannotProceed(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyIdFromPayload) { }
        public static void MarkedKeyAsRevokedInTheKeyring(this Microsoft.Extensions.Logging.ILogger logger, System.Guid revokedKeyId) { }
        public static void NameIsNotSafeFileName(this Microsoft.Extensions.Logging.ILogger logger, string friendlyName, string newFriendlyName) { }
        public static void NameIsNotSafeRegistryValueName(this Microsoft.Extensions.Logging.ILogger logger, string friendlyName, string newFriendlyName) { }
        public static void NoKeyEscrowSinkFoundNotWritingKeyToEscrow(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void NoXMLEncryptorConfiguredKeyMayBePersistedToStorageInUnencryptedForm(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void OpeningCNGAlgorithmFromProviderWithChainingModeCBC(this Microsoft.Extensions.Logging.ILogger logger, string encryptionAlgorithm, string encryptionAlgorithmProvider) { }
        public static void OpeningCNGAlgorithmFromProviderWithChainingModeGCM(this Microsoft.Extensions.Logging.ILogger logger, string encryptionAlgorithm, string encryptionAlgorithmProvider) { }
        public static void OpeningCNGAlgorithmFromProviderWithHMAC(this Microsoft.Extensions.Logging.ILogger logger, string hashAlgorithm, string hashAlgorithmProvider) { }
        public static void PerformingProtectOperationToKeyWithPurposes(this Microsoft.Extensions.Logging.ILogger logger, System.Guid defaultKeyId, string p0) { }
        public static void PerformingUnprotectOperationToKeyWithPurposes(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyIdFromPayload, string p0) { }
        public static void PolicyResolutionStatesThatANewKeyShouldBeAddedToTheKeyRing(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void ReadingDataFromFile(this Microsoft.Extensions.Logging.ILogger logger, string fullPath) { }
        public static void ReadingDataFromRegistryKeyValue(this Microsoft.Extensions.Logging.ILogger logger, Microsoft.Win32.RegistryKey regKey, string valueName) { }
        public static void RepositoryContainsNoViableDefaultKey(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void RevokingAllKeysAsOfForReason(this Microsoft.Extensions.Logging.ILogger logger, System.DateTimeOffset revocationDate, string reason) { }
        public static void RevokingKeyForReason(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, System.DateTimeOffset revocationDate, string reason) { }
        public static void TriedToProcessRevocationOfKeyButNoSuchKeyWasFound(this Microsoft.Extensions.Logging.ILogger logger, System.Guid revokedKeyId) { }
        public static void UnknownElementWithNameFoundInKeyringSkipping(this Microsoft.Extensions.Logging.ILogger logger, System.Xml.Linq.XName name) { }
        public static void UsingAzureAsKeyRepository(this Microsoft.Extensions.Logging.ILogger logger, string fullName) { }
        public static void UsingEphemeralDataProtectionProvider(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UsingEphemeralFileSystemLocationInContainer(this Microsoft.Extensions.Logging.ILogger logger, string path) { }
        public static void UsingEphemeralKeyRepository(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UsingFallbackKeyWithExpirationAsDefaultKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId, System.DateTimeOffset expirationDate) { }
        public static void UsingInmemoryRepository(this Microsoft.Extensions.Logging.ILogger logger) { }
        public static void UsingKeyAsDefaultKey(this Microsoft.Extensions.Logging.ILogger logger, System.Guid keyId) { }
        public static void UsingManagedKeyedHashAlgorithm(this Microsoft.Extensions.Logging.ILogger logger, string fullName) { }
        public static void UsingManagedSymmetricAlgorithm(this Microsoft.Extensions.Logging.ILogger logger, string fullName) { }
        public static void UsingProfileAsKeyRepository(this Microsoft.Extensions.Logging.ILogger logger, string fullName) { }
        public static void UsingProfileAsKeyRepositoryWithDPAPI(this Microsoft.Extensions.Logging.ILogger logger, string fullName) { }
        public static void UsingRegistryAsKeyRepositoryWithDPAPI(this Microsoft.Extensions.Logging.ILogger logger, string name) { }
        public static void WritingDataToFile(this Microsoft.Extensions.Logging.ILogger logger, string finalFilename) { }
    }
}
namespace System
{
    internal static partial class LoggingServiceProviderExtensions
    {
        public static Microsoft.Extensions.Logging.ILogger GetLogger(this System.IServiceProvider services, System.Type type) { throw null; }
        public static Microsoft.Extensions.Logging.ILogger GetLogger<T>(this System.IServiceProvider services) { throw null; }
    }
}
