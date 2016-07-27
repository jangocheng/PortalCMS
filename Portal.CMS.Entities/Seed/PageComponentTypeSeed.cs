﻿using Portal.CMS.Entities.Entities.PageBuilder;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public static class PageComponentTypeSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            var componentList = context.PageComponentTypes.ToList();

            var newComponents = new List<PageComponentType>();

            if (!componentList.Any(x => x.PageComponentTypeName == "<p>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<p>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Single Paragraph Element.", PageComponentBody = "<p id=\"component-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<h1>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<h1>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Large Title Text Element.", PageComponentBody = "<h1 id=\"component-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<h2>"))

                newComponents.Add(new PageComponentType { PageComponentTypeName = "<h2>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Large Title Text Element", PageComponentBody = "<h2 id=\"component-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h2>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<h3>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<h3>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Title Text Element", PageComponentBody = "<h3 id=\"component-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h3>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<h4>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<h4>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Title Text Element", PageComponentBody = "<h4 id=\"component-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<a>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<a>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Link to Another Page", PageComponentBody = "<a id=\"component-<componentStamp>-<sectionId>\" href=\"#\">Click me to find out more.</a>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<btn>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<btn>", PageComponentTypeCategory = PageComponentTypeCategory.Markup, PageComponentTypeDescription = "Button Link to Another Page", PageComponentBody = "<a id=\"component-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn\">Click me to find out more.</a>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<img> (Circle)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<img> (Circle)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Small Circular Image", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"image image-circle\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<img> (Square)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<img> (Square)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Small Square Image", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"image image-square\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<img> (Icon)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<img> (Icon)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Tiny Square Image", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"image image-icon\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<img> (Standard)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<img> (Standard)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Standard Rectangular Image", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"image image-standard\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<img> (Flex)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<img> (Flex)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Image That Flexes To Native Size", PageComponentBody = "<img id=\"component-<componentStamp>-<sectionId>\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/small-sample-1.jpg\">" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Table"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Table", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Empty Table Element", PageComponentBody = "<table id=\"component-<componentStamp>-<sectionId>\" class=\"component-container\"></table>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (1 Header)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (1 Header)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 1 Header Cell", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"component-<componentStamp>-<sectionId>\" class=\"component-container\"></th></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (2 Headers)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (2 Headers)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 2 Header Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></th></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (3 Headers)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (3 Headers)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 3 Header Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></th></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (4 Headers)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (4 Headers)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 4 Header Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-4-<componentStamp>-<sectionId>\" class=\"component-container\"></th></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (5 Headers)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (5 Headers)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 5 Header Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-4-<componentStamp>-<sectionId>\" class=\"component-container\"></th><th id=\"column-5-<componentStamp>-<sectionId>\" class=\"component-container\"></th></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (1 Column)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (1 Column)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 1 Cell", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"component-<componentStamp>-<sectionId>\" class=\"component-container\"></td></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (2 Columns)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (2 Columns)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 2 Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></td></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (3 Columns)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (3 Columns)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 3 Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></td></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (4 Columns)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (4 Columns)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 4 Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-4-<componentStamp>-<sectionId>\" class=\"component-container\"></td></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row (5 Columns)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row (5 Columns)", PageComponentTypeCategory = PageComponentTypeCategory.Table, PageComponentTypeDescription = "Table Row with 5 Cells", PageComponentBody = "<tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-3-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-4-<componentStamp>-<sectionId>\" class=\"component-container\"></td><td id=\"column-5-<componentStamp>-<sectionId>\" class=\"component-container\"></td></tr>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Container"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Container", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Container", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"container component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Row"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Row", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Row", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"row component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<col-lg-2>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<col-lg-2>", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Column", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 col-lg-2 component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<col-md-3>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<col-md-3>", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Column", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-3 component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<col-md-4>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<col-md-4>", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Column", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<col-md-6>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<col-md-6>", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Column", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "<col-md-12>"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "<col-md-12>", PageComponentTypeCategory = PageComponentTypeCategory.Bootstrap, PageComponentTypeDescription = "Empty Bootstrap Column", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"col-xs-12 component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Overlay (Light)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Overlay (Light)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Light Absolute Overlay", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"overlay overlay-light component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Overlay (Medium)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Overlay (Medium)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Medium Absolute Overlay", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"overlay overlay-medium component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Overlay (Dark)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Overlay (Dark)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Dark Absolute Overlay", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"overlay overlay-dark component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Container (Vertical)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Container (Vertical)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Vertically Alligned Container", PageComponentBody = "<div id=\"component-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Glass Border (Top)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Glass Border (Top)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Vertically Alligned Container", PageComponentBody = "<div id=\"glass-top-<containerId>-<sectionId>\" class=\"glass glass-top\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Glass Border (Left)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Glass Border (Left)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Vertically Alligned Container", PageComponentBody = "<div id=\"glass-left-<containerId>-<sectionId>\" class=\"glass glass-left\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Glass Border (Right)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Glass Border (Right)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Vertically Alligned Container", PageComponentBody = "<div id=\"glass-right-<containerId>-<sectionId>\" class=\"glass glass-right\"></div>" });

            if (!componentList.Any(x => x.PageComponentTypeName == "Glass Border (Bottom)"))
                newComponents.Add(new PageComponentType { PageComponentTypeName = "Glass Border (Bottom)", PageComponentTypeCategory = PageComponentTypeCategory.Control, PageComponentTypeDescription = "Vertically Alligned Container", PageComponentBody = "<div id=\"glass-bottom-<containerId>-<sectionId>\" class=\"glass glass-bottom\"></div>" });

            if (newComponents.Any())
                context.PageComponentTypes.AddRange(newComponents);
        }
    }
}