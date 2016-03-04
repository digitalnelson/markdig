﻿using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using Textamina.Markdig.Parsers;

namespace Textamina.Markdig.Tests
{
    [TestFixture]
    public class TestPlayParser
    {
        [Test]
        public void TestSimple()
        {
            var text = @"```info {#test .class src=tata src2='toto'}
This is a test
```
";

            //            var reader = new StringReader(@"> > toto tata
            //> titi toto
            //");

            //var result = Markdown.ConvertToHtml(text, new MarkdownPipeline().UseFootnoteExtensions().UseStrikethroughSuperAndSubScript());
            var result = Markdown.ConvertToHtml(text, new MarkdownPipeline().UseAttributes());
            //File.WriteAllText("test.html", result, Encoding.UTF8);
            Console.WriteLine(result);
        }
   }
}