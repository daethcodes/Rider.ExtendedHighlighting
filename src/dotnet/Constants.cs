using ExtendedHighlighting.Highlightings;
using JetBrains.TextControl.DocumentMarkup;

namespace ExtendedHighlighting;

public static class Constants
{
    public const string GroupId = "ExtendedHighlighting";

    public const HighlighterLayer Layer = HighlighterLayer.SYNTAX + 1;

    public const string DemoText =
        $"""
        var foo = bar <{Tags.Question}>?</{Tags.Question}> 1 <{Tags.Colon}>:</{Tags.Colon}> 0;
        foo = bar <{Tags.DoubleQuest}>??</{Tags.DoubleQuest}> 0;
        foo <{Tags.DoubleQuestEq}>??=</{Tags.DoubleQuestEq}> bar;
        foo = null<{Tags.Excl}>!</{Tags.Excl}>;
        foo = (bar) <{Tags.Lambda}>=></{Tags.Lambda}> 1;
        """;
    
    private static class Tags
    {
        public const string Question = QuestTokenHighlighting.Tag;
        public const string DoubleQuest = DoubleQuestTokenHighlighting.Tag;
        public const string DoubleQuestEq = DoubleQuestEqTokenHighlighting.Tag;
        public const string Excl = ExclTokenHighlighting.Tag;
        public const string Lambda = LambdaArrowTokenHighlighting.Tag;
        public const string Colon = ColonTokenHighlighting.Tag;
    }
}