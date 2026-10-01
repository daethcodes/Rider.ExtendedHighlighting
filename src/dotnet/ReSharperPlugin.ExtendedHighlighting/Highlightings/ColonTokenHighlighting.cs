using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon.Attributes;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ReSharperPlugin.ExtendedHighlighting.QuestOperator;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(ColonTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighter(
    nameof(ColonTokenHighlighting),
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    FallbackAttributeId = DefaultLanguageAttributeIds.OPERATOR_SIGN,
    Layer = Constants.Layer)]
public class ColonTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range);
