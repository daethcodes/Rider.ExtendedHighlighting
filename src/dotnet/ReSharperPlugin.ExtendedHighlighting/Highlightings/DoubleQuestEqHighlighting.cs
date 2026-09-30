using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.TextControl.DocumentMarkup;

namespace ReSharperPlugin.ExtendedHighlighting.QuestOperator;

[StaticSeverityHighlighting(
    Severity.INFO,
    typeof(HighlightingGroupIds.IdentifierHighlightings),
    AttributeId = nameof(DoubleQuestEqTokenHighlighting),
    Languages = CSharpLanguage.Name,
    OverlapResolve = OverlapResolveKind.NONE)]
[RegisterHighlighter(
    nameof(DoubleQuestEqTokenHighlighting),
    GroupId = Constants.GroupId,
    EffectType = EffectType.TEXT,
    ForegroundColor = Constants.DefaultColor,
    DarkForegroundColor = Constants.DefaultColor,
    Layer = Constants.Layer)]
public class DoubleQuestEqTokenHighlighting(DocumentRange range) : ExtendedHighlightingBase(range);