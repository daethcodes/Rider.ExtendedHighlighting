using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;

namespace ReSharperPlugin.ExtendedHighlighting;

public abstract class ExtendedHighlightingBase(DocumentRange documentRange) : IHighlighting
{
    public DocumentRange CalculateRange() => documentRange;

    public bool IsValid() => true;

    string IHighlighting.ToolTip => null;

    string IHighlighting.ErrorStripeToolTip => null;
}