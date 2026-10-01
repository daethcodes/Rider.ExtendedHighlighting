using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon.Attributes;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ReSharperPlugin.ExtendedHighlighting.Highlightings;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(LambdaArrowTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighter(
    nameof(LambdaArrowTokenHighlighting),
    RiderPresentableName = "Lambda Arrow",
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    FallbackAttributeId = DefaultLanguageAttributeIds.OPERATOR_SIGN,
    Layer = Constants.Layer)]
public class LambdaArrowTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range)
{
    public const string Tag = "arr";
}