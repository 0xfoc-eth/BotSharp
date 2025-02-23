using BotSharp.Abstraction.Agents.Models;
using BotSharp.Abstraction.Functions.Models;
using BotSharp.Abstraction.Routing.Models;

namespace BotSharp.OpenAPI.ViewModels.Agents;

public class AgentViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Instruction { get; set; }
    public List<AgentTemplate> Templates { get; set; }
    public List<FunctionDef> Functions { get; set; }
    public List<AgentResponse> Responses { get; set; }
    public List<string> Samples { get; set; }
    public bool IsPublic { get; set; }
    public bool AllowRouting { get; set; }
    public bool Disabled { get; set; }
    public List<string> Profiles { get; set; }
    public List<RoutingRule> RoutingRules { get; set; }

    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }

    public static AgentViewModel FromAgent(Agent agent)
    {
        return new AgentViewModel
        {
            Id = agent.Id,
            Name = agent.Name,
            Description = agent.Description,
            Instruction = agent.Instruction,
            Templates = agent.Templates,
            Functions = agent.Functions,
            Responses = agent.Responses,
            Samples = agent.Samples,
            IsPublic= agent.IsPublic,
            Disabled = agent.Disabled,
            AllowRouting = agent.AllowRouting,
            Profiles = agent.Profiles,
            RoutingRules = agent.RoutingRules,
            CreatedDateTime = agent.CreatedDateTime,
            UpdatedDateTime = agent.UpdatedDateTime
        };
    }
}
