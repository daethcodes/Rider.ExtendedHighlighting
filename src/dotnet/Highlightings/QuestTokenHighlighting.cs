using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon.Attributes;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ExtendedHighlighting.Highlightings;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(QuestTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighter(
    nameof(QuestTokenHighlighting),
    RiderPresentableName = "Single Question Mark",
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    FallbackAttributeId = DefaultLanguageAttributeIds.OPERATOR_SIGN,
    Layer = Constants.Layer)]
public class QuestTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range)
{
    public const string Tag = "q";
}
