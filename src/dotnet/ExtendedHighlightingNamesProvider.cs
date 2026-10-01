using System;
using ExtendedHighlighting.Highlightings;
using JetBrains.TextControl.DocumentMarkup;

namespace ExtendedHighlighting;

public class ExtendedHighlightingNamesProvider : IRiderHighlighterNamesProvider
{
    public string GetHighlighterTag(string attributeId)
    {
        return attributeId switch
        {
            nameof(QuestTokenHighlighting) => QuestTokenHighlighting.Tag,
            nameof(DoubleQuestTokenHighlighting) => DoubleQuestTokenHighlighting.Tag,
            nameof(DoubleQuestEqTokenHighlighting) => DoubleQuestEqTokenHighlighting.Tag,
            nameof(ExclTokenHighlighting) => ExclTokenHighlighting.Tag,
            nameof(LambdaArrowTokenHighlighting) => LambdaArrowTokenHighlighting.Tag,
            nameof(ColonTokenHighlighting) => ColonTokenHighlighting.Tag,
            _ => throw new ArgumentOutOfRangeException(nameof(attributeId), attributeId, null)
        };
    }

    public string GetExternalName(string attributeId) => $"{Constants.GroupId}.{attributeId}";

    // Already providing the presentable names via the RegisterHighlighter attributes
    public string GetPresentableName(string attributeId) => attributeId;
}