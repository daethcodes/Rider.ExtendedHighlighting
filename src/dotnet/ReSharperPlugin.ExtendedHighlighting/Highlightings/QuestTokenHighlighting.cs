using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon.Attributes;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ReSharperPlugin.ExtendedHighlighting.QuestOperator;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(QuestTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighterGroup(
    Constants.GroupId,
    Constants.PresentableName,
    HighlighterGroupPriority.LANGUAGE_SETTINGS,
    Language = typeof(CSharpLanguage))]
[RegisterHighlighter(
    nameof(QuestTokenHighlighting),
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    FallbackAttributeId = DefaultLanguageAttributeIds.OPERATOR_SIGN,
    Layer = Constants.Layer)]
public class QuestTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range);
