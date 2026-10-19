using ADLDecisionTool.Models;

namespace ADLDecisionTool.Services;

public class DecisionService
{
    private readonly List<ADL> _adls;

    public DecisionService(List<ADL> adls)
    {
        _adls = adls;
    }

    public DecisionResult GetDecision(DecisionRequest request)
    {
        bool hasSystemType = !string.IsNullOrWhiteSpace(request.SystemType);
        bool hasDomain = !string.IsNullOrWhiteSpace(request.Domain);

        List<Recommendation> recommendations;
        string rule;
        string ruleDescription; 

        if (hasSystemType && hasDomain)
        {
            recommendations = ApplyTypeAndDomainRule(request);

            var byType = _adls
                .Where(adl => adl.SystemTypes.Contains(request.SystemType))
                .ToList();

            var byDomain = _adls
                .Where(adl => adl.Domains.Contains(request.Domain))
                .ToList();

            var intersection = byType
                .Intersect(byDomain)
                .Count();

            if (intersection > 0)
            {
                rule = "R4";
                ruleDescription = "Tipo de sistema + dominio con intersección. Se evaluó la unión de ambos conjuntos y se dio prioridad a los ADLs pertenecientes a la intersección.";
            }
            else
            {
                rule = "R5";
                ruleDescription = "Tipo de sistema + dominio sin intersección. Se evaluó la unión de ambos conjuntos sin prioridad por intersección.";
            }
        }
        else if (hasSystemType)
        {
            recommendations = ApplySystemTypeRule(request);

            rule = "R1";
            ruleDescription = "Solo se especificó el tipo de sistema. Se evaluaron los ADLs asociados al tipo seleccionado.";
        }
        else if (hasDomain)
        {
            recommendations = ApplyDomainRule(request);

            rule = "R2";
            ruleDescription = "Solo se especificó el dominio. Se evaluaron los ADLs asociados al dominio seleccionado.";
        }
        else
        {
            recommendations = ApplyCharacteristicsRule(
                request,
                _adls,
                new HashSet<ADL>());

            rule = "R3";
            ruleDescription = "No se especificó tipo de sistema ni dominio. Se evaluaron todos los ADLs disponibles.";
        }

        var typeCandidates = hasSystemType
            ? _adls.Count(adl => adl.SystemTypes.Contains(request.SystemType))
            : 0;

        var domainCandidates = hasDomain
            ? _adls.Count(adl => adl.Domains.Contains(request.Domain))
            : 0;

        var intersectionCount = hasSystemType && hasDomain
            ? _adls
                .Where(adl => adl.SystemTypes.Contains(request.SystemType))
                .Intersect(
                    _adls.Where(adl => adl.Domains.Contains(request.Domain)))
                .Count()
            : 0;

        return new DecisionResult
        {
            Recommendations = recommendations,

            Summary = new DecisionSummary
            {
                Rule = rule,
                RuleDescription = ruleDescription,
                CandidateCount = recommendations.Count,
                SelectedCharacteristicsCount = request.Characteristics.Count,
                TypeCandidateCount = typeCandidates,
                DomainCandidateCount = domainCandidates,
                IntersectionCount = intersectionCount,
                SystemType = request.SystemType,
                Domain = request.Domain
            }
        };
    }

    private List<Recommendation> ApplySystemTypeRule(DecisionRequest request)
    {
        var candidates = _adls
            .Where(adl => adl.SystemTypes.Contains(request.SystemType))
            .ToList();

        return ApplyCharacteristicsRule(request, candidates, new HashSet<ADL>());
    }

    private List<Recommendation> ApplyDomainRule(DecisionRequest request)
    {
        var candidates = _adls
            .Where(adl => adl.Domains.Contains(request.Domain))
            .ToList();

        return ApplyCharacteristicsRule(request, candidates, new HashSet<ADL>());
    }

    private List<Recommendation> ApplyTypeAndDomainRule(DecisionRequest request)
    {
        var byType = _adls
            .Where(adl => adl.SystemTypes.Contains(request.SystemType))
            .ToList();

        var byDomain = _adls
            .Where(adl => adl.Domains.Contains(request.Domain))
            .ToList();

        var candidates = byType
            .Union(byDomain)
            .ToList();

        var intersection = byType
            .Intersect(byDomain)
            .ToHashSet();

        return ApplyCharacteristicsRule(request, candidates, intersection);
    }

    private List<Recommendation> ApplyCharacteristicsRule(
        DecisionRequest request,
        List<ADL> candidates,
        HashSet<ADL> intersection)
    {
        if (request.Characteristics.Count == 0)
        {
            return candidates
                .Select(adl => new Recommendation
                {
                    ADL = adl,
                    Score = 0,
                    IsIntersection = intersection.Contains(adl)
                })
                .OrderByDescending(result => result.IsIntersection)
                .ToList();
        }

        double weight = 1.0 / request.Characteristics.Count;

        return candidates
            .Select(adl =>
            {
                var matchingCharacteristics = request.Characteristics
                    .Where(characteristic =>
                        adl.Characteristics.Contains(characteristic))
                    .ToList();

                return new Recommendation
                {
                    ADL = adl,
                    Score = matchingCharacteristics.Count * weight,
                    MatchingCharacteristics = matchingCharacteristics,
                    IsIntersection = intersection.Contains(adl)
                };
            })
            .OrderByDescending(result => result.IsIntersection)
            .ThenByDescending(result => result.Score)
            .ToList();
    }
}