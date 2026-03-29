/*
order: 20
title: Deployments
slug: deployments

Retrieve and inspect model deployments and their status.
*/

namespace Baseten.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetModelDeployments()
    {
        using var client = GetAuthenticatedClient();

        //// First, list models to get a model ID:
        var models = await client.GetModelsAsync();
        if (models.Models.Count == 0)
        {
            Assert.Inconclusive("No models deployed.");
            return;
        }

        var modelId = models.Models[0].Id;

        //// Get all deployments for a model:
        var deployments = await client.GetModelsByModelIdDeploymentsAsync(
            modelId: modelId);

        deployments.Should().NotBeNull();
        deployments.Deployments.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_GetProductionDeployment()
    {
        using var client = GetAuthenticatedClient();

        var models = await client.GetModelsAsync();
        var model = models.Models.FirstOrDefault(m => m.ProductionDeploymentId is not null);
        if (model is null)
        {
            Assert.Inconclusive("No model with production deployment found.");
            return;
        }

        //// Get the production deployment details:
        var deployment = await client.GetModelsByModelIdDeploymentsProductionAsync(
            modelId: model.Id);

        deployment.Should().NotBeNull();
        deployment.Id.Should().NotBeNullOrEmpty();
    }
}
