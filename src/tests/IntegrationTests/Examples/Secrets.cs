/*
order: 30
title: Secrets
slug: secrets

List workspace secrets.
*/

namespace Baseten.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListSecrets()
    {
        using var client = GetAuthenticatedClient();

        //// List all secrets in the workspace (values are never returned):
        var response = await client.GetSecretsAsync();

        response.Should().NotBeNull();
        response.Secrets.Should().NotBeNull();
    }
}
