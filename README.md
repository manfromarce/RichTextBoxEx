# RichTextBoxEx

An improved RichTextBox for Windows Forms (C#) which exposes additional features using native Win32 RichEdit APIs and TOM (Text Object Model):

* Additional properties which apply to the selection or caret insertion point:
	- **SelectionFontFamily**, **SelectionFontSize**, **SelectionIsBold**, **SelectionIsItalic**: get/set formatting options indipendently from one another. When you use the built-in SelectionFont property instead, you can't set sub-properties unless you initialize a new font, causing that if the selection contains multiple fonts or styles they are uniformed to one.
	- **SelectionTextAlignment**: get/set justified alignment in addition to left, right and center
	- **SelectionUnderlineStyle**: get/set underline style (none, single, double, wavy, dashed, dotted)
	- **SelectionStrikethroughStyle**: get/set strikethrough style (none, single, double)
	- **SelectionUnderlineColor**: get/set underline color (same as text color by default; enum-based since only a subset of colors is supported by the native control for underline)
	- **SelectionScriptStyle**: get/set normal/superscript/subscript style
	- **SelectionCapStyle**: get/set normal/all caps/small caps style
	- **SelectionFontStretch**: get/set spacing between characters 
	- **SelectionShadow**: enable/disable shadow effect for characters
	- **SelectionListType**: get/set list type (none, bullets, numbers, letters, roman numbers)
	- **SelectionListNumberStyle**: get/set style for numbered list items (plain number or number and dot/right parenthesis/double parenthesis)
	- **SelectionListStartingNumber**: get/set starting number for numbered list items (1 by default)
	- **SelectionBulletIndent**: get/set bullet indent for list items, in twips (1/1440 inches = 1/20 points)
	- **SelectionBulletTextDistance**: get/set bullet-text distance for list items, in twips
	- **SelectionParagraphSpaceBefore**: get/set space before paragraphs in twips
	- **SelectionParagraphSpaceAfter**: get/set space after paragraphs in twips
	- **SelectionLineSpacingRule** and **SelectionLineSpacing**: get/set line spacing
	- **SelectionHyperlinkUrl**: get/set URL for a "friendly" hyperlink which can have any display text. Setting this property to an empty string removes the hyperlink. AutoDetectUrl should be set on false when using RichTextBoxEx.
* Additional features:
	- **InsertImage**: inserts an image from file path or byte array without using the clipboard
	- **InsertTable**: inserts a table with the specified number of rows and columns
	- **RequireCtrlForLinkClick**: get/set if the LinkClicked event and the hand cursor for links should only be triggered when Ctrl is pressed (Microsoft Word behavior)
	- **IsSpellCheckEnabled**: enable/disable spell check on the native RichEdit control (uses the current keyboard language)
	- resize cursor is displayed on images and table rows/columns borders
	- **PrintDocument**: this property allows to set a PrintDocument object to print the RichTextBox content considering printer options and page setup; can be used with PrintDialog, PrintPreviewDialog and PageSetupDialog at application level

A simple rich text editor based on PrintRichTextBox is also available as a separate sample project.

### Requirements

Windows 10 or 11 is recommended, as some features have been introduced in recent RichEdit versions.  
Involved APIs are marked with a SupportedOS attribute, so that you will get a warning when using those and building for a .NET version that can run on an earlier Windows version.