// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A WebLinkedService that uses client certificate based authentication to communicate with an HTTP endpoint. This scheme follows mutual authentication; the server must also provide valid credentials to the client. </summary>
    public partial class WebClientCertificateAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebClientCertificateAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="password">
        /// Password for the PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/>, <paramref name="pfx"/> or <paramref name="password"/> is null. </exception>
        public WebClientCertificateAuthentication(BinaryData uri, FactorySecretBaseDefinition pfx, FactorySecretBaseDefinition password) : base(uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (pfx == null)
            {
                throw new ArgumentNullException(nameof(pfx));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Pfx = pfx;
            Password = password;
            AuthenticationType = WebAuthenticationType.ClientCertificate;
        }

        /// <summary> Initializes a new instance of WebClientCertificateAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="password">
        /// Password for the PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        internal WebClientCertificateAuthentication(BinaryData uri, WebAuthenticationType authenticationType, FactorySecretBaseDefinition pfx, FactorySecretBaseDefinition password) : base(uri, authenticationType)
        {
            Pfx = pfx;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary>
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Pfx { get; set; }
        /// <summary>
        /// Password for the PFX file.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
    }
}
