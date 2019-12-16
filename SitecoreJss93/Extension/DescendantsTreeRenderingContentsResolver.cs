using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Specialized;

namespace SitecoreJss93
{
    public class DescendantsTreeRenderingContentsResolver : IRenderingContentsResolver
    {
        public bool IncludeServerUrlInMediaUrls { get; set; }
        public bool UseContextItem { get; set; }
        public string ItemSelectorQuery { get; set; }
        public NameValueCollection Parameters { get; set; }
        public object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            //if you want to access the datasource item
            var datasource = !string.IsNullOrEmpty(rendering.DataSource)
                ? rendering.RenderingItem?.Database.GetItem(rendering.DataSource)
                : null;

            return new
            {
                somethingNew = new { datasource.Fields["somethingNew"]?.Value },
                heading = new { datasource.Fields["heading"]?.Value },
                name = new { value = datasource.Name },
                contextItem = new {value = Sitecore.Context.Item.Name},
            };
        }

    }
}