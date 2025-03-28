namespace Podkrepibg.Campaigns.Application.Campaigns.Commands.CreateCampaign
{
    using System;
    using FluentValidation;

    public class CreateCampaignValidator : AbstractValidator<CreateCampaignCommand>
    {
        public CreateCampaignValidator()
        {
            RuleFor(c => c.Request.InitiatorId)
                .Must(id => Guid.TryParse(id, out var _))
                .WithMessage("not a valid guid provided");

            RuleFor(c => c.Request.OperatorId)
                .Must(id => Guid.TryParse(id, out var _))
                .WithMessage("not a valid guid provided");

            RuleFor(c => c.Request.Title).NotEmpty();

            RuleFor(c => c.Request.BeneficiaryId)
                .Must(id => Guid.TryParse(id, out var _))
                .WithMessage("not a valid guid provided");

            RuleFor(c => c.Request.CampaignTypeId)
                .Must(id => Guid.TryParse(id, out var _))
                .WithMessage("not a valid guid provided");
        }
    }
}
