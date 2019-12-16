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
            //var datasource = !string.IsNullOrEmpty(rendering.DataSource)
            //    ? rendering.RenderingItem?.Database.GetItem(rendering.DataSource)
            //    : null;

            return new
            {
                path = new { 
                    value = new { 
                        href = Sitecore.Context.Item.Paths.Path.Replace("/sitecore/content/my-first-jss-app", string.Empty), 
                        id = Sitecore.Context.Item.ID, 
                        text = Sitecore.Context.Item.Name, 
                        linktype = "internal" 
                    }
                },
                childPages = new { value = Sitecore.Context.Item.Children},
            };
        }

    }
}