﻿using DocumentVisitorWithModification.DocumentElements;
using DocumentVisitorWithoutModification.Visitors;

namespace DocumentVisitorWithoutModification.DocumentElements
{
    public class Title : IDocumentElement
    {
        string Content;
        public Title(string content) 
        {
            Content = content;
        }
        public void Print()
        {
            Console.WriteLine($"Title with content: {Content}");
        }
        public void Accept(IVisitDocumentElement visitor)
        {
            visitor.Visit(this);
        }
    }
}
