// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PolicyInsights
{
    internal class AttestationOperationSource : IOperationSource<AttestationResource>
    {
        private readonly ArmClient _client;

        internal AttestationOperationSource(ArmClient client)
        {
            _client = client;
        }

        AttestationResource IOperationSource<AttestationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AttestationData.DeserializeAttestationData(document.RootElement);
            return new AttestationResource(_client, data);
        }

        async ValueTask<AttestationResource> IOperationSource<AttestationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AttestationData.DeserializeAttestationData(document.RootElement);
            return new AttestationResource(_client, data);
        }
    }
}
