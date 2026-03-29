/* order: 40, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Baseten.IntegrationTests;

public partial class Tests
{
    //// Baseten provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// model management, deployment status, and secrets on the Baseten platform.

    [TestMethod]
    public async Task Meai_AsListModelsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists all deployed models:
        var tool = client.AsListModelsTool();

        tool.Name.Should().Be("BasetenListModels");
        tool.Description.Should().Contain("Baseten");
    }

    [TestMethod]
    public async Task Meai_AsGetModelTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that gets a specific model by ID:
        var tool = client.AsGetModelTool();

        tool.Name.Should().Be("BasetenGetModel");
        tool.Description.Should().Contain("model");
    }

    [TestMethod]
    public async Task Meai_AsGetDeploymentStatusTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that checks production deployment status:
        var tool = client.AsGetDeploymentStatusTool();

        tool.Name.Should().Be("BasetenGetDeploymentStatus");
        tool.Description.Should().Contain("deployment");
    }

    [TestMethod]
    public async Task Meai_AsListSecretsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists workspace secrets:
        var tool = client.AsListSecretsTool();

        tool.Name.Should().Be("BasetenListSecrets");
        tool.Description.Should().Contain("secrets");
    }
}
