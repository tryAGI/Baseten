/*
order: 10
title: List Models
slug: list-models

Basic example showing how to list all deployed models.
*/

namespace Baseten.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        //// List all models deployed in the workspace:
        var response = await client.GetModelsAsync();

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
    }
}
