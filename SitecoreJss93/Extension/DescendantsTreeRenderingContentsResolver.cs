using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
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

            var navigationPages = new List<object>();
            var childPages = Sitecore.Context.Item.Children;
            foreach (Item childPage in childPages)
            {
                if (!childPage.TemplateID.Equals(new ID("{A87A00B1-E6DB-45AB-8B54-636FEC3B5523}")))
                {
                    var path = new
                    {
                        value = new
                        {
                            href = childPage.Paths.Path.Replace("/sitecore/content/my-first-jss-app/home", string.Empty),
                            id = childPage.ID,
                            text = childPage.Name,
                            linktype = "internal"
                        }
                    };

                    navigationPages.Add(path);
                }
                
            }

            return new
            {
                childPages = navigationPages,
            };
        }

    }
}