# RichTextBoxEx

An improved RichTextBox for Windows Forms (C#) which exposes additional features using native Win32 RichEdit APIs and TOM (Text Object Model):

### Features

* Properties which apply to selection or caret insertion point:
    - **SelectionFontFamily**, **SelectionFontSize**, **SelectionIsBold**, **SelectionIsItalic**, **SelectionIsStrikethrough**: get/set formatting options indipendently from one another. When you use the built-in SelectionFont property instead, you can't set sub-properties unless you initialize a new font, causing that if the selection contains multiple fonts or styles they are uniformed to one.
    - **SelectionUnderlineStyle**: get/set underline style (none, single, double, wavy, dashed, dotted)
    - **SelectionUnderlineColor**: get/set underline color (same as text color by default; enum-based since only a subset of colors is supported by the native control for underline)
    - **SelectionScriptStyle**: get/set normal/superscript/subscript style
    - **SelectionCapStyle**: get/set normal/all caps/small caps style
    - **SelectionFontStretch**: get/set spacing between characters 
    - **SelectionShadow**: enable/disable shadow effect for characters
    - **SelectionListType**: get/set list type (none, bullets, numbers, letters, roman numbers)
    - **SelectionListBulletChar**: get/set the char to use for bulleted list items
    - **SelectionListNumberStyle**: get/set style for numbered list items (plain number or number and dot/right parenthesis/double parenthesis)
    - **SelectionListStartingNumber**: get/set starting number for numbered list items (1 by default). This allows to e.g. restart numbering at a specific list entry.
    - **SelectionBulletTextDistance**: get/set bullet-text distance for list items in points. This is recommended instead of the built-in BulletIndent property, which uses an API that can create ambiguity with SelectionHangingIndent.
    - **SelectionParagraphSpaceBefore**: get/set space before paragraphs in points
    - **SelectionParagraphSpaceAfter**: get/set space after paragraphs in points
    - **SelectionLineSpacing**: get/set spacing between lines contained in the same paragraph.
        - Single line spacing:
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new SingleLineSpacing();
        ```
        - One-and-a-half spacing:
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new OneAndHalfLineSpacing();
        ```
        - Double line spacing:
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new DoubleLineSpacing();
        ```
        - Exact line spacing (in points):
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new ExactLineSpacing(12);
        ```
        - Minimum line spacing (in points, but the control displays single-spaced text if value is less than single spacing):
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new MinimumLineSpacing(12);
        ```
        - Multiple line spacing (in number of lines):
        ```csharp
        richTextBoxEx1.SelectionLineSpacing = new MultipleLineSpacing(1.5);
        ```
        - Check existing line spacing:
        ```csharp
        switch (richTextBoxEx1.SelectionLineSpacing)
        {
            case SingleLineSpacing singleLineSpacing:                
                break;
            case OneAndHalfLineSpacing oneAndHalfLineSpacing:
                break;
            case DoubleLineSpacing doubleLineSpacing:
                break;
            case ExactLineSpacing exactLineSpacing:
                var exactValue = exactLineSpacing.Value;
                break;
            case MinimumLineSpacing minimumLineSpacing:
                var value = exactLineSpacing.Value;
                break;
            case MultipleLineSpacing multipleLineSpacing:
                var lines = multipleLineSpacing.Value;
                break;
        }
        ```
    - **SelectionHyperlinkUrl**: get/set URL for a "friendly" hyperlink which can have any display text. Setting this property to an empty string removes the hyperlink. AutoDetectUrl should be set on false when using RichTextBoxEx.
    - **SelectionHyperlinkDisplayText**: get/set the display text for the hyperlink contained in the current selection or insertion point. The selected range is automatically expanded if only part of the hyperlink is selected.
* Default properties:
    - **DefaultIndent**, **DefaultRightIndent**, **DefaultHangingIndent**, **DefaultParagraphSpaceBefore**, **DefaultParagraphSpaceAfter** and **DefaultLineSpacing**: same as above, but affect all paragraphs that do not have formatting set explicitly. Note: even when using properties starting with "Selection\*" new paragraphs (and list items) usually inherit formatting of the preceding paragraph (or list item), this is the default behavior in most word processors.
* Read-only properties:
    - **VisibleText** and **SelectedVisibleText**: retrieve text without hidden text or RTF code (useful for hyperlinks).
* Additional features:
    - **InsertImage**: inserts an image from file path, steam, byte array or System.Drawing.Image object without using the clipboard
    - **InsertTable**: inserts a table with the specified number of rows and columns
    - **RequireCtrlForLinkClick**: get/set if the LinkClicked event and the hand cursor for links should only be triggered when Ctrl is pressed (Microsoft Word behavior)
    - **IsSpellCheckEnabled**: enable/disable spell check on the native RichEdit control (uses the current keyboard language)
    - **PrintDocument**: this property allows to set a PrintDocument object to print the RichTextBox content considering printer options and page setup; can be used with PrintDialog, PrintPreviewDialog and PageSetupDialog at application level
    - resize cursor is displayed on images and table rows/columns borders

A simple rich text editor based on RichTextBoxEx is also available as sample project.

### Breaking changes

Compared to the default RichTextBox:
- **SelectionBullet** and **BulletIndent** are still available but considered deprecated. SelectionListType and SelectionBulletTextDistance should be used instead. 
- **SelectionIndent**, **SelectionRightIndent**, **SelectionHangingIndent** are in typographic points (1/72 of an inch) rather than pixels which are device-dependent.  
SelectionHangingIndent can be set to both positive and negative values to indent / outdent the second and subsequent lines relative to the first paragraph line, while only positive values seem to work in the default RichTextBox.  

Note: the built-in SelectionTabs property is still in pixels.  
You can convert pixels to points and back using this formulas:
```
dpi = richTextBox.ControlDpi;
px = (pt * dpi) / 72
pt = (px * 72) / dpi
```

### Requirements

Windows 10 or 11 is recommended, as some features have been introduced in recent RichEdit versions.  
Involved APIs are marked with a SupportedOS attribute, so that you will get a warning when using those and building for a .NET version that can run on an earlier Windows version.