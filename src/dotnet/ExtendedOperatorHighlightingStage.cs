using JetBrains.Application.Parts;
using JetBrains.Application.Settings;
using JetBrains.ReSharper.Feature.Services.CSharp.Daemon;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using ReSharperPlugin.ExtendedHighlighting.Highlightings;

namespace ReSharperPlugin.ExtendedHighlighting;

[DaemonStage(
    Instantiation.DemandAnyThreadSafe,
    StagesBefore = [typeof(GlobalFileStructureCollectorStage)],
    HighlightingTypes =
    [
        typeof(QuestTokenHighlighting),
        typeof(DoubleQuestTokenHighlighting),
        typeof(DoubleQuestEqTokenHighlighting),
        typeof(ExclTokenHighlighting),
        typeof(LambdaArrowTokenHighlighting),
        typeof(ColonTokenHighlighting)
    ])]
public class ExtendedOperatorHighlightingStage : CSharpDaemonStageBase
{
    protected override IDaemonStageProcess CreateProcess(
        IDaemonProcess process,
        IContextBoundSettingsStore settings,
        DaemonProcessKind processKind,
        ICSharpFile file) =>
        new ExtendedHighlightingProcess(process, settings, file);
}