﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
//
namespace Microsoft.Extensions.Configuration.AzureAppConfiguration
{
    internal static class LogHelper
    {
        public static string BuildKeyValueReadMessage(KeyValueChangeType changeType, string key, string label, string endpoint)
        {
            return $"{LoggingConstants.RefreshKeyValueRead} Change:'{changeType}' Key:'{key}' Label:'{label}' Endpoint:'{endpoint.TrimEnd('/')}'";
        }

        public static string BuildKeyValueSettingUpdatedMessage(string key)
        {
            return $"{LoggingConstants.RefreshKeyValueSettingUpdated} Key:'{key}'";
        }

        public static string BuildConfigurationUpdatedMessage()
        {
            return LoggingConstants.RefreshConfigurationUpdatedSuccess;
        }

        public static string BuildFeatureFlagsUnchangedMessage(string endpoint)
        {
            return $"{LoggingConstants.RefreshFeatureFlagsUnchanged} Endpoint:'{endpoint.TrimEnd('/')}'";
        }

        public static string BuildFeatureFlagReadMessage(string key, string label, string endpoint)
        {
            return $"{LoggingConstants.RefreshFeatureFlagRead} Key:'{key}' Label:'{label}' Endpoint:'{endpoint.TrimEnd('/')}'";
        }

        public static string BuildFeatureFlagUpdatedMessage(string key)
        {
            return $"{LoggingConstants.RefreshFeatureFlagUpdated} Key:'{key}'";
        }

        public static string BuildKeyVaultSecretReadMessage(string key, string label)
        {
            return $"{LoggingConstants.RefreshKeyVaultSecretRead} Key:'{key}' Label:'{label}'";
        }

        public static string BuildKeyVaultSettingUpdatedMessage(string key)
        {
            return $"{LoggingConstants.RefreshKeyVaultSettingUpdated} Key:'{key}'";
        }

        public static string BuildRefreshSkippedNoClientAvailableMessage()
        {
            return LoggingConstants.RefreshSkippedNoClientAvailable;
        }

        public static string BuildRefreshFailedDueToAuthenticationErrorMessage(string exceptionMessage)
        {
            return $"{LoggingConstants.RefreshFailedDueToAuthenticationError}\n{exceptionMessage}";
        }

        public static string BuildRefreshFailedErrorMessage(string exceptionMessage)
        {
            return $"{LoggingConstants.RefreshFailedError}\n{exceptionMessage}";
        }

        public static string BuildRefreshFailedDueToKeyVaultErrorMessage(string exceptionMessage)
        {
            return $"{LoggingConstants.RefreshFailedDueToKeyVaultError}\n{exceptionMessage}";
        }

        public static string BuildRefreshCanceledErrorMessage()
        {
            return LoggingConstants.RefreshCanceledError;
        }

        public static string BuildPushNotificationUnregisteredEndpointMessage(string resourceUri)
        {
            return $"{LoggingConstants.PushNotificationUnregisteredEndpoint} '{resourceUri}'.";
        }

        public static string QuerySrvDnsFailedErrorMessage(string exceptionMessage)
        {
            return $"{LoggingConstants.QuerySrvDnsFailedError}\n{exceptionMessage}";
        }

        public static string FailoverDnsLookupToTcp(string exceptionMessage)
        {
            return $"{LoggingConstants.FailoverDnsLookupToTcpMessage}\n{exceptionMessage}";
        }

        public static string AutoFailoverClientCount(int count)
        {
            return $"{LoggingConstants.AutoFailoverClientCount}: {count}";
        }
    }
}
