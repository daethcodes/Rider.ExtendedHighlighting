# ExtendedHighlighting for Rider

[![Rider](https://img.shields.io/jetbrains/plugin/v/34700-extendedhighlighting.svg?label=Rider&colorB=0A7BBB&style=for-the-badge&logo=rider)](https://plugins.jetbrains.com/plugin/34700-extendedhighlighting)

A Rider plugin that adds syntax highlighting for C# operators that Rider does not support by default.

These are treated as symbols without any checks for semantics i.e. a highlighting will apply to all uses of the symbol
regardless of what it actually means in the code. 

For example setting a highlighting for <code>!</code> will apply to <strong>all</strong> occurrences of <code>!</code>
whether that be a negation operator or a null-forgiving operator.

All highlightings default to the colour for operators from the user's current settings, but they can be individually set.

The list of configurable symbols is:
<ul>
  <li><code>?</code></li>
  <li><code>??</code></li>
  <li><code>??=</code></li>
  <li><code>:</code></li>
  <li><code>!</code></li>
  <li><code>=></code></li>
</ul>

### Development

This project was generated using the
[JetBrains ReSharper Rider plugin template](https://github.com/JetBrains/resharper-rider-plugin), but has been modified 
to remove the standalone ReSharper build. 

For details on building and debugging the plugin refer to the template
repository.