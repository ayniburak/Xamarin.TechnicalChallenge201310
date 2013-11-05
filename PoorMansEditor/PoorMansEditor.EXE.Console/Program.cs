﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoorMansEditor.EXE.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = @"
.large
My First Document
.normal
.paragraph
This is my 
.italics
very first
.regular
document, and I am very proud that I am getting this on the string.   While this paragraph is not filled, the following one has automatic filling set:
.paragraph
.indent +2
.fill
Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
.nofill
.indent -2
Well, that was 
.bold
exciting
.regular
good luck!
";

			global::PoorMansEditor.Common.TextParser parser = null;
			parser = new global::PoorMansEditor.Common.TextParser();

			parser.PoorManEditorText2Html(text);

			return;

		
		}
	}
}