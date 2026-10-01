using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using JetBrains.Application.Settings;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Daemon.CSharp.Stages;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp.Parsing;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using ReSharperPlugin.ExtendedHighlighting.QuestOperator;

namespace ReSharperPlugin.ExtendedHighlighting;

public class ExtendedHighlightingProcess(
    IDaemonProcess process,
    IContextBoundSettingsStore settings,
    ICSharpFile file) : CSharpIncrementalDaemonStageProcessBase(process, settings, file)
{
    private static readonly FrozenDictionary<TokenNodeType, Func<DocumentRange, IHighlighting>> Highlightings =
        new Dictionary<TokenNodeType, Func<DocumentRange, IHighlighting>>
        {
            [CSharpTokenType.QUEST] = range => new QuestTokenHighlighting(range),
            [CSharpTokenType.DOUBLE_QUEST] = range => new DoubleQuestTokenHighlighting(range),
            [CSharpTokenType.DOUBLE_QUEST_EQ] = range => new DoubleQuestEqTokenHighlighting(range),
            [CSharpTokenType.LAMBDA_ARROW] = range => new LambdaArrowTokenHighlighting(range),
            [CSharpTokenType.EXCL] = range => new ExclArrowTokenHighlighting(range),
            [CSharpTokenType.COLON] = range => new ColonTokenHighlighting(range),
        }.ToFrozenDictionary();

    public override void VisitNode(ITreeNode element, IHighlightingConsumer consumer)
    {
        if (element is not ITokenNode token)
            return;

        var tokenType = token.GetTokenType();
        var range = token.GetDocumentRange();

        var highlighting = Highlightings.TryGetValue(tokenType, out var factory)
            ? factory(range)
            : null;

        if (highlighting is null)
            return;

        consumer.AddHighlighting(highlighting, range);
    }
}