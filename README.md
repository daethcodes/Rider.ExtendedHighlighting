# ExtendedHighlighting for Rider

[![Rider](https://img.shields.io/jetbrains/plugin/v/34700-extendedhighlighting.svg?label=Rider&colorB=0A7BBB&style=for-the-badge&logo=rider)](https://plugins.jetbrains.com/plugin/34700-extendedhighlighting)

Adds syntax highlighting for C# operators that Rider does not support by default.

These are treated as symbols without any real semantics i.e. it will override all uses of the symbol
so setting a highlighting for <code>!</code> will apply to all occurrences.

All highlightings default to the colour for operators from the user's current settings, but they can be individually set.

The list of configurable symbols includes:
<ul>
  <li><code>?</code></li>
  <li><code>??</code></li>
  <li><code>??=</code></li>
  <li><code>:</code></li>
  <li><code>!</code></li>
  <li><code>=></code></li>
</ul>

### Development

This project was bootstrapped using the 
[JetBrains ReSharper Rider plugin template](https://github.com/JetBrains/resharper-rider-plugin), but has been modified 
to remove the standalone ReSharper build. For details on building and debugging the plugin refer to the template
repository.