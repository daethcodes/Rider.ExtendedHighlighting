using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon.Attributes;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ReSharperPlugin.ExtendedHighlighting.Highlightings;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(ExclTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighter(
    nameof(ExclTokenHighlighting),
    RiderPresentableName = "Null-forgiving",
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    FallbackAttributeId = DefaultLanguageAttributeIds.OPERATOR_SIGN,
    Layer = Constants.Layer)]
public class ExclTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range)
{
    public const string Tag = "excl";
}
